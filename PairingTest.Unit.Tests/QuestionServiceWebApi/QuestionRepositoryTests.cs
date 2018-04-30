using Moq;
using NUnit.Framework;
using QuestionServiceWebApi;
using QuestionServiceWebApi.Interfaces;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi
{
    [TestFixture]
    public class QuestionRepositoryTests
    {
        [Test]
        public void ShouldGetExpectedQuestionnaire()
        {
            var mocked = new Mock<IQuestionsProvider>();
            var questionRepository = new QuestionRepository(mocked.Object);

            var questionnaire = questionRepository.GetQuestionnaire();

            Assert.That(questionnaire.QuestionnaireTitle, Is.EqualTo("Geography Questions"));
            Assert.That(questionnaire.QuestionsText[0], Is.EqualTo("What is the capital of Cuba?"));
            Assert.That(questionnaire.QuestionsText[1], Is.EqualTo("What is the capital of France?"));
            Assert.That(questionnaire.QuestionsText[2], Is.EqualTo("What is the capital of Poland?"));
            Assert.That(questionnaire.QuestionsText[3], Is.EqualTo("What is the capital of Germany?"));
        }
    }
}