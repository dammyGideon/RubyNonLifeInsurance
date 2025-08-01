using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.ReinsuranceResponse
{
    public record ReinsuranceAgreementResponseDto
    {
        public int Id { get; set; }
        public int BusinessYear { get; set; }
        public string TransactionType { get; set; }
        public string AgreementCaption { get; set; }
        public string AgreementDescription { get; set; }
        public DateTime? ExpiresDate { get; set; }
        public bool ExpiryDate { get; set; }
        public string ReviewStatus { get; set; } = string.Empty;
        public string ApprovalStatus { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
