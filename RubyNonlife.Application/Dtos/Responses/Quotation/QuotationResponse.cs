using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Quotation
{

    public record QuotationCodeResponse
    {
        public string QuotationCode { get; init; }
        public int QuoteId { get; init; }
    }
}
