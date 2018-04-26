using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PairingTest.Web.Utility
{
    public class ApiClient
    {
        static HttpClient _client;
        public ApiClient()
        {
            var apiUrl = ConfigurationManager.AppSettings["QuestionnaireServiceUri"];

            _client = new HttpClient
            {
                BaseAddress = new Uri(apiUrl)
            };

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public HttpClient Instance => _client;
    }
}