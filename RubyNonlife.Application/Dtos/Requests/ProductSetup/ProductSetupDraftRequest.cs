namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public class ProductSetupDraftRequest
    {
        public string ProductName { get; init; }
        public string Description {  get; init; }
        public string Alias { get; init; }
        public int ProductClassId {  get; init; }
        public int VariantId { get; init; }
        public bool RequiresUnderWriter { get; init; }
        public List<int> SubjectTypeIds { get; init; }
        public List<BaseSubjectTypeCoverRequest> BaseSubjectTypeCovers { get; init; }
        public List<AdditionalSubjectTypeCoverRequest> AdditionalSubjectTypeCoverRequest { get; init; }
        public List<ProductCostTypeRequest> CostTypes { get; init; }
        public List<PaymentFrequencyRequest> paymentFrequencies { get; init; }
        public List<ProductCostOfInsuranceRequest> CostsOfInsurance { get; init; }
        public List<ProductDocumentRequest> PolicyDocuments { get; init; }
        public List<ProductSubjectCategoryRequest> ProductSubjectAttributeRequests { get; init; }
        public List<ProductSubjectAttributeDropdownMappingRequest> DropdownMappingRequests { get; init; }
        public List<ProductFeeSetupRequest> ProductFeeSetupRequests { get; init; }

    }

}
