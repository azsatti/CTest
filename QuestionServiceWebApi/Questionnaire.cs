using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuestionServiceWebApi
{
    /// <summary>
    /// Questionaire model
    /// </summary>
    [DataContract]
    public class Questionnaire
    {
        /// <summary>
        /// Questionnaire topic title
        /// </summary>
        [DataMember]
        public string QuestionnaireTitle { get; set; }

        /// <summary>
        /// Questionnaire List
        /// </summary>
        [DataMember]
        public IList<string> QuestionsText { get; set; }
    }
}