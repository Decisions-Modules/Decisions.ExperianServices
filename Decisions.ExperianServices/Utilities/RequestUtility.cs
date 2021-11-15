using System;
using System.IO;
using System.Net;
using Decisions.ExperianServices.Dao.Auth;
using DecisionsFramework;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Utilities
{
    /*
     * Utility Class for making Web Requests
     */
    public class RequestUtility
    {
        private readonly Log _log = new Log(ExperianConstants.LogCat);
        public string RequestUrl { get; set; }
        public string RequestMethod { get; set; }
        public string RequestData { get; set; }
        public string RequestContentType { get; set; }
        public string ClientReferenceId { get; set; }
        private string _oAuthToken;

       /*
        * Create an HTTP Web Request using the current values in 
        * RequestUrl, RequestMethod, RequestData, RequestContentType
        */
        public HttpWebRequest CreateWebRequest(bool isAuthRequest)
        {
            //Setup the Request Data Stream
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(RequestUrl);

            //Only add the auth token and client reference id if this is not an auth request.
            if (!isAuthRequest)
            {
                request.Headers.Add("authorization", "Bearer " + _oAuthToken);
                request.Headers.Add("clientReferenceId", ClientReferenceId);
            }

            //Only set the Accept, Content Type, Method, and Data if it's a POST request.
            if (RequestMethod.Equals("POST"))
            {
                request.Accept = RequestContentType;
                request.ContentType = RequestContentType;
                request.Method = RequestMethod;

                if (RequestData.Length != 0)
                {
                    using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(RequestData);
                        streamWriter.Flush();
                    }
                }
            }

            return request;
        }

        /*
         * Execute an HTTP Request using the current values in 
         * RequestUrl, RequestMethod, RequestData, RequestContentType
         */
        public HttpWebResponse ExecuteRequest(bool isAuthRequest)
        {
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = CreateWebRequest(isAuthRequest);
                WebResponse webResponse = request.GetResponse();
                if (webResponse is HttpWebResponse)
                {
                    response = webResponse as HttpWebResponse;
                }
            }
            catch (WebException ex)
            {
                _log.Error(ex, "There was an issue executing the request.");
                throw;
            }
            
            return response;
        } 

       /*
        * Execute the Authentication Request to set the Authentication Token.
        */
        public void ExecuteAuthRequest()
        {
            try
            {
                HttpWebResponse response = (HttpWebResponse) CreateWebRequest(true).GetResponse();
                string responseString = GetResponseString(response);
                JsonUtility.ParseAndLogJson(responseString);
                _oAuthToken = JsonConvert.DeserializeObject<OAuthResponse>(responseString).AccessToken;
            }
            catch (Exception ex)
            {
                _log.Error(ex, "There was an error executing the authentication request.");
            }
        }

        /*
         * Get the string representation of an HTTP response.
         */
        public string GetResponseString(HttpWebResponse response)
        {
            string responseString = string.Empty;
            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream != null)
                    using (StreamReader streamReader = new StreamReader(dataStream))
                    {
                        responseString = streamReader.ReadToEnd();
                    }
            }

            response.Close();

            return responseString;
        }
    }
}
