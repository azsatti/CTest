using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace QuestionServiceWebApi.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public class ServerError : IHttpActionResult
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="request"></param>
        public ServerError(string content, HttpRequestMessage request)
        {
            this.Content = content;
            this.Request = request;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(this.Execute());
        }

        private string Content { get; set; }
        private  HttpRequestMessage Request { get; set; }

        private HttpResponseMessage Execute()
        {
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                RequestMessage = this.Request,
                Content = new ObjectContent(typeof (object),
                    this.Content,
                    new JsonMediaTypeFormatter())
            };

            return response;
        }
    }
}