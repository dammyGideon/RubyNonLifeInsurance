namespace RubyNonlife.Application.Dtos.Responses.LineOfBuisnessGenericResponse
{
    public record PaginatedLineOfBusinessAttributeCategoryResponse
    {
        public int PageNumber { get; init; }
        public int PageSize { get; init; }
        public int TotalCount { get; init; }
        public int TotalPages { get; init; }
        public bool HasPreviousPage { get; init; }
        public bool HasNextPage { get; init; }

        public List<LineOfBusinessAttributeCategoryResponseDto> AttributeCategoryResponse { get; init; }

    }
}
