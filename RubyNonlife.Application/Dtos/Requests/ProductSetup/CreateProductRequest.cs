namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record CreateProductRequest
    {
        public int ProductClassId {  get; set; }
        public string ProductName { get; init; }
        public string Description { get; init; }
        public string Alias { get; init; }
    };

}
