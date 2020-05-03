
using System.Net.Http;
using System.Threading.Tasks;
using TicketDataHandler.Models;
using TicketDataHandler.Responses;

namespace TicketDataHandler
{
    public class Auth
    {
        public async Task<AuthResponse> Authenticate(ClientCreds creds)
        {
            using (HttpResponseMessage responseMessage =
                await HttpClientBuilder.HttpClient.PostAsJsonAsync($"{HttpClientBuilder.BaseUrl}auth",creds))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    AuthResponse authResponse = await responseMessage.Content.ReadAsAsync<AuthResponse>();
                    return authResponse;
                }
                else
                {
                    return new AuthResponse()
                    {
                        Error = true,
                        Message = responseMessage.ReasonPhrase
                    };
                }
            }
        }
    }
}
