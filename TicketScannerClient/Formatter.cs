using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketScannerClient
{
    public static class Formatter
    {
        public static string FormatDate(this string stringDate, string template)
        {
            return DateTime.Parse(stringDate).ToString(template);
        }
    }
}
