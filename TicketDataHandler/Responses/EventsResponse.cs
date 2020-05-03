using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketDataHandler.Models;

namespace TicketDataHandler.Responses
{
    public class EventsResponse
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public List<Event> Events { get; set; }
    }
}
