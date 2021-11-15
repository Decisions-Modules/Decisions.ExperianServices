using Newtonsoft.Json;

namespace Decisions.ExperianServices.Dao.Auth
{
    /*
     * Data Access Object class for a JSON Oauth2 Request.
     */
    public class OAuthRequest
    {
       [JsonProperty("username")]
       public string Username { get; set; }

       [JsonProperty("password")]
       public string Password { get; set; }

       [JsonProperty("client_id")]
       public string ClientId { get; set; }

       [JsonProperty("client_secret")]
       public string ClientSecret { get; set; }
    }
}
