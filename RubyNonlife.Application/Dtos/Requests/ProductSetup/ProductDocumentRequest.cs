namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record ProductDocumentRequest
    {
        public string Name { get; init; }
        public string Format { get; init; }
        public string Size { get; init; }
        public bool IsRequired { get; init; }
    }

}
