using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TicketDataHandler.Responses;

namespace TicketDataHandler
{
    public class EventsHandler
    {
        private string token;
        public EventsHandler(string token)
        {
            this.token = token;
        }

        public async Task<EventsResponse> GetEvents(string type)
        {
            string url = $"{HttpClientBuilder.BaseUrl}events";
            if(type != null && !type.Equals(""))
            {
                url += $"?type={type}"; //filter events (upcoming or finished)
            }

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Bearer {token}" }
                }
            };

            var response = await HttpClientBuilder.HttpClient.SendAsync(httpRequestMessage);
            if (response.IsSuccessStatusCode)
            {
                if (response.Content == null)
                {
                    return new EventsResponse()
                    {
                        Error = true,
                        Message = "Content null",
                        Events = null
                    };
                }

                EventsResponse eventResponse =
                    await response.Content.ReadAsAsync<EventsResponse>();
                return eventResponse;
            }
            else
            {
                return new EventsResponse()
                {
                    Error = true,
                    Message = response.ReasonPhrase,
                    Events = null
                };
            }
        }
    }
}
