using System.Net;
using Decisions.ExperianServices.Dao.Verify;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework.ServiceLayer;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Verify
{
    public class VerifyFetcher : AbstractFetcher
    {
        /*
         * Executes an Experian Verify Request
         */
        public static ExperianVerifyResponse ExecuteVerifyRequest(ExperianVerifyRequest request, 
            VerifyType type,
            bool overrideCredentials = false, 
            string clientReferenceId = "")
        {
            clientReferenceId = overrideCredentials ? clientReferenceId : ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientReferenceId;

            if (string.IsNullOrEmpty(clientReferenceId))
            {
                return null;
            }
            
            string endpoint = "";

            switch(type)
            {
                case VerifyType.VerifyPlus:
                    endpoint = "experianverify";
                    break;
            }

            RequestUtility.RequestUrl = string.Format($"{AuthenticationUtility.DetermineConnectionString()}/{endpoint}");
            RequestUtility.RequestMethod = "POST";

            string requestString = JsonConvert.SerializeObject(request, JsonSettings);
            Log.Debug($"Request String: {requestString}");

            RequestUtility.RequestData = requestString;
            RequestUtility.RequestContentType = "application/json";
            RequestUtility.ClientReferenceId = clientReferenceId;

            HttpWebResponse response = RequestUtility.ExecuteRequest(false);

            if (response != null)
            {
                string responseString = RequestUtility.GetResponseString(response);
                JsonUtility.ParseAndLogJson(responseString);
                return JsonConvert.DeserializeObject<ExperianVerifyResponse>(responseString, JsonSettings);
            }

            return null;
        }
    }
}