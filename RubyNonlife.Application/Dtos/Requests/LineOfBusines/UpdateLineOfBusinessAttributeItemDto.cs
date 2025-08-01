
public class UpdateLineOfBusinessAttributeItemDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FieldType { get; set; }
    public bool IsSumAssured { get; set; }
    public bool RequiredAtQuoting { get; set; }
    public bool ViolationSpecification { get; set; }
    public int CategoryId { get; set; }
    public List<BusinessAttributeDropdownValueDto> BusinessAttributeDropdownValues { get; set; }
}
