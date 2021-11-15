using Newtonsoft.Json;

namespace Decisions.ExperianServices.Dao.Auth
{
    /*
     * Data Access Object class for a JSON Oauth2 Response.
     */
    public class OAuthResponse
    {
       [JsonProperty("access_token")]
       public string AccessToken { get; set; }

       [JsonProperty("token_type")]
       public string TokenType { get; set; }

       [JsonProperty("expires_in")]
       public int ExpiresIn { get; set; }

       [JsonProperty("refresh_token")]
       public string RefreshToken { get; set; }
    }
}
