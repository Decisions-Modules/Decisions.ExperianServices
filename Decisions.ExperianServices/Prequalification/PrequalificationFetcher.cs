using System.Net;
using Decisions.ExperianServices.Dao.Prequalification;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework;
using DecisionsFramework.ServiceLayer;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Prequalification
{
    public class PrequalificationFetcher
    {
        private readonly Log _log = new(ExperianConstants.LogCat);
        private static readonly AuthenticationUtility AuthenticationUtility = new();
        private readonly JsonSerializerSettings _jsonSettings = new()
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        /*
         * Executes an Experian Prequalification Request
         */
        public ExperianPrequalificationResponse ExecutePrequalificationRequest(ExperianPrequalificationRequest request, 
            PrequalificationType type)
        {
            string clientReferenceId = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientReferenceId;

            if (string.IsNullOrEmpty(clientReferenceId))
            {
                return null;
            }
            
            string endpoint = "";

            switch(type)
            {
                case PrequalificationType.CreditScore:
                    endpoint = "credit-score";
                    break;
                case PrequalificationType.CreditReport:
                    endpoint = "credit-report";
                    break;
            }

            RequestUtility.RequestUrl = string.Format($"{AuthenticationUtility.DetermineConnectionString()}/consumerservices/prequal/v1/{endpoint}");
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
                return JsonConvert.DeserializeObject<ExperianPrequalificationResponse>(responseString, _jsonSettings);
            }

            return null;
        }
    }
}