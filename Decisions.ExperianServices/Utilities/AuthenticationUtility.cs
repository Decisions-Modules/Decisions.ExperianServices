using Decisions.ExperianServices.Dao.Auth;
using DecisionsFramework;
using DecisionsFramework.ServiceLayer;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Utilities
{
    public class AuthenticationUtility
    {
        private readonly Log _log = new(ExperianConstants.LogCat);
        private const string BaseUrl = "https://sandbox-us-api.experian.com";
        private readonly JsonSerializerSettings _jsonSettings = new()
        {
            NullValueHandling = NullValueHandling.Ignore
        };
        
        public void ExecuteAuthRequest(ExperianApi experianApi)
        {
            RequestUtility.RequestUrl = string.Format($"{DetermineConnectionString()}/oauth2/v1/token");
            RequestUtility.RequestMethod = "POST";

            OAuthRequest request = new OAuthRequest
            {
                Username = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianUsername,
                Password = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianPassword
            };
            
            switch (experianApi){
                case ExperianApi.CreditProfile:
                    request.ClientId = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientId;
                    request.ClientSecret = ModuleSettingsAccessor<ExperianSettings>.Instance.ExperianClientSecret;
                    break;
                case ExperianApi.Prequalification:
                    request.ClientId = ModuleSettingsAccessor<ExperianSettings>.Instance.PrequalificationClientId;
                    request.ClientSecret = ModuleSettingsAccessor<ExperianSettings>.Instance.PrequalificationClientSecret;
                    break;
            }

            if (string.IsNullOrEmpty(request.ClientId) || string.IsNullOrEmpty(request.ClientSecret) ||
                string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
            {
                return;
            }

            string requestString = JsonConvert.SerializeObject(request, Formatting.None, _jsonSettings);
            _log.Debug($"Request String: {requestString}");

            RequestUtility.RequestData = requestString;
            RequestUtility.RequestContentType = "application/json";
            RequestUtility.ExecuteAuthRequest();
        }
        
        public string DetermineConnectionString()
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