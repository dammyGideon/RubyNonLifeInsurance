namespace RubyNonlife.Application.Dtos.Requests.Quotation
{
    public record QuoteNegotiationRequest
    {
        public  int quotationId { get; init; }
        public decimal requestedDiscount { get; init; }
        public string remarks { get; init; }
    }


    public record UnderwriterReplyRequest
    {
        public int QuoteId { get; init; }
        public decimal responseDiscount { get; init; }
        public string Status { get; init; }
    }
}
