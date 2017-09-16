using System.Threading.Tasks;
using RestSharp;

namespace Sklad.Silverlight.Api.Auth
{
    public class AuthApi
    {
        private readonly string baseUrl;

        public AuthApi(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public Task<bool> Login(string login, string password)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("/Token");

            var tcs = new TaskCompletionSource<bool>();

            client.ExecuteAsync(request, response =>
            {
                tcs.SetResult(false);
            });

            return tcs.Task;
        }
    }
}
