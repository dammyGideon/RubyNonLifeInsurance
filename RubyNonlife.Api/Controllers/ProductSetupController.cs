using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using RubyNonlife.Domain.Models.ProductEntities;
using RubyNonlife.Infrastructure.Contract;
using System.Net;

namespace RubyNonlife.Api.Controllers
{

    public class ProductSetupController(IProductSetupService _productService) : BaseController
    {

        [HttpPost("create-product")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            var response = await _productService.GenerateProductCode(request);
            return StatusCode((int)response.StatusCode, response);
        }

        //[HttpPost("product-setup-basic-information")]
        //[ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        //[ProducesResponseType((int)HttpStatusCode.NotFound)]
        //public async Task<IActionResult> CreateOrUpdateProductSetupBasicInformation(ProductSetupBasicInformationRequest request)
        //{
        //    var response = await _productService.CreateOrUpdateProductSetupBasicInformation(request);
        //    return StatusCode((int)response.StatusCode, response);
        //}

        //[HttpPost("product-setup-cost-configurations")]
        //[ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        //[ProducesResponseType((int)HttpStatusCode.NotFound)]
        //public async Task<IActionResult> CreateOrUpdateProductSetupCostConfigurations(ProductSetupCostConfigurationRequest request)
        //{
        //    var response = await _productService.CreateOrUpdateProductSetupCostConfigurations(request);
        //    return StatusCode((int)response.StatusCode, response);
        //}

        [HttpPost("product-setup-subject-configuration")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CreateProductCategorySubjectDataAsync(ProductCategorySubjectSetupDto request)
        {
            var response = await _productService.CreateProductCategorySubjectDataAsync(request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPut("update-product-subject-data-async")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateProductSubjectDataAsync(int categoryId, ProductSubjectCategoryRequest updatedCategory)
        {
            var response = await _productService.UpdateProductSubjectDataAsync(categoryId,updatedCategory);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpDelete("delete-product-subject-data-async")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteProductSubjectDataAsync(int categoryId)
        {
            var response = await _productService.DeleteProductSubjectDataAsync(categoryId);
            return StatusCode((int)response.StatusCode, response);
        }


        


        //[HttpPost("create-product-setup-document")]
        //[ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        //[ProducesResponseType((int)HttpStatusCode.NotFound)]
        //public async Task<IActionResult> CreateOrUpdateCreateProductSetupDocument(ProductSetupDocumentConfigurationRequest request)
        //{
        //    var response = await _productService.CreateOrUpdateProductSetupDocument(request);
        //    return StatusCode((int)response.StatusCode, response);
        //}

        //[HttpPost("create-product-fee-setup")]
        //[ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        //[ProducesResponseType((int)HttpStatusCode.NotFound)]
        //public async Task<IActionResult> CreateOrUpdateCreateProductFeeSetup(ProductSetupFeeSetupConfigurationRequest request)
        //{
        //    var response = await _productService.CreateOrUpdateProductFeeSetup(request);
        //    return StatusCode((int)response.StatusCode, response);
        //}



        [HttpPost("save-draft")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> SaveOrUpdateDraft(ProductSetupDraftRequest request)
        {
            var response = await _productService.SaveOrUpdateDraft(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-draft/{productName}")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetDraft(string productName)
        {
            var response = await _productService.GetDraftByProductName(productName);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("product-team")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> ProductTeamSetup([FromBody] ProductTeamRequest request)
        {
            var response = await _productService.SetupProductTeam(request);
            return StatusCode((int) response.StatusCode ,response);
        }

        [HttpGet("all-product")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllProducts([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var response = await _productService.GetAllProduct(pageNumber, pageSize);
            return StatusCode((int)response.StatusCode,response);
        }

        [HttpGet("get-all-product-by-businessline")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetAllProductByBusinessline(int businessId, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var response = await _productService.GetAllProductByBusinessline(businessId,pageNumber, pageSize);
            return StatusCode((int)response.StatusCode, response);
        }
      

        [HttpGet("product/{productId}")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetSingleProduct(int productId)
        {
            var response = await _productService.GetSingleProduct(productId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("product-penalty")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> ProductSetupPenalty(ProductPenaltyRequest request)
        {
            var response = await _productService.ProductSetupPenalty(request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPut("update-penalty/{penaltyId}")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> UpdateSetupPenalty(int penaltyId, PenaltyRequest request)
        {
            var response = await _productService.UpdateSetupPenalty(penaltyId,request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpDelete("delete-penalty/{penaltyId}")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> DeleteSetupPenalty(int penaltyId)
        {
            var response = await _productService.DeleteSetupPenalty(penaltyId);
            return StatusCode((int)response.StatusCode, response);
        }



        [HttpPost("create-subject-attribute-mapping")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<ProductSubjectAttributeDropdownMapping>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateProductSubjectAttributeMapping(List<ProductSubjectAttributeDropdownMappingRequest> dropdownMappingRequests)
        {
            var response = await _productService.CreateProductSubjectAttributeMapping(dropdownMappingRequests);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-product-subject-attribute-mappings")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<ProductSubjectAttributeDropdownMappingResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetProductSubjectAttributeMappings(int productId)
        {
            var response = await _productService.GetProductSubjectAttributeMappings(productId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("finance-team-setup")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> FinanceSetup(FinanceRequest request)
        {
            var response = await _productService.AddProductFinancialRecords(request);
            return StatusCode((int)response.StatusCode,response);
        }

        [HttpGet("financial-records/{productId}")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<ProductFinancesResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetFinanceSetup(int productId)
        {
            var response = await _productService.GetProductFinancialRecords(productId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPut("update-financial-records")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateProductFinancialRecord(int productId, int ledgerId, string ledgerType, UpdateLedgerRequest request)
        {
            var response = await _productService.UpdateProductFinancialRecord(productId, ledgerId, ledgerType,request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-cost-of-insurance")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<ProductCostOfInsuranceResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetCostOfInsurance(int productId)
        {
            var response = await _productService.GetProductCostOfInsurance(productId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPost("create-cost-of-insurance-account")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<ProductCostOfInsuranceResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CreateAccountForCostOfInsurance(CostOfInsuranceAccountRequest requests)
        {
            var response = await _productService.CreateAccountForCostOfInsurance(requests);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-accounts")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountSearchResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetAccounts()
        {
            var response = await _productService.GetAccounts();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-product-income-account")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> ProductIncomeAccount(string searchKeyword = null)
        {
            var response = await _productService.ProductIncomeAccount(searchKeyword);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-coinsurance-management-fees")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CoinsuranceManagementFees(string searchKeyword = null)
        {
            var response = await _productService.CoinsuranceManagementFees(searchKeyword);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-reinsurance-commissions")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> ReinsuranceCommissions(string searchKeyword = null)
        {
            var response = await _productService.ReinsuranceCommissions(searchKeyword);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-coinsurance-premium-outward")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CoinsurancePremiumOutward(string searchKeyword = null)
        {
            var response = await _productService.CoinsurancePremiumOutward(searchKeyword);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-reinsurance-premium-expense")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> ReinsurancePremiumExpense(string searchKeyword = null)
        {
            var response = await _productService.ReinsurancePremiumExpense(searchKeyword);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-broker-commissions-expense")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> BrokerCommissionsExpense(string searchKeyword = null)
        {
            var response = await _productService.BrokerCommissionsExpense(searchKeyword);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-coinsurance-receivable-ledger")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CoinsuranceReceivableLedger(string searchKeyword = null)
        {
            var response = await _productService.CoinsuranceReceivableLedger(searchKeyword);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-vat-expense-ledger")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> VatExpense(string searchKeyword = null)
        {
            var response = await _productService.VATExpenseLedger(searchKeyword);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-wht-payable-ledger")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> WhtPayableLedger(string searchKeyword = null)
        {
            var response = await _productService.WHTPayableLedger(searchKeyword);
            return StatusCode((int)response.StatusCode, response);
        }




    

        [HttpPost("create-location-setup")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<AccountResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CreateLocationSetup(LocationSetupRequest request)
        {
            var response = await _productService.CreateLocationSetup(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("get-all-locations/{productId}")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<List<LocationFieldResponses>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetAllLocations(int productId)
        {
            var response = await _productService.GetAllLocations(productId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPut("update-location")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateLocation(UpdateLocationRequest request)
        {
            var response = await _productService.UpdateLocationSetup(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpDelete("delete-location")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteLocation(DeleteLocationRequest request) {
            var response = await _productService.DeleteLocationSetup(request);
            return StatusCode((int)response.StatusCode, response);

        }

   

        [HttpGet("get-all-data-type")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetAllDataType()
        {
            var response = await _productService.GetAllDataType();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("create-price-configuration")]
        [ProducesResponseType((int)HttpStatusCode.Created, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CreatePriceConFiguration(List<CreateProductPricingConfigurationDto> request)
        {
            var response = await _productService.ProductPricingAttributeConfiguration(request);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-price-configuration")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<List<ProductPricingConfigurationResponse>>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetPriceConFiguration(int productId)
        {
            var response = await _productService.GetProductPricingConfigurations(productId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpPut("update-price-configuration")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdatePriceConFiguration([FromBody] List<BulkUpdateProductPricingConfigurationDto> request)
        {
            var response = await _productService.BulkUpdateProductPricingConfigurations(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("price-configuration-approving")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetPriceConfigurationAllApprovingOffice()
        {
            var response = await _productService.GetPriceConfigurationAllApprovingOffice();
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("set-approval-for-price-configuration")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> SetApprovalForPriceConfiguration(List<PriceConfigurationApprovingOfficeInfo> request)
        {
            var response = await _productService.SetApprovalForPriceConfiguration(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPut("update-approval-for-price-configuration")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateApprovalForPriceConfiguration(UpdatePriceConfigurationApprovingOfficeInfo request)
        {
            var response = await _productService.UpdateApprovalForPriceConfiguration(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpDelete("delete-approval-for-price-configuration/{Id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteApprovalForPriceConfiguration(int Id)
        {
            var response = await _productService.DeleteApprovalForPriceConfiguration(Id);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpGet("get-all-approval-for-price-configurations/{priceConfigurationId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetAllApprovalForPriceConfigurations(int priceConfigurationId)
        {
            var response = await _productService.GetAllApprovalForPriceConfigurations(priceConfigurationId);
            return StatusCode((int)response.StatusCode, response);
        }



        [HttpPost("createThreshold")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CreateThreshold([FromBody] ThresholdRequestdto request)
        {
            var response = await _productService.CreateThreshold(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("createProductDeductible")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CreateProductDeductible([FromBody] ProductDeductibleDto request)
        {
            var response = await _productService.CreateProductDeductible(request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPost("createProductDurationRate")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<GenericNameResponse>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CreateProductDurationRate([FromBody] ProductDurationRatedto request)
        {
            var response = await _productService.CreateProductDurationRate(request);
            return StatusCode((int)response.StatusCode, response);
        }

        // Read Methods
        [HttpGet("getAllProductThresholds/{productId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetAllProductThresholds(int productId)
        {
            var response = await _productService.GetAllProductThresholds(productId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("getProductThresholdById/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetProductThresholdById(int id)
        {
            var response = await _productService.GetProductThresholdById(id);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("getAllProductDeductibles/{productId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetAllProductDeductibles(int productId)
        {
            var response = await _productService.GetAllProductDeductibles(productId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("getProductDeductibleById/{deductibleId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetProductDeductibleById(int deductibleId)
        {
            var response = await _productService.GetProductDeductibleById(deductibleId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("getAllProductDurationRates/{productId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetAllProductDurationRates(int productId)
        {
            var response = await _productService.GetAllProductDurationRates(productId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpGet("getProductDurationRateById/{rateId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetProductDurationRateById(int rateId)
        {
            var response = await _productService.GetProductDurationRateById(rateId);
            return StatusCode((int)response.StatusCode, response);
        }

        // Update Methods
        [HttpPut("updateProductThreshold/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateProductThreshold(int id, [FromBody] ThresholdRequestdto request)
        {
            var response = await _productService.UpdateProductThreshold(id, request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPut("updateProductDeductible/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateProductDeductible(int id, [FromBody] ProductDeductibleRequestDto request)
        {
            var response = await _productService.UpdateProductDeductible(id, request);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpPut("updateProductDurationRate/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> UpdateProductDurationRate(int id, [FromBody] ProductDurationRatedUpdateRequest request)
        {
            var response = await _productService.UpdateProductDurationRate(id, request);
            return StatusCode((int)response.StatusCode, response);
        }



        [HttpDelete("delete-product-duration-rate/{rateId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteProductDurationRate(int rateId)
        {
            var response = await _productService.DeleteProductDurationRate(rateId);
            return StatusCode((int)response.StatusCode, response);
        }

        [HttpDelete("delete-threshold/{thresholdId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteThreshold(int thresholdId)
        {
            var response = await _productService.DeleteThreshold(thresholdId);
            return StatusCode((int)response.StatusCode, response);
        }


        [HttpDelete("delete-product-deductible/{deductibleId}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteProductDeductible(int deductibleId)
        {
            var response = await _productService.DeleteProductDeductible(deductibleId);
            return StatusCode((int)response.StatusCode, response);
        }




        [HttpDelete("create-workflow-approval")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse<string>))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> CreateWorkflowApproval(int productId, string productName)
        {
            var response = await _productService.CreateWorkflowApproval(productId, productName);
            return StatusCode((int)response.StatusCode, response);
        }


       
    }
}




