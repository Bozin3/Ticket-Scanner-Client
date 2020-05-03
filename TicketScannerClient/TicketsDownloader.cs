using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketDataHandler;
using TicketDataHandler.Models;
using TicketDataHandler.Responses;

namespace TicketScannerClient
{
    public class TicketsDownloader
    {
        public static async Task<TicketsResponse<List<Ticket>>> DownloadTickets(TicketHandler ticketHandler, string type)
        {
            if (ticketHandler != null)
            {
                TicketsResponse<List<Ticket>> response = await ticketHandler.GetTickets(type);
                if(response == null)
                {
                    MessageBox.Show("Response body null, please check your internet connection.");
                    return null;
                }

                if (response.Error)
                {
                    MessageBox.Show($"Error while downloading {type} tickets: " + response.Message);
                    return null;
                }
                else
                {
                    if (type.Equals("active"))
                    {
                        Console.WriteLine("Active tickets: " + response.Ticket.Count);
                    }
                    else if (type.Equals("inactive"))
                    {
                        Console.WriteLine("InActive tickets: " + response.Ticket.Count);
                    }

                    if (response.Ticket == null) {
                        response.Ticket = new List<Ticket>();
                    }
                    return response;
                }
            }
            else
            {
                MessageBox.Show($"Cant download {type} tickets. Ticket handler is not initialized.");
                return null;
            }
        }
    }
}
