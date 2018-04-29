using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using PairingTest.Web.Interfaces;

namespace PairingTest.Web.Utility
{
    public class ApiClient : IApiClient
    {
        readonly HttpClient _client = new HttpClient();
        public ApiClient(IApiSettings settings)
        {
            var apiUrl = settings.ApiUrl;

            _client.BaseAddress = new Uri(apiUrl);           

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("HeaderKey",
                "Anyvalue");
        }    
        

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _client.GetAsync(url);
        }
    }
}