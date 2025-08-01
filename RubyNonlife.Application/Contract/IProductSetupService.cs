
using RubyNonlife.Application.Dtos.Requests;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using RubyNonlife.Application.Helper;
using RubyNonlife.Domain.Models.ProductEntities;


namespace RubyNonlife.Infrastructure.Contract
{
    public interface IProductSetupService
    {
        Task<BaseResponse<ProductResponse>> SetupProductTeam(ProductTeamRequest request);
        Task<BaseResponse<PaginatedProductResponse>> GetAllProduct(int pageNumber = 1, int pageSize = 10);
        Task<BaseResponse<PaginatedProductResponse>> GetAllProductByBusinessline(int businessId, int pageNumber = 1, int pageSize = 10);
        Task<BaseResponse<ProductDetailResponse>> GetSingleProduct(int productId);
        Task<BaseResponse<ProductPenaltyResponse>> ProductSetupPenalty(ProductPenaltyRequest request);
        Task<BaseResponse<ProductCodeResponse>> GenerateProductCode(CreateProductRequest request);
        Task<BaseResponse<ProductStagingResponse>> SaveOrUpdateDraft(ProductSetupDraftRequest request);
        Task<BaseResponse<ProductStagingResponse>> GetDraftByProductName(string productName);
        Task<BaseResponse<ProductPenaltyResponse>> UpdateSetupPenalty(int penaltyId, PenaltyRequest request);
        Task<BaseResponse<ProductPenaltyResponse>> DeleteSetupPenalty(int penaltyId);
        Task<BaseResponse<List<ProductSubjectAttributeDropdownMapping>>> CreateProductSubjectAttributeMapping(List<ProductSubjectAttributeDropdownMappingRequest> dropdownMappingRequests);
        Task<BaseResponse<GenericNameResponse>> AddProductFinancialRecords(FinanceRequest request);
        Task<BaseResponse<ProductFinancesResponse>> GetProductFinancialRecords(int productId);
        Task<BaseResponse<GenericNameResponse>> UpdateProductFinancialRecord(int productId, int ledgerId, string ledgerType, UpdateLedgerRequest request);
        Task<BaseResponse<List<ProductCostOfInsuranceResponse>>> GetProductCostOfInsurance(int productId);
        Task<BaseResponse<GenericNameResponse>> CreateAccountForCostOfInsurance(CostOfInsuranceAccountRequest requests);

        Task<BaseResponse<List<AccountSearchResponse>>> GetAccounts();
        Task<BaseResponse<List<AccountResponse>>> ProductIncomeAccount(string searchKeyword = null);
        Task<BaseResponse<List<AccountResponse>>> CoinsuranceManagementFees(string searchKeyword = null);
        Task<BaseResponse<List<AccountResponse>>> ReinsuranceCommissions(string searchKeyword = null);
        Task<BaseResponse<List<AccountResponse>>> CoinsurancePremiumOutward(string searchKeyword = null);
        Task<BaseResponse<List<AccountResponse>>> ReinsurancePremiumExpense(string searchKeyword = null);
        Task<BaseResponse<List<AccountResponse>>> BrokerCommissionsExpense(string searchKeyword = null);
        Task<BaseResponse<List<AccountResponse>>> CoinsuranceReceivableLedger(string searchKeyword = null);
        Task<BaseResponse<List<AccountResponse>>> VATExpenseLedger(string searchKeyword = null);
        Task<BaseResponse<List<AccountResponse>>> WHTPayableLedger(string searchKeyword = null);
        Task<BaseResponse<GenericNameResponse>> CreateLocationSetup(LocationSetupRequest request);
        Task<BaseResponse<List<LocationFieldResponses>>> GetAllLocations(int productId);
        Task<BaseResponse<string>> UpdateLocationSetup(UpdateLocationRequest request);
        Task<BaseResponse<List<string>>> GetAllDataType();
        Task<BaseResponse<string>> DeleteLocationSetup(DeleteLocationRequest request);


        Task<BaseResponse<GenericNameResponse>> CreateOrUpdateProductSetupBasicInformation(ProductSetupBasicInformationRequest request);
        Task<BaseResponse<GenericNameResponse>> CreateOrUpdateProductSetupCostConfigurations(ProductSetupCostConfigurationRequest request);
        Task<BaseResponse<GenericNameResponse>> CreateOrUpdateProductSetupSubjectConfiguration(ProductSubjectConfigurationRequest request);
        Task<BaseResponse<GenericNameResponse>> CreateOrUpdateProductSetupDocument(ProductSetupDocumentConfigurationRequest request);
        Task<BaseResponse<GenericNameResponse>> CreateOrUpdateProductFeeSetup(ProductSetupFeeSetupConfigurationRequest request);

        Task<BaseResponse<List<ProductSubjectAttributeDropdownMappingResponse>>> GetProductSubjectAttributeMappings(int productId);
        Task<BaseResponse<GenericNameResponse>> ProductPricingAttributeConfiguration(List<CreateProductPricingConfigurationDto> request);
        Task<BaseResponse<List<ProductPricingConfigurationResponse>>> GetProductPricingConfigurations(int categoryId);
        Task<BaseResponse<List<GenericNameResponse>>> GetPriceConfigurationAllApprovingOffice();
        Task<BaseResponse<GenericNameResponse>> BulkUpdateProductPricingConfigurations(List<BulkUpdateProductPricingConfigurationDto> requests);
        Task<BaseResponse<GenericNameResponse>> SetApprovalForPriceConfiguration(List<PriceConfigurationApprovingOfficeInfo> request);
        Task<BaseResponse<GenericNameResponse>> UpdateApprovalForPriceConfiguration(UpdatePriceConfigurationApprovingOfficeInfo request);
        Task<BaseResponse<GenericNameResponse>> DeleteApprovalForPriceConfiguration(int priceConfigurationId);

        Task<BaseResponse<List<OfficePricingConfigurationResponse>>> GetAllApprovalForPriceConfigurations(int priceConfigurationId);
        Task<BaseResponse<ProductResponse>> ApproveProduct(int productId);
        Task<BaseResponse<object>> RejectProduct(ProductRejectionRequest request);


       
        Task<BaseResponse<GenericNameResponse>> CreateProductCategorySubjectDataAsync(ProductCategorySubjectSetupDto request);
        Task<BaseResponse<GenericNameResponse>> UpdateProductSubjectDataAsync(int categoryId, ProductSubjectCategoryRequest updatedCategory);
        Task<BaseResponse<GenericNameResponse>> DeleteProductSubjectDataAsync(int categoryId);

        // Create Methods
        Task<BaseResponse<GenericNameResponse>> CreateThreshold(ThresholdRequestdto request);
        Task<BaseResponse<GenericNameResponse>> CreateProductDeductible(ProductDeductibleDto request);
        Task<BaseResponse<GenericNameResponse>> CreateProductDurationRate(ProductDurationRatedto request);

        // Read Methods
        Task<BaseResponse<List<ThresholdResponseDto>>> GetAllProductThresholds(int productId);
        Task<BaseResponse<ThresholdResponseDto>> GetProductThresholdById(int id);
        Task<BaseResponse<List<ProductDeductibleResponseDto>>> GetAllProductDeductibles(int productId);
        Task<BaseResponse<ProductDeductibleResponseDto>> GetProductDeductibleById(int deductibleId);
        Task<BaseResponse<List<ProductDurationRateResponseDto>>> GetAllProductDurationRates(int productId);
        Task<BaseResponse<ProductDurationRateResponseDto>> GetProductDurationRateById(int rateId);

        // Update Methods
        Task<BaseResponse<GenericNameResponse>> UpdateProductThreshold(int id, ThresholdRequestdto request);
        Task<BaseResponse<GenericNameResponse>> UpdateProductDeductible(int id, ProductDeductibleRequestDto request);
        Task<BaseResponse<GenericNameResponse>> UpdateProductDurationRate(int id, ProductDurationRatedUpdateRequest request);

      
        //Delete Methods 
        Task<BaseResponse<GenericNameResponse>> DeleteProductDurationRate(int rateId);
        Task<BaseResponse<GenericNameResponse>> DeleteThreshold(int thresholdId);
        Task<BaseResponse<GenericNameResponse>> DeleteProductDeductible(int deductibleId);

        Task<BaseResponse<List<ProductCategorySubjectDataResponse>>> GetProductSubjectDataAsync(int productId);

        Task<BaseResponse<GenericNameResponse>> CreateWorkflowApproval(int productId, string productName);
    }

}
