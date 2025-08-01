using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record ProductPenaltyRequest
    {
        public int ProductId { get; set; }
       public List<PenaltyRequest> PenaltyRequests { get; init; }
    }

    public record PenaltyRequest {
        public decimal LowerLimit { get; init; }
        public decimal UpperLimit { get; init; }
        public int Penalty { get; init; }

    }

}
