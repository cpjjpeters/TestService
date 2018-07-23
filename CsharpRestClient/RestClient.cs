﻿using System;
using System.IO;
using System.Net;

namespace CsharpRestClient
{

    public enum httpVerb
    {
        GET, POST, PUT, DELETE
    }
    public class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb  httpMethod { get; set; }

        public RestClient()
        {
            endPoint = String.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) 
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code "+ response.StatusCode.ToString());
                }
                // process the restponse stram.. (could be vanalles

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }// end of streamReader
                    }
                }// end of using responsstreeam
            }
            return strResponseValue;
        }
    }
}