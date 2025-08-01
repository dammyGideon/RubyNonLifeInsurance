namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record QuoteAttributeResponse
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
    }
}
