using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;

namespace QuestionServiceWebApi.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public class ApiKeyHandler : DelegatingHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!request.RequestUri.AbsolutePath.Contains("swagger"))
            {
                var apiKey = request.Headers.GetValues(Constants.HeaderKey).FirstOrDefault();

                if (string.IsNullOrEmpty(apiKey))
                {
                    return await TokenInvalidResponseAsync(cancellationToken);
                }
            }
            

            var response = await base.SendAsync(request,
                cancellationToken);

            // Return the response back up the chain
            return response;
        }

        private static async Task<HttpResponseMessage> TokenInvalidResponseAsync(CancellationToken cancellationToken)
        {
            return await Task.Factory.StartNew(
                () => new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new ObjectContent(typeof (object),
                        "Invalid Token",
                        new JsonMediaTypeFormatter())
                },
                cancellationToken);

        }
    }
}