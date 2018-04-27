using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using PairingTest.Web.Models;
using PairingTest.Web.Utility;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly HttpClient _httpClient;

        public QuestionnaireController() : this (null)
        {
        }

        public QuestionnaireController(IApiClient apiClient = null)
        {
            var apiClient1 = apiClient ?? new ApiClient(new ApiSettings());

            _httpClient = apiClient1.Get;
        }

        public async Task<ViewResult> Index()
        {
            HttpResponseMessage responseMessage = await _httpClient.GetAsync("api/questions");
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = await responseMessage.Content.ReadAsStringAsync();

                var questions = JsonConvert.DeserializeObject<QuestionnaireViewModel>(responseData);

                return View(questions);
            }
            return View("Error");
        }
    }
}
