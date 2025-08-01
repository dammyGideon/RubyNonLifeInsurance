namespace RubyNonlife.Application.Dtos.Requests.LineOfBusines
{
    public class CreateLineOfBusinessAttributeItemDto
    {
        public string Name { get; set; }
        public string FieldType { get; init; }
        public bool IsSumAssured { get; init; }
        public bool RequiredAtQuoting { get; init; }
        public bool ViolationSpecification { get; init; }
        public int CategoryId { get; init; }
        public List<BusinessAttributeDropdownValueDto> BusinessAttributeDropdownValues { get; init; }

    }


}

public record BusinessAttributeDropdownValueDto
{
    public string Value { get; init; }
}
