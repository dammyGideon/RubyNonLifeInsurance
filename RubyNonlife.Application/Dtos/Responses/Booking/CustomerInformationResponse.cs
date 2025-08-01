namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record CustomerInformationResponse
    {
        public int CustomerId { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
    }
}
