using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record EligibilityResponse
    {
        public int Id { get; set; }
        public DateTime EligibilityStartDate { get; set; }
        public DateTime EligibilityEndDate { get; set; }
        public int Duration { get; set; }
        public string Sequence { get; set; }
        public string ReceiptReference { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }

    }
}
