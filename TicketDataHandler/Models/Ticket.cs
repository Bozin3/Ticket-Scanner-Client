using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDataHandler.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string ActivatedAt { get; set; }
        public bool IsActivated { get; set; }
        public int EventId { get; set; }
    }
}
