using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Quotation
{
    public record QuotationUpdateResponse
    {
        public int Id { get; set; }
        public string QuoteId { get; set; }
        public string Customer { get; set; }
        public decimal SumInsured { get; set; }
        public decimal Premium { get; set; }
        public string QuoteStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<CoverResponse> BaseCovers { get; set; }
        public List<CoverResponse> AdditionalCovers { get; set; }
    }

    public class CoverResponse
    {
        public int Id { get; set; }
        public int ProductBaseSubjectTypeCoverId { get; set; }
        public decimal CoverAmount { get; set; }
        public  string Status  { get; set; }
    }
}
