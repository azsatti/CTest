using System.Net.Http;
using System.Threading.Tasks;

namespace PairingTest.Web.Utility
{
    public interface IApiClient
    {
        Task<HttpResponseMessage> GetAsync(string url);
    }
}