namespace RubyNonlife.Application.Dtos.Responses.Quotation
{
    public record QuotationBaseCoverResponse
    {
        public int Id { get; init; }
        public int ProductBaseSubjectTypeCoverId { get; init; }
        public string CoverName { get; init; }
        public string Status  { get; init; }
        public decimal Price { get; init; }
        public decimal MaximumAmount { get; init; }
        public decimal RateApplied { get; init; }
        public decimal TotalAmount { get; init; }
        public bool Indicator { get; init; }
        public string Comment { get; init; }

    }
}
