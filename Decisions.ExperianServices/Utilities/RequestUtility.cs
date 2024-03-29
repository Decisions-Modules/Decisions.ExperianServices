﻿using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using Decisions.ExperianServices.Dao.Auth;
using DecisionsFramework;
using Newtonsoft.Json;

namespace Decisions.ExperianServices.Utilities
{
    /*
     * Utility Class for making Web Requests
     */
    public static class RequestUtility
    {
        private static readonly Log Log = new Log(ExperianConstants.LogCat);
        public static string RequestUrl { get; set; }
        public static string RequestMethod { get; set; }
        public static string RequestData { get; set; }
        public static string RequestContentType { get; set; }
        public static string ClientReferenceId { get; set; }
        public static string SubCode { get; set; }
        private static string _oAuthToken;

       /*
        * Create an HTTP Web Request using the current values in 
        * RequestUrl, RequestMethod, RequestData, RequestContentType
        */
       private static HttpWebRequest CreateWebRequest(bool isAuthRequest)
        {
            //Setup the Request Data Stream
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(RequestUrl);

            //Only add the auth token and client reference id if this is not an auth request.
            if (!isAuthRequest)
            {
                request.Headers.Add("authorization", "Bearer " + _oAuthToken);
                request.Headers.Add("clientReferenceId", ClientReferenceId);

                if (!string.IsNullOrEmpty(SubCode))
                {
                    request.Headers.Add("subcode", SubCode);
                }
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
        public static HttpWebResponse ExecuteRequest(bool isAuthRequest)
        {
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = CreateWebRequest(isAuthRequest);
                WebResponse webResponse = request.GetResponse();
                if (webResponse is HttpWebResponse httpWebResponse)
                {
                    response = httpWebResponse;
                }
            }
            catch (WebException ex)
            {
                string errorContent = "There was an issue processing the request";

                if (ex.Response?.GetResponseStream() != null)
                {
                    errorContent = new StreamReader(ex.Response?.GetResponseStream()).ReadToEnd();
                }
                
                throw new BusinessRuleException(errorContent);
            }
            
            return response;
        } 

       /*
        * Execute the Authentication Request to set the Authentication Token.
        */
        public static void ExecuteAuthRequest()
        {
            try
            {
                HttpWebResponse response = (HttpWebResponse) CreateWebRequest(true).GetResponse();
                string responseString = GetResponseString(response);
                JsonUtility.ParseAndLogJson(responseString);
                _oAuthToken = JsonConvert.DeserializeObject<OAuthResponse>(responseString)?.AccessToken;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "There was an error executing the authentication request.");
                throw new BusinessRuleException(ex.Message);
            }
        }

        /*
         * Get the string representation of an HTTP response.
         */
        public static string GetResponseString(HttpWebResponse response)
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
