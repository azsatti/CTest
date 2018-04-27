using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using PairingTest.Web.Interfaces;

namespace PairingTest.Web.Utility
{
    public class ApiClient : IApiClient
    {
        static HttpClient _client;
        public ApiClient(IApiSettings settings)
        {
            var apiUrl = settings.ApiUrl;

            _client = new HttpClient
            {
                BaseAddress = new Uri(apiUrl)
            };

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("HeaderKey",
                "Anyvalue");
        }
        
        public HttpClient Get => _client;
    }
}