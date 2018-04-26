using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace QuestionServiceWebApi.List
{
    /// <summary>
    /// Collection class for questionaire
    /// </summary>
    public static class QuestionnaireList
    {
        static IList<Questionnaire> _list;  
        
        /// <summary>
        /// 
        /// </summary>
        static QuestionnaireList() 
        {
            _list = new List<Questionnaire>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionnaire"></param>
        public static void Add(Questionnaire questionnaire)
        {
            _list.Add(questionnaire);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IList<Questionnaire> GetAll()
        {
            return _list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static Questionnaire GetByTitle(string title)
        {
            return _list.SingleOrDefault(x => x.QuestionnaireTitle == title);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        public static void Delete(string title)
        {
            var removeItem = _list.Single(r => r.QuestionnaireTitle == title);
            _list.Remove(removeItem);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionnaire"></param>
        public static void Update(Questionnaire questionnaire)
        {
            var updateItem = _list.Single(r => r.QuestionnaireTitle == questionnaire.QuestionnaireTitle);
            updateItem.QuestionsText = questionnaire.QuestionsText;
        }
    }
}