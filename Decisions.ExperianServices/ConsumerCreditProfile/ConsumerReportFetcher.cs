using System.Net;
using Decisions.ExperianServices.Dao.CreditReport;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework;
using DecisionsFramework.ServiceLayer;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.ConsumerCreditProfile
{
    public class ConsumerReportFetcher
    {
        private readonly Log _log = new(ExperianConstants.LogCat);
        private static readonly AuthenticationUtility AuthenticationUtility = new();
        private readonly JsonSerializerSettings _jsonSettings = new()
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        /*
         * Execute a Consumer Credit Report Request
         */
        public ExperianCreditReportResponse ExecuteCreditProfileRequest(ExperianCreditReportRequest request, CreditProfileType type)
        {
            string clientReferenceId = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientReferenceId;

            if (string.IsNullOrEmpty(clientReferenceId))
            {
                return null;
            }
            
            string endpoint = "";

            switch(type)
            {
                case CreditProfileType.CreditReport:
                    endpoint = "v2/credit-report";
                    break;
                case CreditProfileType.ScoreOnlyPrequalification:
                    endpoint = "v1/score-only-prequalification";
                    break;
            }

            RequestUtility.RequestUrl = string.Format($"{AuthenticationUtility.DetermineConnectionString()}/consumerservices/credit-profile/{endpoint}");
            RequestUtility.RequestMethod = "POST";

            string requestString = JsonConvert.SerializeObject(request, _jsonSettings);
            _log.Debug($"Request String: {requestString}");

            RequestUtility.RequestData = requestString;
            RequestUtility.RequestContentType = "application/json";
            RequestUtility.ClientReferenceId = clientReferenceId;

            HttpWebResponse response = RequestUtility.ExecuteRequest(false);

            if (response != null)
            {
                string responseString = RequestUtility.GetResponseString(response);
                JsonUtility.ParseAndLogJson(responseString);
                return JsonConvert.DeserializeObject<ExperianCreditReportResponse>(responseString, _jsonSettings);
            }

            return null;
        }
    }
}