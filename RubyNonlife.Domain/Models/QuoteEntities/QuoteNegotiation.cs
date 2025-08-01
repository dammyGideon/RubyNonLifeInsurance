using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.QuoteEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.QuoteEntities
{
    public class QuoteNegotiation : BaseEntity
    {
        [ForeignKey(nameof(Quotation))]
        public int QuoteId { get; set; }
        public int NegotiationRound { get; set; }
        public decimal RequestedDiscount { get; set; }
        public decimal? ResponseDiscount { get; set; }
        public string NegotiationStatus { get; set; } // E.g., "Pending", "Accepted", "Rejected"
        public string InitiatedBy { get; set; } // "Customer" or "Underwriter"
        public string Remarks { get; set; }
        public string NegotiationReason { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual Quotation Quotation { get; set; }
       
    }

}

