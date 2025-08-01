using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Quotation
{


    public record QuotationResponses
    {
        public int Id { get; init; }
        public string QuoteId { get; init; }
        public string CreatedBy { get; init; }
        public DateTime CreateAt { get; init; }
        public double ResponseSLA {  get; init; }
        public double SLAUsage { get; set; }
        public string Customer { get; init;}
        public string BusinessType { get; init; }
        public string QuoteType { get; init; }
        public bool IsLocked { get; init; }
        public string QuoteStatus { get; init; }
        public string ProductClass { get; init; }
        public string ProductName { get; init; }
    }
}
