using System;
using System.Net.Http;
using System.Text;

namespace Persistencia
{
    public class WebHelper
    {
        static HttpClient HttpClient = new HttpClient();
        static String RutaBase = "https://cai-tp.azurewebsites.net";

        public static HttpResponseMessage Get(string url)
        {
            var uri = RutaBase + url;

            HttpResponseMessage response = HttpClient.GetAsync(uri).Result;  // Blocking call!

            return response;
        }

        public static HttpResponseMessage Post(string url, string jsonRequest)
        {
            var uri = RutaBase + url;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = HttpClient.PostAsync(uri, data).Result;

            return response;
        }

        public static HttpResponseMessage Put(string url, string jsonRequest)
        {
            var uri = RutaBase + url;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = HttpClient.PutAsync(uri, data).Result;

            return response;
        }

        public static HttpResponseMessage Patch(string path, string jsonRequest)
        {
            var uri = RutaBase + path;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            var request =
                new HttpRequestMessage(new HttpMethod("PATCH"), uri)
                {
                    Content = data
                };

            HttpResponseMessage response = HttpClient.SendAsync(request).Result;

            return response;
        }

        public static HttpResponseMessage Delete(string url)
        {
            var uri = RutaBase + url;

            HttpResponseMessage response = HttpClient.DeleteAsync(uri).Result;

            return response;
        }

        public static HttpResponseMessage DeleteWithBody(string url, string jsonRequest)
        {
            var uri = RutaBase + url;

            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(uri),
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = HttpClient.SendAsync(request).Result;

            return response;
        }
    }
}

