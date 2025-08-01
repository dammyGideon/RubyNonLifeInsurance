namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record ProductSubjectAttributeRequest
    {
        public string SubjectAttributeName { get; init; }
        public string FieldType { get; init; }
        public List<DropdownValueDto> DropdownValues { get; init; }
        public bool IsCompulsory { get; init; }
        public bool IsSumAssured { get; init; }
        public int DataTypeId { get; init; }
        public int? DataLength { get; init; }
        public string? SpecifyOperator { get; init; }
        public string? ComparativeValueType { get; init; }
        public string? ComparativeValue { get; init; }
        public bool RequiresUnderwriting { get; init; }
        public bool HasParentChildOptions { get; init; }
        public bool RequiredAtQuoting {  get; init; }
        public bool GenericStateLgaStreet {  get; init; }

        public int SubjectTypeId { get; init; }
    }

    public record DropdownValueDto
    {
        public string Value { get; init; }
    }

    public record ProductSubjectTypeAttributeOptionDto
    {
        public string OptionName { get; init; } // Option name (e.g., "Toyota")
        public int? ParentOptionId { get; init; } // Nullable for root options
        public bool IsSpecialAttribute { get; init; } = false; // Flag to indicate special attributes
    }

}
