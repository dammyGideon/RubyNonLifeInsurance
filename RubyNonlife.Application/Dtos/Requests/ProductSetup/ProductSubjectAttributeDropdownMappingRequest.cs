namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record ProductSubjectAttributeDropdownMappingRequest
    { 
        public int ParentAttributeId { get; init; } 
        public string ParentValue { get; init; }
        public int ChildAttributeId { get; init; }
        public List<string> ChildValues { get; init; }
    }
}
