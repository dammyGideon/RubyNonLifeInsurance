namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public record ProductDocumentResponse
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Size { get; init; }
        public string Format { get; init; }
        public bool IsRequired { get; init; }
    }

    public record ProductCategoryDocumentResponse
    {
        public int Id { get; init; }
        public string Category { get; set; }
        public string SubCategory {  get; set; }
        public List<ProductDocumentResponse> ProductDocuments { get; set; }
    }

    public record ProductCategoryDocumentResponseRequest
    {   
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int ProductId { get; init; }
        public List<ProductDocumentResponse> ProductDocuments { get; set; }
    }



}
