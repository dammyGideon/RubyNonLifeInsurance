namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record BookingQuoteResponse
    {
        public int QuotationId { get; set; }
        public int ProductId { get; set; }
        public string QuoteId { get; set; }
        public string Customer { get; set; }
        public string CustomerNumber { get; set; }
        public bool RequiresGenericLocation { get; set; }
        public string Subject { get; set; }
        public string QuotePreference { get; set; }
        public List<BookingQuoteAttributesResponse> BookingAttributeResponse { get; set; }
        public List<LocationFieldResponses> LocationFieldResponses { get; set; }
    }
}
