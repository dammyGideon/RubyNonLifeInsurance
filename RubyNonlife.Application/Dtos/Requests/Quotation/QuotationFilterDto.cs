using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.Quotation
{
    public class QuotationFilterDto
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? BusinessType { get; set; }
        public string? CreatedBy { get; set; } 
        public DateTime? CreateDateFrom { get; set; } 
        public DateTime? CreateDateTo { get; set; } 
        public string? ProductClass { get; set; }
        public string? QuoteStatus { get; set; }
        public string? ProductName { get; set; }
    }

}
