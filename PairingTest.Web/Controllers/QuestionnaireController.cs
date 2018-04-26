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
        private readonly HttpClient _apiClient;

        public QuestionnaireController() : this(new ApiClient())
        {
        }

        private QuestionnaireController(ApiClient apiClient)
        {
            _apiClient = apiClient.Instance;
        }

        public async Task<ViewResult> Index()
        {
           
            HttpResponseMessage responseMessage = await _apiClient.GetAsync("api/questions");
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;

                var questions = JsonConvert.DeserializeObject<QuestionnaireViewModel>(responseData);

                return View(questions);
            }
            return View("Error");
        }
    }
}
