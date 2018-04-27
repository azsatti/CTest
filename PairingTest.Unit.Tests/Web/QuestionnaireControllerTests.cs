using Moq;
using NUnit.Framework;
using PairingTest.Web.Controllers;
using PairingTest.Web.Interfaces;
using PairingTest.Web.Models;
using PairingTest.Web.Utility;

namespace PairingTest.Unit.Tests.Web
{
    [TestFixture]
    public class QuestionnaireControllerTests
    {
        [Test]
        public void ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "Geography Questions";
            var mockedApiSettings = new Mock<IApiSettings>();
            mockedApiSettings.Setup(x => x.ApiUrl).Returns("http://localhost:50014/");
            var mockedApiClient = new Mock<ApiClient>(mockedApiSettings.Object);
            var questionnaireController = new QuestionnaireController(mockedApiClient.Object);

            //Act
            var result = (QuestionnaireViewModel)questionnaireController.Index().Result.ViewData.Model;
            
            //Assert
            Assert.That(result.QuestionnaireTitle, Is.EqualTo(expectedTitle));
        }
    }
}