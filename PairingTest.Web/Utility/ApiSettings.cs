using System.Collections.Specialized;
using System.Configuration;
using PairingTest.Web.Interfaces;

namespace PairingTest.Web.Utility
{
    public class ApiSettings : IApiSettings
    {
        private readonly NameValueCollection _apiSettings;
        private string _apiUrl;
        public ApiSettings()
        {
            _apiSettings = (NameValueCollection) ConfigurationManager.GetSection("appSettings");
            _apiUrl = _apiSettings["QuestionnaireServiceUri"];
        }

        public string ApiUrl => _apiUrl;
    }
}