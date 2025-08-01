namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public class ProductDurationRateResponseDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public int DurationInDays { get; set; }
        public decimal Rate { get; set; }
        public string AppliedFor { get; set; }
        
    }


    public class ProductDurationDetailResponseDto
    {
        public int DurationInDays { get; set; }
        public decimal Rate { get; set; }
        public string AppliedFor { get; set; }
    }


}
