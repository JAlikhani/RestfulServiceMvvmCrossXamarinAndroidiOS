using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace RestfulServiceXamarinAndroidiOS.Services
{
    public class WebService
    {
        public static async Task<T> GetURL<T>(string url, string method, string contentType)
        {
            try
            {
                // Create an HTTP web request using the URL:
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
                request.ContentType = contentType;
                request.Method = method;
                // Send the request to the server and wait for the response:
                using (WebResponse response = await request.GetResponseAsync())
                {
                    // Get a stream representation of the HTTP web response:
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader streamReader = new StreamReader(stream);
                        string json = streamReader.ReadToEnd();
                        T output = JsonConvert.DeserializeObject<T>(json);
                        return output;
                    }
                }
            }
            catch (Exception e)
            {
                string msg = e.ToString();
                return default(T);
            }
        }
    }
}
