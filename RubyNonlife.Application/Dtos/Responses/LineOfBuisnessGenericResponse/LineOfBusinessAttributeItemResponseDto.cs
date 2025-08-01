namespace RubyNonlife.Application.Dtos.Responses.LineOfBuisnessGenericResponse
{
    public class LineOfBusinessAttributeItemResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FieldType { get; init; }
        public bool IsSumAssured { get; init; }
        public bool RequiredAtQuoting { get; init; }
        public bool ViolationSpecification { get; init; }
        public int CategoryId { get; init; }
        public string CategoryName {  get; init; }
        public bool IsNew { get; init; }
        public bool IsEditable { get; init; }
        public List<BusinessAttributeDropdownValueDto> BusinessAttributeDropdownValues { get; init; }

    }

    public record PaginatedLineOfBusinessAttributeItemResponseDto
    {
        public int PageNumber { get; init; }
        public int PageSize { get; init; }
        public int TotalCount { get; init; }
        public int TotalPages { get; init; }
        public bool HasPreviousPage { get; init; }
        public bool HasNextPage { get; init; }

        public List<LineOfBusinessAttributeItemResponseDto> LineOfBusinessAttributeItemResponseDto {  get; init; }
    }

}
