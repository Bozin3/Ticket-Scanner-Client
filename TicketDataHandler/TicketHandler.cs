using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TicketDataHandler.Models;
using TicketDataHandler.Responses;

namespace TicketDataHandler
{
    public class TicketHandler
    {
        private Event chosenEvent;
        private string token;

        public TicketHandler(Event chosenEvent, string token)
        {
            this.chosenEvent = chosenEvent;
            this.token = token;
        }

        public async Task<TicketsResponse<List<Ticket>>> GetTickets(string type)
        {
            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{HttpClientBuilder.BaseUrl}{chosenEvent.Id}/ticket?type={type}"),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Bearer {token}" }
                }
            };

            var response = await HttpClientBuilder.HttpClient.SendAsync(httpRequestMessage);
            if (response.IsSuccessStatusCode)
            {
                if(response.Content == null)
                {
                    return new TicketsResponse<List<Ticket>>()
                    {
                        Error = true,
                        Message = "Content null",
                        Ticket = null
                    };
                }

                TicketsResponse<List<Ticket>> ticketResponse = 
                    await response.Content.ReadAsAsync<TicketsResponse<List<Ticket>>>();
                return ticketResponse;
            }
            else
            {
                return new TicketsResponse<List<Ticket>>()
                {
                    Error = true,
                    Message = response.ReasonPhrase,
                    Ticket = null
                };
            }
        }

        public async Task<TicketsResponse<Ticket>> CheckTicket(string barcode)
        {

            var httpRequestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{HttpClientBuilder.BaseUrl}{chosenEvent.Id}/ticket/{barcode}"),
                Headers = {
                    { HttpRequestHeader.Authorization.ToString(), $"Bearer {token}" }
                }
            };

            var response = await HttpClientBuilder.HttpClient.SendAsync(httpRequestMessage);
            if (response.IsSuccessStatusCode)
            {
                if (response.Content == null)
                {
                    return new TicketsResponse<Ticket>()
                    {
                        Error = true,
                        Message = "Content null",
                        Ticket = null
                    };
                }

                TicketsResponse<Ticket> ticketResponse =
                    await response.Content.ReadAsAsync<TicketsResponse<Ticket>>();
                return ticketResponse;
            }
            else
            {
                return new TicketsResponse<Ticket>()
                {
                    Error = true,
                    Message = response.ReasonPhrase,
                    Ticket = null
                };
            }
        }
    }
}
