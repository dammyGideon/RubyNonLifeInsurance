using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public class OVDetailDto
    {
        public string EntryType { get; set; } // "Dr" or "Cr"
        public string AccountName { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public string VoucherId { get; set; } // Can be null initially
        public string VoucherType { get; set; }
    }
}
