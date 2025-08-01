namespace RubyNonlife.Application.Dtos.Responses
{
    public record ValidateCustomerResponse
    {
        public string CustomerName { get; init; }
        public string CustomerNumber { get; init; }
        public string CustomerAddress { get; init; }
    }
}
