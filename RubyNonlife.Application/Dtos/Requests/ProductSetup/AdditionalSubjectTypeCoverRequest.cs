namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record AdditionalSubjectTypeCoverRequest
    {
        public int CoverId { get; set; }
        public string Status { get; init; }
        public bool UseRateTable { get; init; }
        public decimal CoverLimits { get; init; }
        public decimal MaximumAmount { get; init; }
        public decimal RateApplied { get; init; }
        public string LimitType { get; init; }
        public string DisplayFomula { get; init; }
        public bool isFixed { get; init; }
        public decimal? FixedPremium { get; init; }
    }




    public record BasicAdditionalSubjectTypeCoverRequest
    {
        public int CoverId { get; init; }
        public string LimitType { get; init; }

    }
}
