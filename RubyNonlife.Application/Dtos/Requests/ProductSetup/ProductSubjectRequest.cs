namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record ProductSubjectRequest : ProductSubjectAttributeRequest
    {
        public int SubjectTypeId { get; init; }
    }

}
