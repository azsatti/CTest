using QuestionServiceWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionServiceWebApi
{
    /// <summary>
    /// 
    /// </summary>
    public class QuestionProvider : IQuestionsProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Questionnaire GetQuestionnaire()
        {
            return new Questionnaire
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>
                                           {
                                               "What is the capital of Cuba?",
                                               "What is the capital of France?",
                                               "What is the capital of Poland?",
                                               "What is the capital of Germany?"
                                           }
            };
        }
    }
}