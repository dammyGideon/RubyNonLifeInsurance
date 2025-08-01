using RubyNonlife.Application.Dtos.Requests.ProductSetup;

namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{

    public record ProductDetailResponse
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductClassId { get; set; }
        public int? VariantId { get; set; }
        public string Code { get; set; }
        public bool RequiresGenericLocation { get; set; }
        public string Alias { get; set; }
        public string ApprovalStatus { get; set; }
        public bool RequiresUnderwriter { get; set; }
        public bool RequiresUnderWriterAtBooking { get; set; }
        public string ProductSetupStage { get; set; }
        public List<PaymentFrequencyResponse> PaymentFrequencies { get; set; }
        public List<SubjectResponse> SubjectTypeIds { get; set; }
        public List<ProductBaseSubjectTypeCoverResponse> BaseSubjectTypeCovers { get; set; }
        public List<ProductAdditionalSubjectTypeCoverResponse> AdditionalSubjectTypeCovers { get; set; }
        public List<CostTypeResponse> CostTypes { get; set; }
        public List<CostOfInsuranceResponse> CostOfInsurances { get; set; }
        public List<ProductFeeSetupResponse> ProductFeeSetupResponses { get; set; }
        public List<ProductDocumentResponse> Documents { get; set; }
        public List<PenaltyResponse> Penalty { get; set; }
        public ProductFinancesResponse ProductFinances { get; set; }
        public List<ProductGenericAttributeResponse> ProductGenericAttributeResponses {  get; set; }
        public List<ProductSubjectCategoryResponse> ProductSubjectCategories { get; set; }
        public List<ProductSubjectAttributeDropdownMappingResponse> DropdownMappings { get; set; }
      
    }

    public record ProductGenericAttributeResponse
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
      
    }

    public record SubjectResponse
    {
        public int Id { get; set; }
        public int SubjectTypeId { get; set; }
    }

    public record ProductSubjectTypeResponseDetails
    {
        public int SubjectTypeId { get; set; }
        public List<ProductSubjectResponse> ProductSubjectAttributes { get; set; }
    }
    public class ProductSubjectCategoryResponse
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ProductObjectOfInsurance> ProductObjectOfInsurances { get; set; }
        public List<ProductSubjectResponse> ProductSubjectAttributes { get; set; }
    }

    public class ProductObjectOfInsurance
    {
        public int SubjectTypeId { get; set; }
        public string SubjectTypeName { get; set; }
    }
    public class ProductSubjectResponse
    {
        public int Id { get; set; }
        public string SubjectAttributeName { get; set; }
        public string FieldType { get; set; }
        public bool IsCompulsory { get; set; }
        public bool IsSumAssured { get; set; }
        public int DataTypeId { get; set; }
        public int DataLength { get; set; }
        public string SpecifyOperator { get; set; }
        public string ComparativeValueType { get; set; }
        public string ComparativeValue { get; set; }
        public bool RequiresUnderwriting { get; set; }
        public List<DropdownValuesResponse> DropdownValues { get; set; }
        public int ProductSubjectTypeId { get; set; }
        public bool RequiredAtQuoting { get; set; }
        public bool HasParentChildOptions { get; set; }
        public bool GenericStateLgaStreet { get; set; }

    }
    public class ProductSubjectTypeAttributeResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FieldType { get; set; }
        public bool IsRequired { get; set; }
        public bool IsSumInsured { get; set; }
        public int DataTypeId { get; set; }
        public int? DataLength { get; set; }
        public string SpecifyOperator { get; set; }
        public string ComparativeValueType { get; set; }
        public string ComparativeValue { get; set; }
        public bool RequiresUnderwriting { get; set; }
        public List<DropdownValuesResponse> DropdownValues { get; set; }
        public int ProductSubjectTypeId { get; set; }
        public bool HasParentChildOptions { get; set; }
        public bool RequiredAtQuoting { get; set; }
        public List<QuoteParentChildOptionResponse> DropdownMapping { get; set; }
    }

    public class SubjectTypeResponse
    {
        public int Id { get; set; }
        public int SubjectTypeId { get; set; }

        public string CategoryName { get; set; }
        public List<ProductSubjectTypeAttributeResponse> Attributes { get; set; }

    }

    public class DropdownValuesResponse
    {
        public string Value { get; set; }
    }


    public class ParentChildOptionResponse
    {
        public int ParentAttributeId { get; set; }
        public string ParentAttributeName { get; set; }
        public string ParentValue { get; set; }
        public List<ChildOptionResponse> ChildOptions { get; set; }
    }


    public class ChildOptionResponse
    {
        public int ChildAttributeId { get; set; }
        public string ChildAttributeName { get; set; }
        public List<string> ChildValues { get; set; }
    }




    public class QuoteParentChildOptionResponse
    {
        public string ParentAttributeName { get; set; }
        public string ParentValue { get; set; }
        public List<QuoteChildOptionResponse> ChildOptions { get; set; }
    }

    // Define a class for child options
    public class QuoteChildOptionResponse
    {
        public string ChildAttributeName { get; set; }
        public List<string> ChildValues { get; set; }
    }
    public record PaymentFrequencyResponse
    {
        public int PaymentFrequencyId { get; init; }
        public string PaymentFrequency { get; init; }
    }


    public class CostTypeResponse
    {
        public int Id { get; init; }
        public string CostTypeName { get; init; }
        public int CostType { get; set; }
        public string Remark { get; set; }
    }


    public class ProductAdditionalSubjectTypeCoverResponse
    {
        public int Id { get; init; }

        public string CoverName { get; set; }
        public string CoverStatus { get; set; }
        public int AdditionalCoverId { get; set; }
        public string LimitType { get; set; }
        public bool RateTable { get; set; }
        public decimal MaximumAmount { get; set; }
        public decimal RateApplied { get; set; }
        public string DisplayFormula { get; set; }

        public bool isFixed { get; set; }
        public decimal? FixedPremium { get; set; }
    }


    public class ProductBaseSubjectTypeCoverResponse
    {
        public int Id { get; set; }
        public string CoverName { get; set; }
        public string CoverStatus { get; set; }
        public int BaseCoverId { get; set; }
        public string LimitType { get; set; }
        public bool RateTable { get; set; }
        public decimal MaximumAmount { get; set; }
        public decimal RateApplied { get; set; }
        public string DisplayFormula { get; set; }
        public bool isFixed { get; set; }
        public decimal? FixedPremium { get; set; }
    }

    public class CostOfInsuranceResponse
    {
        public int Id { get; set; }
        public string CostypeName { get; set; }
        public int CostTypeId { get; set; }
        public int? Year { get; set; }
        public decimal? TermValue { get; set; }
        public string? Rate { get; set; }
        public string CostBearer { get; set; }
        public string CollectionSourceName { get; set; }
        public int CollectionSourceId { get; set; }
        public string DisplayFormula { get; set; }
        public string? CreditAccount { get; set; }
        public string? DebitAccount { get; set; }
    }

    public class ProductFeeSetupResponse
    {
        public int Id { get; set; }
        public string name { get; set; }
        public decimal value { get; set; }
        public string description { get; set; }


    }



}
