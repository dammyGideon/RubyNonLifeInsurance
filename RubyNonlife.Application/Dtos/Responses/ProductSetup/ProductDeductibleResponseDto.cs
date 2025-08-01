namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public class ProductDeductibleResponseDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string InsuredSubject { get; set; }
        public decimal DeductibleRate { get; set; }
        public string ApplicationType { get; set; }
        public decimal FixedAmount { get; set; }
    }



}
