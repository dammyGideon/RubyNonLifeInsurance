using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record ProductTeamRequest
    {
        public string ProductName { get; init; }
        public int VariantId { get; init; }
        public bool RequiresUnderWriter { get; init; }
        public bool RequiresGenericLocation { get; init; }
        public bool RequireUnderWritingAtBooking { get; init; }
        public List<int> SubjectTypeIds { get; init; }
        public List<BaseSubjectTypeCoverRequest> BaseSubjectTypeCovers { get; init; }
        public List<AdditionalSubjectTypeCoverRequest> AdditionalSubjectTypeCoverRequest { get; init; }
        public List<ProductCostTypeRequest> CostTypes { get; init; }
        public List<PaymentFrequencyRequest> paymentFrequencies {get; init; }
        public List<ProductCostOfInsuranceRequest> CostsOfInsurance { get; init; }
        public List<int> GenericRequest { get; init; }

        public List<ProductSubjectCategoryRequest> ProductSubjectAttributeRequests { get; init; }
        public List<ProductFeeSetupRequest> ProductFeeSetupRequests { get; init; }
       
        //public List<ProductSubjectAttributeDropdownMappingRequest> DropdownMappingRequests { get; init; }
    }

      

    public record ProductSetupBasicInformationRequest
    {
        public string ProductName { get; init; }
        public int VariantId { get; init; }
        public bool RequiresUnderWriter { get; init; }
        public string Description { get; init; }
        public List<BasicBaseSubjectTypeCoverRequest> BaseSubjectTypeCovers { get; init; }
        public List<BasicAdditionalSubjectTypeCoverRequest> AdditionalSubjectTypeCoverRequest { get; init; }
        public List<PaymentFrequencyRequest> paymentFrequencies { get; init; }
    }


  





    public record ProductSetupCostConfigurationRequest
    {
        public int ProductId {  get; init; }
        public List<ProductSetupCostConfigureForBaseCover> ProductSetupCostConfigureForBaseCovers { get; init; }
        public List<ProductSetupCostConfigureForAdditionalCover> ProductSetupCostConfigureForAdditionalCovers { get; init; }
        public List<ProductCostTypeRequest> CostTypes { get; init; }
        public List<ProductCostOfInsuranceRequest> CostsOfInsurance { get; init; }
    }
    public record ProductSubjectConfigurationRequest
    {
        public int ProductId { get; init; }
        public List<ProductSubjectCategoryRequest> ProductSubjectAttributeRequests { get; init; }
    }
    public record ProductSetupDocumentConfigurationRequest
    {
        public int ProductId { get; init; }
        public List<ProductDocumentRequest> PolicyDocuments { get; init; }
    }
    public record ProductSetupFeeSetupConfigurationRequest
    {
        public int ProductId { get; init; }
        public List<ProductFeeSetupRequest> ProductFeeSetupRequests { get; init; }
    }



    public record ProductSetupCostConfigureForBaseCover {
    
        public int BaseCoverId { get; init; }
        public decimal RateApplied { get;init; }
        public string Status { get; init; }
        public decimal MaximumAmount { get; init; }
        public bool UseRateTable { get; init; }
        public string DisplayFormula {  get; init; }

    }

    public record ProductSetupCostConfigureForAdditionalCover {
        public int AdditionalCoverId { get; init; }
        public string Status { get; init; }
        public decimal MaximumAmount { get; init; }
        public bool UseRateTable { get; init; }
        public decimal RateApplied { get; init; }
        public string DisplayFormula { get; init; }
    }

    public record ProductFeeSetupRequest
    {
        public string Name { get; init; }
        public decimal Value { get; init; }
        public string Description { get; init; }
    }


    public class ProductSetupBasicInformationUpdateRequest
    {
        public int ProductId { get; set; } // Required for updating an existing product
        public string ProductName { get; set; }
        public int VariantId { get; set; }
        public bool RequiresUnderWriter { get; set; }
        public List<BaseSubjectTypeCoverUpdateRequest> BaseSubjectTypeCovers { get; set; } = new();
        public List<AdditionalSubjectTypeCoverUpdateRequest> AdditionalSubjectTypeCoverRequest { get; set; } = new();
        public List<PaymentFrequencyUpdateRequest> PaymentFrequencies { get; set; } = new();
    }
    public class BaseSubjectTypeCoverUpdateRequest
    {
        public int Id { get; set; }  
        public int CoverId { get; set; }
        public string LimitType { get; set; }
    }
    public class AdditionalSubjectTypeCoverUpdateRequest
    {
        public int Id { get; set; }  
        public int CoverId { get; set; }
        public string LimitType { get; set; }
    }
    public class PaymentFrequencyUpdateRequest
    {
        public int Id { get; set; }  
        public string PaymentIntervals { get; set; }
    }


    public class ProductSetupCostConfigurationUpdateRequest
    {
        public int ProductId { get; set; }
        public List<ProductCostTypeUpdateRequest> CostTypes { get; set; } = new();
        public List<BasicBaseSubjectTypeCoverUpdateRequest> basicBaseSubjectTypeCoverUpdateRequests { get; set; } = new();
        public List<ProductCostOfInsuranceUpdateRequest> CostsOfInsurance { get; set; } = new();
    }

    public class ProductCostTypeUpdateRequest
    {
        public int Id { get; set; }  // ID required for update
        public int CostTypeId { get; set; }
        public string Remark { get; set; }
    }

    public class ProductCostOfInsuranceUpdateRequest
    {
        public int Id { get; set; }  // ID required for update
        public int CostType { get; set; }
        public string CostBearer { get; set; }
        public int SourceId { get; set; }
        public int Year { get; set; }
        public decimal Rate { get; set; }
        public decimal? Value { get; set; }
        public string DisplayFormula { get; set; }
    }


}
