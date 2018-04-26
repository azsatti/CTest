using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace QuestionServiceWebApi.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public class GlobalExceptionHandler : ExceptionHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Handle(ExceptionHandlerContext context)
        {
            var error = "An unhandled exception occured, check log.";
            context.Result = new ServerError(error, context.Request);
        }
    }
}