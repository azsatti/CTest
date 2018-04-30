using NUnit.Framework;
using QuestionServiceWebApi.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi
{
    [TestFixture]
    public class NotImplementedExceptionFilterTest
    {

        [Test]
        public void OnExceptionTests()
        {
            var ex = Assert.Throws<NotImplementedException>(() => ExceptionTest.Execute());                        
        }
        

        public static class ExceptionTest
        {
            [NotImplementedExceptionFilter]
            public static void Execute()
            {
                throw new NotImplementedException();
            }
        }
    }
}
