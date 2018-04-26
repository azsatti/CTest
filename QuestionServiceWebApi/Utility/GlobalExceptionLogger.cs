using System.Net.Http;
using System.Web;
using System.Web.Http.ExceptionHandling;
using log4net;

namespace QuestionServiceWebApi.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public class GlobalExceptionLogger : ExceptionLogger
    {
        private const string HttpContextBaseKey = "MS_HttpContext";

        private static readonly ILog Logger = LogManager.GetLogger(typeof(GlobalExceptionLogger));

        public override void Log(ExceptionLoggerContext context)
        {
            var httpContext = GetHttpContext(context.Request);
            if (httpContext == null)
            {
                return;
            }

            var exceptionToRaise = new HttpUnhandledException(message: null, innerException: context.Exception);

            string exceptionMessage =
                $"Unhandled exception processing {context.Request.Method} for {context.Request.RequestUri}.";
            Logger.Error(exceptionMessage, exceptionToRaise);
        }

        private static HttpContextBase GetHttpContext(HttpRequestMessage request)
        {
            if (request == null)
            {
                return null;
            }

            object value;

            if (!request.Properties.TryGetValue(HttpContextBaseKey, out value))
            {
                return null;
            }

            return value as HttpContextBase;
        }

    }
}