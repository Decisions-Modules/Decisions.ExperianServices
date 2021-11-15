using System.Net;
using Decisions.ExperianServices.Dao.Auth;
using Decisions.ExperianServices.Dao.CreditReport;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework;
using DecisionsFramework.ServiceLayer;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.ConsumerCreditProfile
{
    public class ConsumerReportFetcher
    {
        private readonly Log _log = new Log(ExperianConstants.LogCat);
        private const string BaseUrl = "https://sandbox-us-api.experian.com";
        private readonly RequestUtility _requestUtility = new RequestUtility();
        private readonly JsonSerializerSettings _jsonSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        /*
         * Execute an Authentication Request
         */
        public void ExecuteAuthRequest()
        {
            _requestUtility.RequestUrl = string.Format($"{DetermineConnectionString()}/oauth2/v1/token");
            _requestUtility.RequestMethod = "POST";

            OAuthRequest request = new OAuthRequest
            {
                ClientId = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientId,
                ClientSecret = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientSecret,
                Username = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianUsername,
                Password = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianPassword
            };

            if (string.IsNullOrEmpty(request.ClientId) || string.IsNullOrEmpty(request.ClientSecret) ||
                string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
            {
                return;
            }

            string requestString = JsonConvert.SerializeObject(request, Formatting.None, _jsonSettings);
            _log.Debug($"Request String: {requestString}");

            _requestUtility.RequestData = requestString;
            _requestUtility.RequestContentType = "application/json";
            _requestUtility.ExecuteAuthRequest();
        }

        /*
         * Execute a Consumer Credit Report Request
         */
        public ExperianCreditReportResponse ExecuteCreditReportRequest(ExperianCreditReportRequest request)
        {
            string clientReferenceId = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientReferenceId;

            if (string.IsNullOrEmpty(clientReferenceId))
            {
                return null;
            }

            _requestUtility.RequestUrl = string.Format($"{DetermineConnectionString()}/consumerservices/credit-profile/v2/credit-report");
            _requestUtility.RequestMethod = "POST";

            string requestString = JsonConvert.SerializeObject(request, _jsonSettings);
            _log.Debug($"Request String: {requestString}");

            _requestUtility.RequestData = requestString;
            _requestUtility.RequestContentType = "application/json";
            _requestUtility.ClientReferenceId = clientReferenceId;

            HttpWebResponse response = _requestUtility.ExecuteRequest(false);

            if (response != null)
            {
                string responseString = _requestUtility.GetResponseString(response);
                JsonUtility.ParseAndLogJson(responseString);
                return JsonConvert.DeserializeObject<ExperianCreditReportResponse>(responseString, _jsonSettings);
            }

            return null;
        }

        private string DetermineConnectionString()
        {
            string urlFromSystemSettings = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianCoreApiUrl;
            if (string.IsNullOrEmpty(urlFromSystemSettings))
            {
                return BaseUrl;
            }
            return urlFromSystemSettings;
        }
    }
}