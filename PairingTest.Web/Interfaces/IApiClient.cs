using System.Net.Http;

namespace PairingTest.Web.Utility
{
    public interface IApiClient
    {
        HttpClient Get { get; }
    }
}