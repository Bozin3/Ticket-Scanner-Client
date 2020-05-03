using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketDataHandler.Models;

namespace TicketDataHandler.Responses
{
    public class AuthResponse
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public Client Client { get; set; }
        public string Token { get; set; }
    }
}
