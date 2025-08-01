using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.Reinsurance
{
    public record ReinsuranceAgreementRequestDto
    {
       public int BusinessYear { get; set; }
       public string TransactionType { get; set; }
       public string AgreementCaption { get; set; }
       public string AgreementDescription { get; set;}
       public bool ExpiryDate { get; set; }
       public DateTime? ExpiresDate { get; set; }
    }
}
