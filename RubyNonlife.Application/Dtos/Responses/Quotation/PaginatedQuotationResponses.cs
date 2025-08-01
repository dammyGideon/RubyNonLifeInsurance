namespace RubyNonlife.Application.Dtos.Responses.Quotation
{
    public record PaginatedQuotationResponses
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; init; }
        public int TotalPages { get; init; }
        public bool HasPreviousPage { get; init; }
        public bool HasNextPage { get; init; }

        public List<QuotationResponses> QuotationResponses { get; init; }

    }
}
