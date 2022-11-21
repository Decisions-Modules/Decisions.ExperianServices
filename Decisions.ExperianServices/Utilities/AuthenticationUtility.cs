using Decisions.ExperianServices.Dao.Auth;
using DecisionsFramework;
using DecisionsFramework.ServiceLayer;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Utilities
{
    public class AuthenticationUtility
    {
        private static readonly Log Log = new(ExperianConstants.LogCat);
        private const string BaseUrl = "https://sandbox-us-api.experian.com";
        private static readonly JsonSerializerSettings JsonSettings = new()
        {
            NullValueHandling = NullValueHandling.Ignore
        };
        
        public static void ExecuteAuthRequest(
            ExperianApi experianApi, 
            bool overrideCredentials = false, 
            string userName = "", 
            string password = "", 
            string clientId = "", 
            string clientSecret = "")
        {
            RequestUtility.RequestUrl = string.Format($"{DetermineConnectionString()}/oauth2/v1/token");
            RequestUtility.RequestMethod = "POST";

            string finalUserName = overrideCredentials
                ? userName
                : ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianUsername;
            
            string finalPassword = overrideCredentials
                ? password
                : ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianPassword;
            
            string finalClientId = overrideCredentials
                ? clientId
                : ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientId;
            
            string finalClientSecret = overrideCredentials
                ? clientSecret
                : ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientSecret;

            OAuthRequest request = new OAuthRequest
            {
                Username = finalUserName,
                Password = finalPassword
            };
            
            switch (experianApi){
                case ExperianApi.CreditProfile:
                    request.ClientId = overrideCredentials ? finalClientId : ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientId;
                    request.ClientSecret = overrideCredentials ? finalClientSecret : ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientSecret;
                    break;
                case ExperianApi.Prequalification:
                    request.ClientId = overrideCredentials ? finalClientId : ModuleSettingsAccessor<ExperianSettings>.Instance.PrequalificationClientId;
                    request.ClientSecret = overrideCredentials ? finalClientSecret : ModuleSettingsAccessor<ExperianSettings>.Instance.PrequalificationClientSecret;
                    break;
                case ExperianApi.Verify:
                    request.ClientId = overrideCredentials ? finalClientId : ModuleSettingsAccessor<ExperianSettings>.Instance.VerifyClientId;
                    request.ClientSecret = overrideCredentials ? finalClientSecret : ModuleSettingsAccessor<ExperianSettings>.Instance.VerifyClientSecret;
                    break;
            }

            if (string.IsNullOrEmpty(request.ClientId) || string.IsNullOrEmpty(request.ClientSecret) ||
                string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
            {
                return;
            }

            string requestString = JsonConvert.SerializeObject(request, Formatting.None, JsonSettings);
            Log.Debug($"Request String: {requestString}");

            RequestUtility.RequestData = requestString;
            RequestUtility.RequestContentType = "application/json";
            RequestUtility.ExecuteAuthRequest();
        }
        
        public static string DetermineConnectionString()
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