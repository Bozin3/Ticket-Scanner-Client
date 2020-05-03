
using TicketDataHandler.Models;
using TicketDataHandler.Responses;

namespace TicketScannerClient
{
    public static class Core
    {
        public static Event Event { get; set; }
        public static AuthResponse Auth{ get; set; }
    }
}
