namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record BankAccountResponse
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
    }
}
