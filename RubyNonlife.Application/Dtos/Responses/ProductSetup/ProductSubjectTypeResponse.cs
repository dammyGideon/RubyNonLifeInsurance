namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public record ProductSubjectTypeResponse
    {
       
        public int SubjectTypeId {  get; init; }
        public List<ProductSubjectTypeAttributeResponse> Attributes { get; init; }
    }



    public class ProductCategorySubjectDataResponse
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public List<ProductCategorySelectionData> ProductCategorySelections { get; set; }
        public List<ProductSubjectTypeData> ProductSubjectTypes { get; set; }
    }

    public class ProductCategorySelectionData
    {
        public bool IsGeneric { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
    }

    public class ProductSubjectTypeData
    {
        public int SubjectTypeId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public List<ProductSubjectTypeAttributeData> ProductSubjectTypeAttributes { get; set; }
    }

    public class ProductSubjectTypeAttributeData
    {
        public string Name { get; set; }
        public bool IsSumInsured { get; set; }
        public string FieldType { get; set; }
        public bool IsRequired { get; set; }
        public int? DataLength { get; set; }
        public int? DataTypeId { get; set; }
        public string SpecifyOperator { get; set; }
        public string ComparativeValueType { get; set; }
        public string ComparativeValue { get; set; }
        public bool RequiresUnderwriting { get; set; }
        public bool AvailableAtQuotation { get; set; }
        public bool GenericStateLgaStreet { get; set; }
        public List<DropdownValueData> DropdownValues { get; set; }
    }

    public class DropdownValueData
    {
        public string Value { get; set; }
    }


}
