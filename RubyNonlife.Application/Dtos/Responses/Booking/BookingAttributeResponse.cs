namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record BookingAttributeResponse
    {
        public Guid? EntityId { get; set; } // For fleets
        public List<QuoteAttributeResponse> QuoteAttributes { get; set; }
    }



    public record BookingQuoteAttributesResponse
    {
        public Guid? EntityId { get; set; } 
        public List<BookingQuoteAttributeResponse> Attributes { get; set; } 
    }

    public record BookingQuoteAttributeResponse
    {
        public int AttributeId { get; set; } 
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; } 
    }
   

}
