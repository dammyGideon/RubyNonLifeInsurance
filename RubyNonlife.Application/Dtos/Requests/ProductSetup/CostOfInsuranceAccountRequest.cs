using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public class CostOfInsuranceAccountRequest
    {
        public int ProductId { get; init; }
        public string CreditAccount { get; init; }
        public string CreditAccountName { get; init; }
        public string DebitAccount { get; init; }
        public string DebitAccountName { get; init; }
    }
}
 public class CostOfInsuranceAccount{

    public string CreditAccount { get; init; }
    public string CreditAccountName { get; init; }
    public string DebitAccount { get; init; }
    public string DebitAccountName { get; init; }
}
