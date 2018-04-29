using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionServiceWebApi.Interfaces
{
    public interface IQuestionsProvider
    {
        Questionnaire GetQuestionnaire();
    }
}