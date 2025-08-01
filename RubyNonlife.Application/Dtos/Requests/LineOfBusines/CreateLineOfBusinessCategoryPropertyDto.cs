namespace RubyNonlife.Application.Dtos.Requests.LineOfBusines
{
    public class CreateLineOfBusinessCategoryPropertyDto
    {
        public string Type { get; set; }
        public bool IsMultiSelect { get; set; }
        public int? AttributeItemId { get; set; }
    }
}
