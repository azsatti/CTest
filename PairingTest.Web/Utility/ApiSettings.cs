using System.Collections.Specialized;
using System.Configuration;
using PairingTest.Web.Interfaces;

namespace PairingTest.Web.Utility
{
    public class ApiSettings : IApiSettings
    {
        private readonly NameValueCollection _apiSettings;
        public ApiSettings()
        {
            _apiSettings = (NameValueCollection) ConfigurationManager.GetSection("appSettings");
        }

        public string ApiUrl => _apiSettings["QuestionnaireServiceUri"];
    }
}