using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public record ProductPenaltyResponse
    {
        public List<PenaltyResponse> PenaltyResponse {get;set;}
    }

    public record PenaltyResponse
    {
        public int Id { get; init;}
        public decimal LowerLimit { get; init; }
        public decimal UpperLimit { get; init; }
        public int Penalty { get; init; }
    }


    public record ProductFinancesResponse
    {
       
        public List<IncomeResponse> IncomeLedgers { get;init;}
        public List<ExpenseLedgerResponse> ExpenseLedgers { get; init; }
        public List<ReceivableLedgerResponse> ReceivableLedgers { get; init; }
    }
    public record IncomeResponse()
    {
        public int Id { get; init; }
        public string AccountNumber { get; init; }
        public string Description { get; init; }
    }

    public record ExpenseLedgerResponse
    {
        public int Id { get; init; }
        public string AccountNumber { get; init; }
        public string Description { get; init; }

    }

    public record ReceivableLedgerResponse
    {
        public int Id { get; init; }
        public string AccountNumber { get; init; }
        public string Description { get; init; }
    }
}
