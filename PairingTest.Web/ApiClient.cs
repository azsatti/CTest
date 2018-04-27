using System.Net.Http;

namespace PairingTest.Web
{
    public interface IApiClient
    {
        HttpClient Get { get; }
    }
}