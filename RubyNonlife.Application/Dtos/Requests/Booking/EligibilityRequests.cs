using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.Booking
{
    public record EligibilityRequests
    {
        public List<ReceiptDetail> AmountLeftOnReceipt { get; set; }
        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyEndDate { get; set; }
        public decimal Premium {  get; set; }
        public string Sequence { get; set; }
    }

   

    public record ReceiptDetail
    {
        public decimal Amount { get; set; }
        public string ReceiptReference { get; set; }
    }
}
