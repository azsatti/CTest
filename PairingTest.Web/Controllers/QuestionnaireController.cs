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
        private readonly IApiClient _apiClient;
                
        public QuestionnaireController(IApiClient apiClient = null)
        {
            _apiClient = apiClient ?? new ApiClient(new ApiSettings());
        }

        public async Task<ViewResult> Index()
        {
            HttpResponseMessage responseMessage = await _apiClient.GetAsync("api/questions");
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
