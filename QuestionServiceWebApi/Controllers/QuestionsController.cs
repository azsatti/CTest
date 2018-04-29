using System.Web.Http;
using QuestionServiceWebApi.Interfaces;

namespace QuestionServiceWebApi.Controllers
{
    public class QuestionsController : ApiController
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionsController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        //public QuestionsController() : this(new QuestionRepository())
        //{
        //}

        // GET api/questions
        /// <summary>
        /// Gets all questions.
        /// </summary>
        /// <remarks>
        /// Get a list of all questions.
        /// </remarks>
        /// <returns>Questionnaire model</returns>
        public Questionnaire Get()
        {
            return _questionRepository.GetQuestionnaire();
        }

        // GET api/questions/5
        public string Get(int id)
        {
            return "";
        }

        // POST api/questions
        public void Post([FromBody]string value)
        {
        }

        // PUT api/questions/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/questions/5
        public void Delete(int id)
        {
        }
    }
}
