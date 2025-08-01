using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record BaseSubjectTypeCoverRequest
    {
        public int CoverId { get; set; }
        public string Status { get; init; }
        public bool UseRateTable { get; init; }
        public decimal CoverLimits { get; init; }
        public decimal MaximumAmount { get; init; }
        public decimal RateApplied { get; init;}
        public string LimitType { get; init; }
        public string DisplayFormula { get; init; }
        public decimal FixedPremium { get; init; }
        public bool isFixed { get; init; }
    }

    public record BasicBaseSubjectTypeCoverRequest
    {
        public int CoverId { get; init; }
        public string LimitType { get; init; }

    }

    public record BasicBaseSubjectTypeCoverUpdateRequest
    {
        public int Id { get; init; }
        public int BaseCover {  get; init; }
        public string Status { get; init; }
        public bool UseRateTable { get; init; }
        public decimal CoverLimits { get; init; }
        public decimal MaximumAmount { get; init; }
        public decimal RateApplied { get; init; }
        public string DisplayFormula { get; init; }
        public decimal FixedPremium { get; init; }


    }
}
