namespace RubyNonlife.Application.Dtos.Responses.ReinsuranceResponse
{
    public record TreatyCapacityCalculationResponseDto
    {
        public decimal TreatyCapacity { get; set; }
        public decimal UnderWriterCapacity { get; set; }
    }
}
