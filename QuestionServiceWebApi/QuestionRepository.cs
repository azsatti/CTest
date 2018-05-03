using System.Collections.Generic;
using QuestionServiceWebApi.Interfaces;

namespace QuestionServiceWebApi
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IQuestionsProvider _questionProvider; 
        public QuestionRepository(IQuestionsProvider questionProvider)
        {
            _questionProvider = questionProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Questionnaire GetQuestionnaire()
        {
            return _questionProvider.GetQuestionnaire();
        }
    }
}