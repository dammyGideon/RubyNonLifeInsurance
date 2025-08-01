namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record CustomerBookingResponse
    {
        public CustomerInformationResponse CustomerInformationResponses { get; set; }
        public List<BankAccountResponse> BankAccountResponses { get; set; }
    }


    public class PaginatedCustomerResponse
    {
        public List<CustomerBookingResponse> Customers { get; set; }
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }


}
