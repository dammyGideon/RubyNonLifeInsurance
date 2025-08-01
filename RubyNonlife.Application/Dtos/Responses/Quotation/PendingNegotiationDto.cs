namespace RubyNonlife.Application.Dtos.Responses.Quotation
{
    public record PendingNegotiationDto
    {

        public int Id { get; set; }
        public int QuoteId { get; set; }
        public string QuoteCodeId { get; set; }
        public string RequestedBy { get; set; }
        public DateTime RequestedAt { get; set; }
        public string Status { get; set; }
        public string NegotiationTerms { get; set; } 
        public string Comments { get; set; }
    }
}
