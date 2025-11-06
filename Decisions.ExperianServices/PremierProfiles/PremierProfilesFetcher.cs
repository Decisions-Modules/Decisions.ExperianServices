using System.Net;
using Decisions.ExperianServices.Dao.PremierProfiles;
using Decisions.ExperianServices.Utilities;
using DecisionsFramework.ServiceLayer;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.PremierProfiles
{
    public class PremierProfilesFetcher : AbstractFetcher
    {
        public static PremierProfilesResponse ExecutePremierProfilesRequest(ExperianPremierProfilesRequest request,
            bool overrideCredentials = false, string clientReferenceId = "")
        {
            clientReferenceId = overrideCredentials ? clientReferenceId : ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientReferenceId;

            if (string.IsNullOrEmpty(clientReferenceId))
                return null;

            RequestUtility.RequestUrl = string.Format($"{AuthenticationUtility.DetermineConnectionString()}/businessinformation/businesses/v1/reports/premierprofiles");
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
                return JsonConvert.DeserializeObject<PremierProfilesResponse>(responseString, JsonSettings);
            }

            return null;
        }
    }
}