using System;
using System.Collections.Generic;
using TicketDataHandler.Models;

namespace TicketDataHandler.Responses
{
    public class TicketsResponse<T>
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public T Ticket { get; set; }
    }
}
