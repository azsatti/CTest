using System.Collections.Generic;

namespace QuestionServiceWebApi.Interfaces
{
    /// <summary>
    /// This interface exposes the methods need.
    /// </summary>
    public interface IQuestionRepository
    {
       /// <summary>
        /// To get questionare
        /// </summary>
        /// <returns></returns>
        Questionnaire GetQuestionnaire();
    }
}