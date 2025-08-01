using RubyNonlife.Application.Dtos.Responses;
using Microsoft.EntityFrameworkCore;
using RubyNonlife.Infrastructure.Contract;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using RubyNonlife.Domain.Models.ProductEntities;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using System.Net;
using Microsoft.AspNetCore.Http;
using RubyNonlife.Domain.Models.NonLifeProduct;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using Microsoft.CodeAnalysis;
using RubyNonlife.Application.Validators.ProductSetup;
using RubyNonlife.Infrastructure.Persistence;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Application.Contract;
using System.ComponentModel.DataAnnotations;
using RubyNonlife.Application.Helper.UtitlityModel;
using RubyNonlife.Application.Utitlies;
using RubyNonlife.Application.Dtos.Requests.WorkFlowRequest;
using RubyNonlife.Application.Dtos.Requests.FinanceRequest;
using Microsoft.Extensions.DependencyInjection;
using RubyNonlife.Domain.Models.ApprovalWorks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using RubyNonlife.Application.Dtos.Responses.Quotation;
using RubyNonlife.Application.Dtos.Responses.WorkFlow;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using Azure;





namespace RubyNonlife.Infrastructure.Implementations
{
    public class ProductSetupService(RubyDbContext _rubyContext,
        IHttpContextAccessor _contextAccessor, IConfiguration _configuration,
        IOptions<ApiSettings> _apiSettings, AdminAuthenticationHelper _adminHelper,
        HttpClient _httpClient,  IAdminServiceIntegration _adminService,
        IServiceProvider _serviceProvider,
        IOptions<ConfigModels> configOptions,
        IFinanceService _financeSetup,
        IFinanceServiceIntegration _financeService,
        FinanceAuthenticationHelper _financeHelper
        ) : IProductSetupService{

        public async Task<BaseResponse<ProductCodeResponse>> GenerateProductCode(CreateProductRequest request)
        {

            string productCode = GetNextNonLifeProductCode(_rubyContext).ToString();

            var productExist = await _rubyContext.Products.FirstOrDefaultAsync(d => d.Name == request.ProductName);
            if (productExist != null)
                return ResponseFactory.CreateError<ProductCodeResponse>("This Product Exist", HttpStatusCode.BadRequest);

            Product product = new()
            {
                Name = request.ProductName,
                Description = request.Description,
                Alias = request.Alias,
                Code = productCode,
                ProductClassId = request.ProductClassId,
                PercentageProgress = (int)ProductPercentageProcess.ProductSetupStage,
                SetupStatus = ProductStatuses.InComplete.ToString(),
                ApprovalStatus = ProductStatuses.InComplete.ToString()
            };
            _rubyContext.Add(product);
            await _rubyContext.SaveChangesAsync();
            ProductCodeResponse productResponse = new()
            {
                ProductCode = productCode,
            };

            return new BaseResponse<ProductCodeResponse>
            {
                Success = true,
                Data = productResponse,
                ResponseMessage = "Product Code Generated",
                StatusCode = HttpStatusCode.OK,
            };

        }
        public async Task<BaseResponse<GenericNameResponse>> CreateOrUpdateProductSetupBasicInformation(ProductSetupBasicInformationRequest request)
        {
            // Check if the product already exists
            var product = await _rubyContext.Products
                .FirstOrDefaultAsync(d => d.Name == request.ProductName);
            
                product = new Product
                {
                    Name = request.ProductName,
                    VariantId = request.VariantId,
                    RequiresUnderWriter = request.RequiresUnderWriter,
                    PercentageProgress = (int)ProductPercentageProcess.ProductSetupStage,
                    SetupStatus = request.RequiresUnderWriter ? ProductStatuses.Complete.ToString() : ProductStatuses.InComplete.ToString(),
                    ApprovalStatus = ProductStatuses.Complete.ToString(),
                    ProductSetupStages = ProductSetupStages.BasicInformation.GetDescription(),
                    ProductBaseSubjectTypeCovers = new List<ProductBaseSubjectTypeCover>(),
                    ProductAdditionalSubjectTypeCovers = new List<ProductAdditionalSubjectTypeCover>(),
                    ProductAllowedPaymentFrequency = new List<ProductAllowedPaymentFrequency>()
                };
                _rubyContext.Products.Add(product); // Add the new product

                // Add or update the ProductBaseSubjectTypeCovers
                if (request.BaseSubjectTypeCovers.Any())
                {
                    foreach (var cover in request.BaseSubjectTypeCovers)
                    {
                        var baseCover = new ProductBaseSubjectTypeCover
                        {
                            ProductId = product.Id,
                            BaseCoverId = cover.CoverId,
                            LimitType = cover.LimitType
                        };
                        product.ProductBaseSubjectTypeCovers.Add(baseCover);
                    }
                }

                // Add or update the ProductAdditionalSubjectTypeCovers
                if (request.AdditionalSubjectTypeCoverRequest.Any())
                {
                    foreach (var additionalCover in request.AdditionalSubjectTypeCoverRequest)
                    {
                        var addCovers = new ProductAdditionalSubjectTypeCover
                        {
                            ProductId = product.Id,
                            AdditionalCoverId = additionalCover.CoverId,
                            LimitType = additionalCover.LimitType
                        };
                        product.ProductAdditionalSubjectTypeCovers.Add(addCovers);
                    }
                }

                // Add or update the ProductAllowedPaymentFrequency
                if (request.paymentFrequencies.Any())
                {
                    foreach (var frequencies in request.paymentFrequencies)
                    {
                        var frequency = new ProductAllowedPaymentFrequency
                        {
                            ProductId = product.Id,
                            PaymentFrequency = frequencies.PaymentIntervals,
                            DateCreated = DateTime.UtcNow,
                            IsDeleted = false
                        };
                        product.ProductAllowedPaymentFrequency.Add(frequency);
                    }
                }

                // Save changes to the database
                await _rubyContext.SaveChangesAsync();
            
           

            

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("BasicInformation Successfully Created or Updated", HttpStatusCode.Created);
        }
        public async Task<BaseResponse<GenericNameResponse>>UpdateProductSetupBasicInformation(ProductSetupBasicInformationRequest request, int productId)
        {
            var product = await _rubyContext.Products
             .FirstOrDefaultAsync(d => d.Id == productId);

            product.VariantId = request.VariantId;
            product.Description = request.Description;
            product.RequiresUnderWriter = request.RequiresUnderWriter;
            product.PercentageProgress = Math.Min(100, product.PercentageProgress + (int)ProductPercentageProcess.ProductSetupStage);
            product.SetupStatus = request.RequiresUnderWriter ? ProductStatuses.Complete.ToString() : ProductStatuses.InComplete.ToString();
            product.ApprovalStatus = ProductStatuses.Complete.ToString();
            product.ProductSetupStages = ProductSetupStages.BasicInformation.GetDescription();
            // Add or update the ProductBaseSubjectTypeCovers

            var baseCovers = await _rubyContext.ProductBaseCovers.Where(d => d.ProductId == productId).ToListAsync();
           
           
             foreach (var cover in request.BaseSubjectTypeCovers){
                var existingCover = baseCovers.FirstOrDefault(ec => ec.BaseCoverId == cover.CoverId);

                    if(existingCover != null)
                    {
                        existingCover.BaseCoverId = cover.CoverId;
                        existingCover.LimitType = cover.LimitType;
                    }
                }


            // Add or update the ProductAdditionalSubjectTypeCovers
            var additionalCovers = await _rubyContext.ProductAdditionalCovers.Where(d => d.ProductId == productId).ToListAsync();
             foreach (var additionalCover in request.AdditionalSubjectTypeCoverRequest){
                 var existingAddtionalCover = additionalCovers.FirstOrDefault(ac=>ac.AdditionalCoverId == additionalCover.CoverId);
                   if(existingAddtionalCover != null)
                {
                    existingAddtionalCover.AdditionalCoverId = additionalCover.CoverId;
                    existingAddtionalCover.LimitType = additionalCover.LimitType;
                }
             }


            var frequencies = await _rubyContext.ProductAllowedPaymentFrequencies.Where(p => p.ProductId == productId).ToListAsync();
            // Add or update the ProductAllowedPaymentFrequency
           
            foreach (var frequency in request.paymentFrequencies)
                {
                var existingFrequency = frequencies.FirstOrDefault(p => p.PaymentFrequency == frequency.PaymentIntervals);
                   if(existingFrequency != null) { 
                        existingFrequency.PaymentFrequency= frequency.PaymentIntervals;
                    }
                }

            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Product Updated Successelly",HttpStatusCode.OK);
        }
        public async Task<BaseResponse<GenericNameResponse>> CreateProductSetupBasicInformation(ProductSetupBasicInformationRequest request)
        {
            // Check if the product already exists
            var existingProduct = await _rubyContext.Products
                .FirstOrDefaultAsync(d => d.Name == request.ProductName);

            // If the product already exists, return an error
            if (existingProduct != null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>("Product already exists.", HttpStatusCode.Conflict);
            }

            // Create a new product
            var product = new Product
            {
                Name = request.ProductName,
                VariantId = request.VariantId,
                RequiresUnderWriter = request.RequiresUnderWriter,
                PercentageProgress = (int)ProductPercentageProcess.ProductSetupStage,
                SetupStatus = request.RequiresUnderWriter ? ProductStatuses.Complete.ToString() : ProductStatuses.InComplete.ToString(),
                ApprovalStatus = ProductStatuses.Complete.ToString(),
                ProductSetupStages = ProductSetupStages.BasicInformation.GetDescription(),
                ProductBaseSubjectTypeCovers = new List<ProductBaseSubjectTypeCover>(),
                ProductAdditionalSubjectTypeCovers = new List<ProductAdditionalSubjectTypeCover>(),
                ProductAllowedPaymentFrequency = new List<ProductAllowedPaymentFrequency>()
            };

            _rubyContext.Products.Add(product); // Add the new product

            // Add ProductBaseSubjectTypeCovers
            if (request.BaseSubjectTypeCovers.Any())
            {
                foreach (var cover in request.BaseSubjectTypeCovers)
                {
                    var baseCover = new ProductBaseSubjectTypeCover
                    {
                        ProductId = product.Id,
                        BaseCoverId = cover.CoverId,
                        LimitType = cover.LimitType
                    };
                    product.ProductBaseSubjectTypeCovers.Add(baseCover);
                }
            }

            // Add ProductAdditionalSubjectTypeCovers
            if (request.AdditionalSubjectTypeCoverRequest.Any())
            {
                foreach (var additionalCover in request.AdditionalSubjectTypeCoverRequest)
                {
                    var addCovers = new ProductAdditionalSubjectTypeCover
                    {
                        ProductId = product.Id,
                        AdditionalCoverId = additionalCover.CoverId,
                        LimitType = additionalCover.LimitType
                    };
                    product.ProductAdditionalSubjectTypeCovers.Add(addCovers);
                }
            }

            // Add ProductAllowedPaymentFrequency
            if (request.paymentFrequencies.Any())
            {
                foreach (var frequencies in request.paymentFrequencies)
                {
                    var frequency = new ProductAllowedPaymentFrequency
                    {
                        ProductId = product.Id,
                        PaymentFrequency = frequencies.PaymentIntervals,
                        DateCreated = DateTime.UtcNow,
                        IsDeleted = false
                    };
                    product.ProductAllowedPaymentFrequency.Add(frequency);
                }
            }

            // Save changes to the database
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Basic Information Successfully Created", HttpStatusCode.Created);
        }
        public async Task<BaseResponse<GenericNameResponse>> UpdateProductSetupBasicInformation(ProductSetupBasicInformationUpdateRequest request)
        {
            var product = await _rubyContext.Products
                .Include(p => p.ProductBaseSubjectTypeCovers)
                .Include(p => p.ProductAdditionalSubjectTypeCovers)
                .Include(p => p.ProductAllowedPaymentFrequency)
                .FirstOrDefaultAsync(d => d.Id == request.ProductId);

            if (product == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product not found.", HttpStatusCode.NotFound);

            // Update main product details
            product.Name = request.ProductName;
            product.VariantId = request.VariantId;
            product.RequiresUnderWriter = request.RequiresUnderWriter;
            product.PercentageProgress = Math.Min(100, product.PercentageProgress + (int)ProductPercentageProcess.ProductSetupStage);
            product.SetupStatus = request.RequiresUnderWriter ? ProductStatuses.Complete.ToString() : ProductStatuses.InComplete.ToString();
            product.ApprovalStatus = ProductStatuses.Complete.ToString();
            product.ProductSetupStages = ProductSetupStages.BasicInformation.GetDescription();

            // Update existing BaseSubjectTypeCovers
            foreach (var cover in request.BaseSubjectTypeCovers)
            {
                var existingCover = product.ProductBaseSubjectTypeCovers.FirstOrDefault(c => c.Id == cover.Id);
                if (existingCover != null)
                {
                    existingCover.BaseCoverId = cover.CoverId;
                    existingCover.LimitType = cover.LimitType;
                }
            }

            // Update existing AdditionalSubjectTypeCovers
            foreach (var additionalCover in request.AdditionalSubjectTypeCoverRequest)
            {
                var existingCover = product.ProductAdditionalSubjectTypeCovers.FirstOrDefault(c => c.Id == additionalCover.Id);
                if (existingCover != null)
                {
                    existingCover.AdditionalCoverId = additionalCover.CoverId;
                    existingCover.LimitType = additionalCover.LimitType;
                }
            }

            // Update existing Payment Frequencies
            foreach (var freq in request.PaymentFrequencies)
            {
                var existingFrequency = product.ProductAllowedPaymentFrequency.FirstOrDefault(f => f.Id == freq.Id);
                if (existingFrequency != null)
                {
                    existingFrequency.PaymentFrequency = freq.PaymentIntervals;
                }
            }

            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Basic information successfully updated.", HttpStatusCode.OK);
        }
        public async Task<BaseResponse<GenericNameResponse>> CreateProductSetupCostConfigurations(ProductSetupCostConfigurationRequest request)
        {
            // Validate Product
            var product = await _rubyContext.Products
                .Include(p => p.ProductCostOfInsurances)
                .Include(p => p.ProductBaseSubjectTypeCovers)
                .Include(p => p.ProductAdditionalSubjectTypeCovers)
                .Include(p => p.ProductCostType)
                .FirstOrDefaultAsync(d => d.Id == request.ProductId);

            if (product == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product not found.", HttpStatusCode.NotFound);

            // Extract existing Base Cover IDs
            var baseSubjectTypeCoverIds = product.ProductBaseSubjectTypeCovers.Select(d => d.BaseCoverId).ToHashSet();
            var additionalSubjectTypeCoverIds = product.ProductAdditionalSubjectTypeCovers.Select(d => d.AdditionalCoverId).ToHashSet();
            var costTypeIds = product.ProductCostType.Select(d => d.CostTypeId).ToHashSet();

            var costOfInsuranceIds = product.ProductCostOfInsurances.Select(d => d.CostTypeId).ToHashSet();

            // Update existing base covers
            foreach (var baseCoverRequest in request.ProductSetupCostConfigureForBaseCovers)
            {
                if (baseSubjectTypeCoverIds.Contains(baseCoverRequest.BaseCoverId))
                {
                    var baseCover = await _rubyContext.ProductBaseCovers
                        .FirstOrDefaultAsync(bc => bc.BaseCoverId == baseCoverRequest.BaseCoverId && bc.ProductId == request.ProductId);

                    if (baseCover != null)
                    {
                        baseCover.CoverStatus = baseCoverRequest.Status;
                        baseCover.MaximumAmount = baseCoverRequest.MaximumAmount;
                        baseCover.DisplayFormula = baseCoverRequest.DisplayFormula;
                        baseCover.RateApplied = baseCoverRequest.RateApplied;
                        baseCover.RateTable = baseCoverRequest.UseRateTable;
                        _rubyContext.Entry(baseCover).State = EntityState.Modified;
                    }
                }
            }

            foreach (var additionalCoverRequest in request.ProductSetupCostConfigureForAdditionalCovers)
            {
                if (additionalSubjectTypeCoverIds.Contains(additionalCoverRequest.AdditionalCoverId))
                {
                    var additionalCover = await _rubyContext.ProductAdditionalCovers
                        .FirstOrDefaultAsync(ac => ac.AdditionalCoverId == additionalCoverRequest.AdditionalCoverId && ac.ProductId == request.ProductId);

                    if (additionalCover != null)
                    {
                        additionalCover.CoverStatus = additionalCoverRequest.Status;
                        additionalCover.MaximumAmount = additionalCoverRequest.MaximumAmount;
                        additionalCover.DisplayFormula = additionalCoverRequest.DisplayFormula;
                        additionalCover.RateApplied = additionalCoverRequest.RateApplied;
                        additionalCover.RateTable = additionalCoverRequest.UseRateTable;

                        _rubyContext.Entry(additionalCover).State = EntityState.Modified;
                    }
                }
            }

            // Add new cost types
            foreach (var costTypesRequest in request.CostTypes)
            {
                var newCostType = new ProductCostType
                {
                    Remark = costTypesRequest.Remark,
                    CostTypeId = costTypesRequest.CostTypeId,
                    ProductId = request.ProductId
                };

                _rubyContext.ProductCostTypes.Add(newCostType);
            }

            // Add new costs of insurance
            foreach (var costOfInsuranceRequest in request.CostsOfInsurance)
            {
                var newCostOfInsurance = new ProductCostOfInsurance
                {
                    ProductId = request.ProductId,
                    CostTypeId = costOfInsuranceRequest.CostType,
                    CostBearer = costOfInsuranceRequest.CostBearer,
                    CollectionSourceId = costOfInsuranceRequest.SourceId,
                    Year = costOfInsuranceRequest.Year,
                    Rate = costOfInsuranceRequest.Rate.ToString(),
                    TermValue = costOfInsuranceRequest.Value,
                    DisplayFormula = costOfInsuranceRequest.DisplayFormula
                };

                _rubyContext.ProductCostOfInsurances.Add(newCostOfInsurance);
            }

            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Cost configuration successfully created.", HttpStatusCode.Created);
        }
        public async Task<BaseResponse<GenericNameResponse>> UpdateProductSetupCostConfigurations(ProductSetupCostConfigurationUpdateRequest request)
        {
            // Validate Product
            var product = await _rubyContext.Products
                .Include(p => p.ProductCostOfInsurances)
                .Include(p => p.ProductBaseSubjectTypeCovers)
                .Include(p => p.ProductAdditionalSubjectTypeCovers)
                .Include(p => p.ProductCostType)
                .FirstOrDefaultAsync(d => d.Id == request.ProductId);

            if (product == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product not found.", HttpStatusCode.NotFound);


            foreach (var baseCoverRequest in request.basicBaseSubjectTypeCoverUpdateRequests)
            {
                var existingCostType = product.ProductBaseSubjectTypeCovers.FirstOrDefault(c => c.Id == baseCoverRequest.Id);
                if (existingCostType != null)
                {
                    existingCostType.DisplayFormula = baseCoverRequest.DisplayFormula;
                    existingCostType.CoverStatus = baseCoverRequest.Status;
                    existingCostType.BaseCoverId = baseCoverRequest.BaseCover;
                    existingCostType.MaximumAmount = baseCoverRequest.MaximumAmount;
                    existingCostType.RateApplied = baseCoverRequest.RateApplied;
                    existingCostType.RateTable = baseCoverRequest.UseRateTable;
                }
            }

            // Update cost types
            foreach (var costTypeRequest in request.CostTypes)
            {
                var existingCostType = product.ProductCostType.FirstOrDefault(c => c.Id == costTypeRequest.Id);
                if (existingCostType != null)
                {
                    existingCostType.Remark = costTypeRequest.Remark;
                    existingCostType.CostTypeId = costTypeRequest.CostTypeId;
                }
            }

            // Update costs of insurance
            foreach (var costOfInsuranceRequest in request.CostsOfInsurance)
            {
                var existingCostOfInsurance = product.ProductCostOfInsurances.FirstOrDefault(c => c.Id == costOfInsuranceRequest.Id);
                if (existingCostOfInsurance != null)
                {
                    existingCostOfInsurance.CostTypeId = costOfInsuranceRequest.CostType;
                    existingCostOfInsurance.CostBearer = costOfInsuranceRequest.CostBearer;
                    existingCostOfInsurance.CollectionSourceId = costOfInsuranceRequest.SourceId;
                    existingCostOfInsurance.Year = costOfInsuranceRequest.Year;
                    existingCostOfInsurance.Rate = costOfInsuranceRequest.Rate.ToString();
                    existingCostOfInsurance.TermValue = costOfInsuranceRequest.Value;
                    existingCostOfInsurance.DisplayFormula = costOfInsuranceRequest.DisplayFormula;
                }
            }

            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Cost configuration successfully updated.", HttpStatusCode.OK);
        }
        public async Task<BaseResponse<GenericNameResponse>> CreateOrUpdateProductSetupCostConfigurations(ProductSetupCostConfigurationRequest request)
        {
            // Validate Product
            var product = await _rubyContext.Products
                .Include(p => p.ProductCostOfInsurances)
                .Include(p => p.ProductBaseSubjectTypeCovers)
                .Include(p => p.ProductAdditionalSubjectTypeCovers)
                .Include(p => p.ProductCostType)
                .FirstOrDefaultAsync(d => d.Id == request.ProductId);

            if (product == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product not found.", HttpStatusCode.NotFound);

          
                foreach (var costTypesRequest in request.CostTypes)
                {
                   
                        // Create a new record
                        var newCostType = new ProductCostType
                        {
                            Remark = costTypesRequest.Remark,
                            CostTypeId = costTypesRequest.CostTypeId,
                            ProductId = request.ProductId
                        };

                        _rubyContext.ProductCostTypes.Add(newCostType);
                    
                }
            
                foreach (var costOfInsuranceRequest in request.CostsOfInsurance)
                {
                   
                        var newCostOfInsurance = new ProductCostOfInsurance
                        {
                            ProductId = request.ProductId,
                            CostTypeId = costOfInsuranceRequest.CostType,
                            CostBearer = costOfInsuranceRequest.CostBearer,
                            CollectionSourceId = costOfInsuranceRequest.SourceId,
                            Year = costOfInsuranceRequest.Year,
                            Rate = costOfInsuranceRequest.Rate.ToString(),
                            TermValue = costOfInsuranceRequest.Value,
                            DisplayFormula = costOfInsuranceRequest.DisplayFormula
                        };

                        _rubyContext.ProductCostOfInsurances.Add(newCostOfInsurance);
                    
                }
            


            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Cost configuration successfully updated.", HttpStatusCode.OK);
        }
        public async Task<BaseResponse<GenericNameResponse>> CreateOrUpdateProductSetupSubjectConfiguration(ProductSubjectConfigurationRequest request)
        {
            // Validate Product
            var product = await _rubyContext.Products
                .Include(p => p.ProductSubjectTypes) // If product contains subject types, otherwise adjust
                .FirstOrDefaultAsync(d => d.Id == request.ProductId);

            if (product == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product not found.", HttpStatusCode.NotFound);

            // Extract subject type IDs and product subject categories
            var subjectTypeIds = request.ProductSubjectAttributeRequests
                                        .SelectMany(c => c.ProductSubjectAttributes) // Flatten all attributes
                                        .Select(x => x.SubjectTypeId)
                                        .Distinct()
                                        .ToList();

            var productSubjectCategories = request.ProductSubjectAttributeRequests; // This will be the list of categories
            var categoryNameToId = productSubjectCategories.ToDictionary(c => c.CategoryName, c => c.ProductSubjectAttributes.FirstOrDefault()?.SubjectTypeId ?? 0); // Assuming CategoryName maps to SubjectTypeId

            // Create or Update Product Subject Types
            var productSubjectTypes = await CreateOrUpdateProductSubjectTypesAsync(subjectTypeIds, productSubjectCategories, request.ProductId, categoryNameToId);

            if (productSubjectTypes.Any())
            {
                // Add created or updated product subject types to the product
                foreach (var subjectType in productSubjectTypes)
                {
                    if (!product.ProductSubjectTypes.Contains(subjectType))
                    {
                        product.ProductSubjectTypes.Add(subjectType);
                    }
                }
                await _rubyContext.SaveChangesAsync(); // Save changes to the database
            }

            product.ProductSetupStages = ProductSetupStages.SubjectConfigure.GetDescription();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Product subject configuration created/updated successfully.", HttpStatusCode.OK);
        }
        public async Task<BaseResponse<GenericNameResponse>> CreateOrUpdateProductSetupDocument(ProductSetupDocumentConfigurationRequest request)
        {
            var product = await _rubyContext.Products
                .FirstOrDefaultAsync(d => d.Id == request.ProductId);

            if (product == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product not found.", HttpStatusCode.NotFound);

            foreach (var documentRequest in request.PolicyDocuments)
            {
                //var existingDocument = await _rubyContext.ProductDocuments
                //    .FirstOrDefaultAsync(d => d.ProductId == product.Id && d.DocumentName == documentRequest.Name);

                //if (existingDocument != null)
                //{
                //    // Update existing document
                //    existingDocument.Format = documentRequest.Format;
                //    existingDocument.Size = documentRequest.Size;
                //    existingDocument.IsRequired = documentRequest.IsRequired;
                //}
                //else
                //{
                //    // Create new document
                //    var newDocument = new ProductDocument
                //    {
                //        ProductId = product.Id,
                //        DocumentName = documentRequest.Name,
                //        Format = documentRequest.Format,
                //        Size = documentRequest.Size,
                //        IsRequired = documentRequest.IsRequired,
                //    };

                //    product.ProductDocuments.Add(newDocument);
                //}
            }

            product.ProductSetupStages = ProductSetupStages.Documentation.GetDescription();
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Document configuration created/updated successfully.", HttpStatusCode.OK);
        }
        public async Task<BaseResponse<GenericNameResponse>> CreateOrUpdateProductFeeSetup(ProductSetupFeeSetupConfigurationRequest request)
        {
            var product = await _rubyContext.Products
                .FirstOrDefaultAsync(d => d.Id == request.ProductId);

            if (product == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product not found.", HttpStatusCode.NotFound);

            foreach (var feeRequest in request.ProductFeeSetupRequests)
            {
                var existingFeeSetup = await _rubyContext.ProductFeeSetups
                    .FirstOrDefaultAsync(f => f.ProductId == product.Id && f.FeeName == feeRequest.Name);

                if (existingFeeSetup != null)
                {
                    // Update existing fee setup
                    existingFeeSetup.PercentageValue = feeRequest.Value;
                    existingFeeSetup.Description = feeRequest.Description;
                }
                else
                {
                    // Create new fee setup
                    var newFeeSetup = new ProductFeeSetup
                    {
                        ProductId = product.Id,
                        FeeName = feeRequest.Name,
                        PercentageValue = feeRequest.Value,
                        Description = feeRequest.Description,
                    };

                    product.ProductFeeSetup.Add(newFeeSetup);
                }
            }

            product.ProductSetupStages = ProductSetupStages.FeeSetup.GetDescription();
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Fee setup configuration created/updated successfully.", HttpStatusCode.OK);
        }
        public async Task<BaseResponse<ProductStagingResponse>> SaveOrUpdateDraft(ProductSetupDraftRequest request)
        {
            var response = new BaseResponse<ProductStagingResponse>();

            if (request == null)
            {
                return new BaseResponse<ProductStagingResponse>
                {
                    Success = false,
                    ResponseMessage = "Request cannot be null.",
                    StatusCode = HttpStatusCode.BadRequest
                };
            }

            // Serialize the request object to JSON
            string dataJson = JsonConvert.SerializeObject(request);

            // Check if the record exists
            var existingRecord = await _rubyContext.ProductStaging
                .Where(ps => ps.ProductName.ToLower() == request.ProductName.ToLower())
                .FirstOrDefaultAsync();

            if (existingRecord != null)
            {
                // Update existing record
                existingRecord.Data = dataJson;
                existingRecord.DateCreated = DateTime.UtcNow;
                _rubyContext.ProductStaging.Update(existingRecord);
            }
            else
            {
                // Create new record
                var newRecord = new ProductStaging
                {
                    ProductName = request.ProductName,
                    Data = dataJson,
                    DateCreated = DateTime.UtcNow
                };
                await _rubyContext.ProductStaging.AddAsync(newRecord);
            }

            await _rubyContext.SaveChangesAsync();

            // Deserialize the dataJson back to the request object
            ProductSetupDraftRequest deserializedData = JsonConvert.DeserializeObject<ProductSetupDraftRequest>(dataJson);

            // Prepare response data
            var responseData = new ProductStagingResponse
            {
                ProductName = request.ProductName,
                Data = deserializedData, // Use the deserialized request object
                DateCreated = DateTime.UtcNow
            };

            response.Success = true;
            response.ResponseMessage = "Product staging record saved or updated successfully.";
            response.Data = responseData;

            return response;
        }
        public async Task<BaseResponse<ProductStagingResponse>> GetDraftByProductName(string productName)
        {
            var response = new BaseResponse<ProductStagingResponse>();

            if (string.IsNullOrWhiteSpace(productName))
            {
                return new BaseResponse<ProductStagingResponse>
                {
                    Success = false,
                    ResponseMessage = "ProductName cannot be null or empty.",
                    StatusCode = HttpStatusCode.BadRequest
                };
            }

            // Convert product name to lowercase for case-insensitive comparison
            var lowerCaseProductName = productName.ToLower();

            // Fetch the draft product from the database
            var existingRecord = await _rubyContext.ProductStaging
                .Where(ps => ps.ProductName.ToLower() == lowerCaseProductName)
                .FirstOrDefaultAsync();

            if (existingRecord == null)
            {
                return new BaseResponse<ProductStagingResponse>
                {
                    Success = false,
                    ResponseMessage = "No draft product found with the specified ProductName.",
                    StatusCode = HttpStatusCode.NotFound
                };
            }

            ProductSetupDraftRequest requestData;
           
            requestData = JsonConvert.DeserializeObject<ProductSetupDraftRequest>(existingRecord.Data);
            
            

            // Create the response data
            var responseData = new ProductStagingResponse
            {
                ProductName = existingRecord.ProductName,
                Data = requestData,
                DateCreated = existingRecord.DateCreated
            };

            response.Success = true;
            response.ResponseMessage = "Draft product retrieved successfully.";
            response.Data = responseData;

            return response;
        }
        public async Task<BaseResponse<PaginatedProductResponse>> GetAllProduct(int pageNumber = 1, int pageSize = 10)
        {
            var query = _rubyContext.Products
                                     .AsNoTracking()
                                     .Select(p => new ProductResponse
                                     {
                                         Id = p.Id,
                                         ProductName = p.Name,
                                         ProductDescription = p.Description,
                                         ProductClassId = p.ProductClassId,
                                         Alias = p.Alias,
                                         Code = p.Code,
                                         Progress = p.PercentageProgress,
                                         CurrentStage = p.SetupStatus,
                                         ApprovalStatus = p.ApprovalStatus,
                                         ProductSetupStages = p.ProductSetupStages
                                     });

            // Create the paginated list
            var pagedProducts = await PagedList<ProductResponse>.ToPagedList(query, pageNumber, pageSize);

            // Create the paginated response DTO
            var paginatedProductResponse = new PaginatedProductResponse
            {
                PageNumber = pagedProducts.PageNumber,
                PageSize = pagedProducts.PageSize,
                TotalCount = pagedProducts.TotalCount,
                TotalPages = pagedProducts.TotalPages,
                HasPreviousPage = pagedProducts.HasPreviousPage,
                HasNextPage = pagedProducts.HasNextPage,
                Items = pagedProducts.ToList() // Or pagedProducts.Items if you have that property
            };

            // Create the response object
            var response = new BaseResponse<PaginatedProductResponse>
            {
                Success = true,
                ResponseMessage = "Products fetched successfully",
                Data = paginatedProductResponse,
                StatusCode = System.Net.HttpStatusCode.OK
            };

            return response;
        }
        public async Task<BaseResponse<PaginatedProductResponse>> GetAllProductByBusinessline(int businessId ,int pageNumber = 1, int pageSize = 10)
        {
            var query = _rubyContext.Products
                                     .AsNoTracking()
                                     .Where(d=>d.ProductClassId == businessId)
                                     .Select(p => new ProductResponse
                                     {
                                         Id = p.Id,
                                         ProductName = p.Name,
                                         ProductDescription = p.Description,
                                         ProductClassId = p.ProductClassId,
                                         Alias = p.Alias,
                                         Code = p.Code,
                                         Progress = p.PercentageProgress,
                                         CurrentStage = p.SetupStatus,
                                         ApprovalStatus = p.ApprovalStatus,
                                         ProductSetupStages = p.ProductSetupStages
                                     });

            // Create the paginated list
            var pagedProducts = await PagedList<ProductResponse>.ToPagedList(query, pageNumber, pageSize);

            // Create the paginated response DTO
            var paginatedProductResponse = new PaginatedProductResponse
            {
                PageNumber = pagedProducts.PageNumber,
                PageSize = pagedProducts.PageSize,
                TotalCount = pagedProducts.TotalCount,
                TotalPages = pagedProducts.TotalPages,
                HasPreviousPage = pagedProducts.HasPreviousPage,
                HasNextPage = pagedProducts.HasNextPage,
                Items = pagedProducts.ToList() // Or pagedProducts.Items if you have that property
            };

            // Create the response object
            var response = new BaseResponse<PaginatedProductResponse>
            {
                Success = true,
                ResponseMessage = "Products fetched successfully",
                Data = paginatedProductResponse,
                StatusCode = System.Net.HttpStatusCode.OK
            };

            return response;
        }
        public async Task<BaseResponse<ProductDetailResponse>> GetSingleProduct(int productId)
        {
            var product = await _rubyContext.Products
                .AsNoTracking()
                .Include(p => p.ProductSubjectTypes)
                .Include(p => p.ProductSubjectCategories)
                    .ThenInclude(c => c.ProductSubjectTypeAttributes)
                    .ThenInclude(attr => attr.DropdownMappings)
                .Include(p => p.ProductBaseSubjectTypeCovers)
                .Include(p => p.ProductAdditionalSubjectTypeCovers)
                .Include(p => p.ProductCostType)
                .Include(p => p.ProductCostOfInsurances)

                .Include(p => p.ProductAllowedPaymentFrequency)
                .Include(p => p.ProductPenalties)
                .Include(p => p.IncomeLedger)
                .Include(p => p.ExpenseLedgers)
                .Include(p => p.ReceivableLedgers)
                .Include(p => p.ProductFeeSetup)
                .Include(p => p.ProductCategorySelections)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                return new BaseResponse<ProductDetailResponse>
                {
                    Success = false,
                    ResponseMessage = "Product not found",
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
            }

            var baseIds = product.ProductBaseSubjectTypeCovers.Select(c => c.BaseCoverId).Distinct().ToList();
            var additionalIds = product.ProductAdditionalSubjectTypeCovers.Select(c => c.AdditionalCoverId).Distinct().ToList();
            var costTypeIds = product.ProductCostType.Select(c => c.CostTypeId).Distinct().ToList();
            var costOfInsuranceIds = product.ProductCostOfInsurances.Select(c => c.CollectionSourceId).Distinct().ToList();

            var objectOfInsuranceIds = product.ProductSubjectTypes.Select(d => d.SubjectTypeId).Distinct().ToList();

            var baseCoverNamesResponse = await RiderNamesById(baseIds);
            var additionalCoverNamesResponse = await RiderNamesById(additionalIds);
            var costTypeNamesResponse = await GetCostTypeNamesById(costTypeIds);
            var costOfInsuranceNameResponse = await GetCostOfInsuranceNamesById(costOfInsuranceIds);
            var objectOfInsuranceIdResponse = await GetObjectOfInsuranceNamesById(objectOfInsuranceIds);

            var baseCoverNames = baseCoverNamesResponse.Data;
            var additionalCoverNames = additionalCoverNamesResponse.Data;
            var costypeNames = costTypeNamesResponse.Data;
            var costOfInsuranceNames = costTypeNamesResponse.Data;
            var object0fInsuranceNames = objectOfInsuranceIdResponse.Data;


            var dropdownMappingResponse = await GetProductSubjectAttributeMappings(productId);
            var dropdownMappings = dropdownMappingResponse.Data ?? new List<ProductSubjectAttributeDropdownMappingResponse>();

            var categoryNames = await _rubyContext.LineOfBusinessAttributeCategories.ToListAsync();
            var categoryNamesDict = categoryNames.ToDictionary(c => c.Id, c => c.CategoryName);

            var productResponse = new ProductDetailResponse
            {
                Id = product.Id,
                ProductName = product.Name,
                ProductDescription = product.Description,
                ProductClassId = product.ProductClassId,
                VariantId = product.VariantId,
                RequiresGenericLocation = product.RequiresGenericLocation,
                Code = product.Code,
                Alias = product.Alias,
                ApprovalStatus = product.ApprovalStatus,
                RequiresUnderwriter = product.RequiresUnderWriter,
                ProductSetupStage = product.ProductSetupStages,
                RequiresUnderWriterAtBooking = product.RequireUnderWritingAtBooking,
                PaymentFrequencies = product.ProductAllowedPaymentFrequency.Select(pf => new PaymentFrequencyResponse
                {
                    PaymentFrequencyId = pf.Id,
                    PaymentFrequency = pf.PaymentFrequency
                }).ToList(),
                SubjectTypeIds = product.ProductSubjectTypes.Select(s => new SubjectResponse
                {
                    Id = s.Id,
                    SubjectTypeId = s.SubjectTypeId
                }).ToList(),
                BaseSubjectTypeCovers = product.ProductBaseSubjectTypeCovers.Select(bstc => new ProductBaseSubjectTypeCoverResponse
                {
                    Id = bstc.Id,
                    CoverName = baseCoverNames.ContainsKey(bstc.BaseCoverId) ? baseCoverNames[bstc.BaseCoverId] : "Unknown",
                    CoverStatus = bstc.CoverStatus,
                    BaseCoverId = bstc.BaseCoverId,
                    LimitType = bstc.LimitType,
                    RateTable = bstc.RateTable,
                    MaximumAmount = bstc.MaximumAmount,
                    RateApplied = bstc.RateApplied,
                    DisplayFormula = bstc.DisplayFormula,
                    isFixed = bstc.isFixed,
                    FixedPremium = bstc.FixedPremium
                }).ToList(),
                AdditionalSubjectTypeCovers = product.ProductAdditionalSubjectTypeCovers.Select(astc => new ProductAdditionalSubjectTypeCoverResponse
                {
                    Id = astc.Id,
                    CoverName = additionalCoverNames.ContainsKey(astc.AdditionalCoverId) ? additionalCoverNames[astc.AdditionalCoverId] : "Unknown",
                    CoverStatus = astc.CoverStatus,
                    AdditionalCoverId = astc.AdditionalCoverId,
                    LimitType = astc.LimitType,
                    RateTable = astc.RateTable,
                    MaximumAmount = astc.MaximumAmount,
                    RateApplied = astc.RateApplied,
                    DisplayFormula = astc.DisplayFormula,
                    isFixed = astc.isFixed,
                    FixedPremium = astc.FixedPremium

                }).ToList(),
                CostTypes = product.ProductCostType.Select(ct => new CostTypeResponse
                {
                    Id = ct.Id,
                    CostTypeName = costypeNames.ContainsKey(ct.CostTypeId) ? costypeNames[ct.CostTypeId] : "Unknown",
                    CostType = ct.CostTypeId,
                    Remark = ct.Remark
                }).ToList(),
                CostOfInsurances = product.ProductCostOfInsurances.Select(coi => new CostOfInsuranceResponse
                {
                    Id = coi.Id,
                    CostypeName = costypeNames.ContainsKey(coi.CostTypeId) ? costypeNames[coi.CostTypeId] : "Unknown",
                    CostTypeId = coi.CostTypeId,
                    Year = coi.Year,
                    TermValue = coi.TermValue,
                    Rate = coi.Rate,
                    CostBearer = coi.CostBearer,
                    CollectionSourceName = costOfInsuranceNames.ContainsKey(coi.CollectionSourceId) ? costOfInsuranceNames[coi.CollectionSourceId] : "Unknown",
                    CollectionSourceId = coi.CollectionSourceId,
                    DisplayFormula = coi.DisplayFormula,
                    CreditAccount = coi.CreditAccount,
                    DebitAccount = coi.DebitAccount,
                }).ToList(),
                ProductFeeSetupResponses = product.ProductFeeSetup.Select(p => new ProductFeeSetupResponse
                {
                    Id = p.Id,
                    name = p.FeeName,
                    value = p.PercentageValue,
                    description = p.Description
                }).ToList(),

                Penalty = product.ProductPenalties.Select(pen => new PenaltyResponse
                {
                    Id = pen.Id,
                    LowerLimit = pen.LowerLimit,
                    UpperLimit = pen.UpperLimit,
                    Penalty = pen.Penalty,
                }).ToList(),

                ProductFinances = new ProductFinancesResponse
                {
                    IncomeLedgers = product.IncomeLedger.Select(income => new IncomeResponse
                    {
                        Id = income.Id,
                        AccountNumber = income.AccountNumber,
                        Description = income.Description
                    }).ToList(),
                    ExpenseLedgers = product.ExpenseLedgers.Select(expense => new ExpenseLedgerResponse
                    {
                        Id = expense.Id,
                        AccountNumber = expense.AccountNumber,
                        Description = expense.Description
                    }).ToList(),
                    ReceivableLedgers = product.ReceivableLedgers.Select(receivable => new ReceivableLedgerResponse
                    {
                        Id = receivable.Id,
                        AccountNumber = receivable.AccountNumber,
                        Description = receivable.Description
                    }).ToList()
                },
                ProductGenericAttributeResponses = product.ProductCategorySelections.Select(lineOfBusinessCategory => new ProductGenericAttributeResponse
                {
                    CategoryId = lineOfBusinessCategory.CategoryId,
                    CategoryName = categoryNamesDict.ContainsKey(lineOfBusinessCategory.CategoryId)
                            ? categoryNamesDict[lineOfBusinessCategory.CategoryId]
                            : "Unknown"  
                }).ToList(),
                ProductSubjectCategories = product.ProductSubjectCategories.Select(category => new ProductSubjectCategoryResponse
                {
                    CategoryId = category.Id,
                    CategoryName = category.CategoryName,
                    ProductObjectOfInsurances = product.ProductSubjectTypes?
                        .Where(st => st.CategoryId == category.Id) // Ensure only related SubjectTypes are selected
                        .Select(st => new ProductObjectOfInsurance
                        {
                            SubjectTypeId = st.SubjectTypeId,
                            SubjectTypeName = object0fInsuranceNames.ContainsKey(st.SubjectTypeId)
                                ? object0fInsuranceNames[st.SubjectTypeId]
                                : "Unknown",
                        }).ToList() ?? new List<ProductObjectOfInsurance>(),

                    ProductSubjectAttributes = category.ProductSubjectTypeAttributes.Select(attr => new ProductSubjectResponse
                    {
                        Id = attr.Id,
                        SubjectAttributeName = attr.Name,
                        FieldType = attr.FieldType,
                        IsCompulsory = attr.IsRequired,
                        IsSumAssured = attr.IsSumInsured,
                        DataTypeId = attr.DataTypeId,
                        DataLength = attr.DataLength ?? 0,
                        SpecifyOperator = attr.SpecifyOperator,
                        ComparativeValueType = attr.ComparativeValueType,
                        ComparativeValue = attr.ComparativeValue,
                        RequiresUnderwriting = attr.RequiresUnderwriting,
                        RequiredAtQuoting = attr.AvailableAtQuotation,
                        HasParentChildOptions = attr.HasParentChildOptions,
                        GenericStateLgaStreet = attr.GenericStateLgaStreet,
                        DropdownValues = attr.DropdownValues?.Select(d => new DropdownValuesResponse { Value = d.Value }).ToList(),
                        ProductSubjectTypeId = product.ProductSubjectTypes
                            .Where(pst => pst.Id == attr.ProductSubjectTypeId)
                            .Select(pst => pst.SubjectTypeId)
                            .FirstOrDefault(),
                    }).ToList(),
                }).ToList(),


                DropdownMappings = dropdownMappings


            };



            return new BaseResponse<ProductDetailResponse>
            {
                Success = true,
                ResponseMessage = "Product details retrieved successfully",
                Data = productResponse,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        public async Task<BaseResponse<List<ProductSubjectAttributeDropdownMappingResponse>>> GetProductSubjectAttributeMappings(int productId)
        {
            var response = new BaseResponse<List<ProductSubjectAttributeDropdownMappingResponse>>();

            // Get all SubjectType IDs corresponding to the given ProductId
            var subjectTypeIds = await _rubyContext.ProductSubjectTypes
                .Where(st => st.ProductId == productId)
                .Select(st => st.Id)
                .ToListAsync();

            if (!subjectTypeIds.Any())
            {
                response.Success = false;
                response.ResponseMessage = $"No SubjectTypes found for ProductId {productId}.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Get all ProductSubjectAttributes linked to the SubjectTypeIds
            var productSubjectAttributes = await _rubyContext.ProductSubjectTypeAttributes
                .Where(attr => subjectTypeIds.Contains(attr.ProductSubjectTypeId))
                .ToListAsync();

            if (!productSubjectAttributes.Any())
            {
                response.Success = false;
                response.ResponseMessage = $"No ProductSubjectAttributes found for ProductId {productId}.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Create a dictionary for attribute lookup
            var attributeDictionary = productSubjectAttributes.ToDictionary(attr => attr.Id, attr => attr.Name);

            // Get ParentAttributeIds related to ProductSubjectAttributes
            var parentAttributeIds = productSubjectAttributes.Select(attr => attr.Id).ToList();

            // Get all dropdown mappings related to those ParentAttributeIds
            var dropdownMappings = await _rubyContext.ProductSubjectAttributeDropdownMappings
                .Where(mapping => parentAttributeIds.Contains(mapping.ParentAttributeId))
                .ToListAsync();

            if (!dropdownMappings.Any())
            {
                response.Success = false;
                response.ResponseMessage = "No mappings found for the given ProductId.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Create a list of mappings in the required structure
            var mappedData = dropdownMappings.Select(mapping => new ProductSubjectAttributeDropdownMappingResponse
            {
                ParentAttributeId = mapping.ParentAttributeId,
                ParentAttributeName = attributeDictionary.ContainsKey(mapping.ParentAttributeId) ? attributeDictionary[mapping.ParentAttributeId] : "Unknown",
                ParentValue = mapping.ParentValue,
                ChildAttributeId = mapping.ChildAttributeId,
                ChildAttributeName = attributeDictionary.ContainsKey(mapping.ChildAttributeId) ? attributeDictionary[mapping.ChildAttributeId] : "Unknown",
                ChildValues = mapping.ChildValues.Split(',').Select(value => new ChildValueDto { Value = value }).ToList()
            }).ToList();

            response.Success = true;
            response.ResponseMessage = "Mappings fetched successfully.";
            response.StatusCode = HttpStatusCode.OK;
            response.Data = mappedData;

            return response;
        }
        public async Task<BaseResponse<List<ProductCategorySubjectDataResponse>>> GetProductSubjectDataAsync(int productId)
        {
            // Step 1: Get the product from the database to check if it exists
            var product = await _rubyContext.Products.FirstOrDefaultAsync(d => d.Id == productId);
            if (product == null)
                return ResponseFactory.CreateError<List<ProductCategorySubjectDataResponse>>("Product Not Found", HttpStatusCode.NotFound);

            // Step 2: Get the related ProductSubjectCategory, ProductCategorySelections, and ProductSubjectTypes
            var productSubjectCategory = await _rubyContext.ProductSubjectCategories
                .Where(x => x.ProductId == productId)
                .FirstOrDefaultAsync();

            if (productSubjectCategory == null)
                return ResponseFactory.CreateError<List<ProductCategorySubjectDataResponse>>("Product Subject Category Not Found", HttpStatusCode.NotFound);

            // Step 3: Get the list of ProductCategorySelections
            var productCategorySelections = await _rubyContext.ProductCategorySelections
                .Where(x => x.ProductId == productId)
                .ToListAsync();

            // Step 4: Get the list of ProductSubjectTypes
            var productSubjectTypes = await _rubyContext.ProductSubjectTypes
                .Where(x => x.ProductId == productId && x.CategoryId == productSubjectCategory.Id)
                .ToListAsync();

            // Step 5: Get ProductSubjectTypeAttributes
            var productSubjectTypeAttributes = await _rubyContext.ProductSubjectTypeAttributes
                .Where(x => productSubjectTypes.Select(pst => pst.Id).Contains(x.ProductSubjectTypeId))
                .ToListAsync();

            // Step 6: Prepare the response model
            var response = new ProductCategorySubjectDataResponse
            {
                ProductId = productId,
                CategoryName = productSubjectCategory.CategoryName,
                ProductCategorySelections = productCategorySelections.Select(x => new ProductCategorySelectionData
                {
                    IsGeneric = x.IsGeneric,
                    CategoryId = x.CategoryId,
                    ProductId = x.ProductId
                }).ToList(),
                ProductSubjectTypes = productSubjectTypes.Select(x => new ProductSubjectTypeData
                {
                    SubjectTypeId = x.SubjectTypeId,
                    ProductId = x.ProductId,
                    CategoryId = x.CategoryId,
                    ProductSubjectTypeAttributes = productSubjectTypeAttributes
                        .Where(attr => attr.ProductSubjectTypeId == x.Id)
                        .Select(attr => new ProductSubjectTypeAttributeData
                        {
                            Name = attr.Name,
                            IsSumInsured = attr.IsSumInsured,
                            FieldType = attr.FieldType,
                            IsRequired = attr.IsRequired,
                            DataLength = attr.DataLength,
                            DataTypeId = attr.DataTypeId,
                            SpecifyOperator = attr.SpecifyOperator,
                            ComparativeValueType = attr.ComparativeValueType,
                            ComparativeValue = attr.ComparativeValue,
                            RequiresUnderwriting = attr.RequiresUnderwriting,
                            AvailableAtQuotation = attr.AvailableAtQuotation,
                            GenericStateLgaStreet = attr.GenericStateLgaStreet,
                            DropdownValues = attr.DropdownValues?.Select(dv => new DropdownValueData
                            {
                                Value = dv.Value
                            }).ToList()
                        }).ToList()
                }).ToList()
            };

            // Step 7: Return success response (fixed return statement)
            return ResponseFactory.GetSuccessResponse(new List<ProductCategorySubjectDataResponse> { response }, "Product retrieved");
        }


        #region Product Penalty Setup
        public async Task<BaseResponse<ProductPenaltyResponse>> ProductSetupPenalty(ProductPenaltyRequest request)
        {
            var response = new BaseResponse<ProductPenaltyResponse>();
            var penalties = new List<ProductPenalty>();


            var product = await _rubyContext.Products.FindAsync(request.ProductId);
            if (product == null)
            {

                response.Success = false;
                response.ResponseMessage = $"Product with ID {request.ProductId} does not exist.";
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                return response;

            }
            if (product.PercentageProgress < (int)ProductPercentageProcess.ProductSetupStage)
            {
                response.Success = false;
                response.ResponseMessage = "Product must complete the Product Setup stage before moving to Penalty setup.";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            foreach (var penalty in request.PenaltyRequests)
            {

                ProductPenalty products = new()
                {
                    ProductId = product.Id,
                    LowerLimit = penalty.LowerLimit,
                    UpperLimit = penalty.UpperLimit,
                    Penalty = penalty.Penalty,
                };
                penalties.Add(products);


            }

            await _rubyContext.ProductPenalties.AddRangeAsync(penalties);


            product.PercentageProgress = Math.Min(50, product.PercentageProgress +
                (int)ProductPercentageProcess.UnderWriterStage);
            product.ProductSetupStages = ProductStageOrder.UnderWriter.GetDescription();

            await _rubyContext.SaveChangesAsync();


            response.Success = true;
            response.ResponseMessage = "Penalties setup completed successfully";
            response.StatusCode = System.Net.HttpStatusCode.Created;
            return response;

        }
        public async Task<BaseResponse<ProductPenaltyResponse>> UpdateSetupPenalty(int penaltyId, PenaltyRequest request)
        {
            var response = new BaseResponse<ProductPenaltyResponse>();

            var existingPenalty = await _rubyContext.ProductPenalties
                .FirstOrDefaultAsync(d => d.Id == penaltyId);

            if (existingPenalty == null)
            {
                return new BaseResponse<ProductPenaltyResponse>
                {
                    Success = false,
                    ResponseMessage = $"Penalty with ID {penaltyId} does not exist.",
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
            }

            // Update the properties of the existing penalty
            existingPenalty.LowerLimit = request.LowerLimit;
            existingPenalty.UpperLimit = request.UpperLimit;
            existingPenalty.Penalty = request.Penalty;

            // Save changes to the database
            await _rubyContext.SaveChangesAsync();

            return new BaseResponse<ProductPenaltyResponse>
            {
                Success = true,
                ResponseMessage = "Penalty updated successfully.",
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        public async Task<BaseResponse<ProductPenaltyResponse>> DeleteSetupPenalty(int penaltyId)
        {
            var response = new BaseResponse<ProductPenaltyResponse>();

            // Fetch the existing penalty record
            var existingPenalty = await _rubyContext.ProductPenalties
                .FirstOrDefaultAsync(d => d.Id == penaltyId);

            if (existingPenalty == null)
            {
                return new BaseResponse<ProductPenaltyResponse>
                {
                    Success = false,
                    ResponseMessage = $"Penalty with ID {penaltyId} does not exist.",
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
            }

            // Remove the penalty record
            _rubyContext.ProductPenalties.Remove(existingPenalty);

            // Save changes to the database
            await _rubyContext.SaveChangesAsync();

            return new BaseResponse<ProductPenaltyResponse>
            {
                Success = true,
                ResponseMessage = "Penalty deleted successfully.",
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }

        #endregion

        #region Ledger Creation
        public async Task<BaseResponse<GenericNameResponse>> AddProductFinancialRecords(FinanceRequest request)
        {
            var response = new BaseResponse<GenericNameResponse>();

            // Validate Product ID
            var product = await _rubyContext.Products.FirstOrDefaultAsync(d => d.Id == request.ProductId);
            if (product == null)
            {
                response.Success = false;
                response.ResponseMessage = "Invalid Product ID.";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            // Check if product has reached the required stage
            if (product.PercentageProgress < (int)ProductPercentageProcess.UnderWriterStage)
            {
                response.Success = false;
                response.ResponseMessage = "Product must complete the penalty stage before moving to the Financial stage.";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            // Delete all existing financial records for the product
            _rubyContext.IncomeLedgers.RemoveRange(_rubyContext.IncomeLedgers.Where(l => l.ProductId == request.ProductId));
            _rubyContext.ExpenseLedgers.RemoveRange(_rubyContext.ExpenseLedgers.Where(l => l.ProductId == request.ProductId));
            _rubyContext.ReceivableLedgers.RemoveRange(_rubyContext.ReceivableLedgers.Where(l => l.ProductId == request.ProductId));
            _rubyContext.PayableLedgers.RemoveRange(_rubyContext.PayableLedgers.Where(l => l.ProductId == request.ProductId));

            await _rubyContext.SaveChangesAsync(); // Save deletion changes

            // Process each AccountRecord in the request
            foreach (var account in request.Accounts)
            {
                // Add new Income Ledger records
                foreach (var incomeRequest in account.IncomeLedgerRequests)
                {
                    if (string.IsNullOrEmpty(incomeRequest.AccountNumber))
                    {
                        response.Success = false;
                        response.ResponseMessage = "Invalid account number for one of the income accounts";
                        response.StatusCode = HttpStatusCode.BadRequest;
                        return response;
                    }

                    await _rubyContext.IncomeLedgers.AddAsync(new IncomeLedger
                    {
                        ProductId = request.ProductId,
                        AccountNumber = incomeRequest.AccountNumber,
                        Description = incomeRequest.Description,
                        AccountName = incomeRequest.AccountName
                    });
                }

                // Add new Expense Ledger records
                foreach (var expenseRequest in account.ExpenseLedgerRequests)
                {
                    if (string.IsNullOrEmpty(expenseRequest.AccountNumber))
                    {
                        response.Success = false;
                        response.ResponseMessage = "Invalid account number for one of the expense accounts";
                        response.StatusCode = HttpStatusCode.BadRequest;
                        return response;
                    }

                    await _rubyContext.ExpenseLedgers.AddAsync(new ExpenseLedger
                    {
                        ProductId = request.ProductId,
                        AccountNumber = expenseRequest.AccountNumber,
                        Description = expenseRequest.Description,
                        AccountName = expenseRequest.AccountName
                    });
                }

                // Add new Receivable Ledger records
                foreach (var receivableRequest in account.ReceivableLedgerRequests)
                {
                    if (string.IsNullOrEmpty(receivableRequest.AccountNumber))
                    {
                        response.Success = false;
                        response.ResponseMessage = "Invalid account number for one of the receivable accounts";
                        response.StatusCode = HttpStatusCode.BadRequest;
                        return response;
                    }

                    await _rubyContext.ReceivableLedgers.AddAsync(new ReceivableLedger
                    {
                        ProductId = request.ProductId,
                        AccountNumber = receivableRequest.AccountNumber,
                        Description = receivableRequest.Description,
                        AccountName = receivableRequest.AccountName,
                    });
                }

                foreach (var payableLedgerRequest in account.PayableLedgerRequests)
                {
                    if (string.IsNullOrEmpty(payableLedgerRequest.AccountNumber))
                    {
                        response.Success = false;
                        response.ResponseMessage = "Invalid account number for one of the receivable accounts";
                        response.StatusCode = HttpStatusCode.BadRequest;
                        return response;
                    }

                    await _rubyContext.PayableLedgers.AddAsync(new PayableLedger
                    {
                        ProductId = request.ProductId,
                        AccountNumber = payableLedgerRequest.AccountNumber,
                        Description = payableLedgerRequest.Description,
                        AccountName = payableLedgerRequest.AccountName,
                    });
                }


                
            }

            // Update the product progress stage if records were successfully processed
            product.PercentageProgress = Math.Min(70, product.PercentageProgress + (int)ProductPercentageProcess.AccountStage);
            product.ProductSetupStages = ProductStageOrder.FinancialControl.GetDescription();
            _rubyContext.Products.Update(product);

            
            // Save all changes in a single call to the database
            await _rubyContext.SaveChangesAsync();

            response.Success = true;
            response.ResponseMessage = "Financial records added or updated successfully.";
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<ProductFinancesResponse>> GetProductFinancialRecords(int productId)
        {
            var response = new BaseResponse<ProductFinancesResponse>();
            var product = await _rubyContext.Products
                .Include(p => p.IncomeLedger)
                .Include(p => p.ExpenseLedgers)
                .Include(p => p.ReceivableLedgers)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                response.Success = false;
                response.ResponseMessage = "";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            var FinancesResponse = new ProductFinancesResponse
            {


                IncomeLedgers = product.IncomeLedger.Select(ledger => new IncomeResponse
                {
                    Id = ledger.Id,
                    AccountNumber = ledger.AccountNumber,
                    Description = ledger.Description,
                }).ToList(),
                ExpenseLedgers = product.ExpenseLedgers.Select(ledger => new ExpenseLedgerResponse
                {
                    Id = ledger.Id,
                    AccountNumber = ledger.AccountNumber,
                    Description = ledger.Description,

                }).ToList(),
                ReceivableLedgers = product.ReceivableLedgers.Select(ledger => new ReceivableLedgerResponse
                {
                    Id = ledger.Id,
                    AccountNumber = ledger.AccountNumber,
                    Description = ledger.Description,

                }).ToList()
            };

            response.Success = true;
            response.ResponseMessage = "Product Financial detail retrieved successfully";
            response.Data = FinancesResponse;
            response.StatusCode = HttpStatusCode.OK;
            return response;

        }
        public async Task<BaseResponse<GenericNameResponse>> UpdateProductFinancialRecord(int productId, int ledgerId, string ledgerType, UpdateLedgerRequest request)
        {
            var response = new BaseResponse<GenericNameResponse>();

            // Validate Product ID
            var product = await _rubyContext.Products.FirstOrDefaultAsync(d => d.Id == productId);
            if (product == null)
            {
                response.Success = false;
                response.ResponseMessage = "Invalid Product ID.";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            // Find the ledger entry based on the ledger type
            if (ledgerType.Equals("Income", StringComparison.OrdinalIgnoreCase))
            {
                var ledger = await _rubyContext.IncomeLedgers.FirstOrDefaultAsync(l => l.Id == ledgerId && l.ProductId == productId);
                if (ledger == null)
                {
                    response.Success = false;
                    response.ResponseMessage = "Income Ledger record not found.";
                    response.StatusCode = HttpStatusCode.BadRequest;
                    return response;
                }

                // Update the ledger record
                ledger.AccountNumber = request.AccountNumber ?? ledger.AccountNumber;
                ledger.Description = request.Description ?? ledger.Description;

                _rubyContext.IncomeLedgers.Update(ledger);
            }
            else if (ledgerType.Equals("Expense", StringComparison.OrdinalIgnoreCase))
            {
                var ledger = await _rubyContext.ExpenseLedgers.FirstOrDefaultAsync(l => l.Id == ledgerId && l.ProductId == productId);
                if (ledger == null)
                {
                    response.Success = false;
                    response.ResponseMessage = "Expense Ledger record not found.";
                    response.StatusCode = HttpStatusCode.BadRequest;
                    return response;
                }

                // Update the ledger record
                ledger.AccountNumber = request.AccountNumber ?? ledger.AccountNumber;
                ledger.Description = request.Description ?? ledger.Description;

                _rubyContext.ExpenseLedgers.Update(ledger);
            }
            else if (ledgerType.Equals("Receivable", StringComparison.OrdinalIgnoreCase))
            {
                var ledger = await _rubyContext.ReceivableLedgers.FirstOrDefaultAsync(l => l.Id == ledgerId && l.ProductId == productId);
                if (ledger == null)
                {
                    response.Success = false;
                    response.ResponseMessage = "Receivable Ledger record not found.";
                    response.StatusCode = HttpStatusCode.BadRequest;
                    return response;
                }

                // Update the ledger record
                ledger.AccountNumber = request.AccountNumber ?? ledger.AccountNumber;
                ledger.Description = request.Description ?? ledger.Description;

                _rubyContext.ReceivableLedgers.Update(ledger);
            }
            else
            {
                response.Success = false;
                response.ResponseMessage = "Invalid ledger type specified.";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            // Save the changes to the database
            await _rubyContext.SaveChangesAsync();

            response.Success = true;
            response.ResponseMessage = $"{ledgerType} ledger record updated successfully.";
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<List<ProductCostOfInsuranceResponse>>> GetProductCostOfInsurance(int productId)
        {
            var response = new BaseResponse<List<ProductCostOfInsuranceResponse>>();

            var costOfInsurance = await _rubyContext.ProductCostOfInsurances

                .Where(d => d.ProductId == productId)
                .ToListAsync();

            if (!costOfInsurance.Any())
            {
                return ResponseFactory.CreateError<List<ProductCostOfInsuranceResponse>>("Product not found", HttpStatusCode.BadRequest);
            }

            // Get unique CostTypeIds from the list
            var costTypeIds = costOfInsurance.Select(c => c.CostTypeId).Distinct().ToList();

            var costTypeNamesResponse = await GetCostTypeNamesById(costTypeIds);


            var costTypeNames = costTypeNamesResponse.Data; // Now a Dictionary<int, string>

            var costOfInsuranceResponse = costOfInsurance.Select(d => new ProductCostOfInsuranceResponse
            {
                Year = d.Year,
                CollectionSource = d.CollectionSourceId,
                CostType = costTypeNames.TryGetValue(d.CostTypeId, out var name) ? name : "Unknown", // Lookup with TryGetValue
                CostBearer = d.CostBearer,
            }).ToList();

            return ResponseFactory.CreateSuccess(costOfInsuranceResponse, "Cost Of Insurance retrieved successfully.");
        }
        #endregion


        #region ProductPriceConfiguration
        public async Task<BaseResponse<GenericNameResponse>> ProductPricingAttributeConfiguration(List<CreateProductPricingConfigurationDto> request)
        {
            var validator = new ProductPricingConfigurationRequestValidator();
            var validationResultList = new List<string>();

            foreach (var item in request)
            {
                var validationResult = await validator.ValidateAsync(item);
                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(e => e.ErrorMessage);
                    validationResultList.Add(string.Join(", ", errorMessages));
                }
            }

            if (validationResultList.Any())
            {
                return ResponseFactory.CreateError<GenericNameResponse>(
                    string.Join(", ", validationResultList), HttpStatusCode.BadRequest);
            }

            var productPricings = new List<ProductPriceConfiguration>();
           
            foreach (var item in request)
            {
                var productPriceConfigurations = item.Attributes.Select(attr => new ProductPriceConfiguration
                {
                    CategoryId = item.CategoryId,
                    AttributeId = attr.AttributeId,
                    AttributeName = attr.AttributeName,
                    AffectPricing = attr.AffectPricing,
                    EffectType = attr.EffectType,
                    AffectRate = attr.AffectRate,
                    Affects = attr.CollectionSource,
                    CoverIds = attr.CoverIds ?? new List<int>(),
                   
                }).ToList();

                productPricings.AddRange(productPriceConfigurations);
            }

            await _rubyContext.ProductPriceConfigurations.AddRangeAsync(productPricings);
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Product Price Configuration Successfully setup", HttpStatusCode.Created);
        }
        public async Task<BaseResponse<List<ProductPricingConfigurationResponse>>> GetProductPricingConfigurations(int productId)
        {
            var product = await _rubyContext.Products.FirstOrDefaultAsync(d => d.Id == productId);
            if (product == null)
            {
                return ResponseFactory.CreateError<List<ProductPricingConfigurationResponse>>(
                    $"Product with ID {productId} not found.", HttpStatusCode.NotFound);
            }

            var category = await _rubyContext.ProductSubjectCategories
                                             .Include(c => c.ProductPriceConfigurations)
                                             .FirstOrDefaultAsync(c => c.Id == productId);
            if (category == null)
            {
                return ResponseFactory.CreateError<List<ProductPricingConfigurationResponse>>(
                    $"Category with ID {productId} not found.", HttpStatusCode.NotFound);
            }

            // Process each attribute and retrieve cover names
            var attributeResponses = await Task.WhenAll(category.ProductPriceConfigurations.Select(async attr =>
            {
                var coverNames = attr.CoverIds.Any()
                    ? (await Task.WhenAll(attr.CoverIds.Select(async coverId =>
                        (await _adminService.GetCoverNameById(coverId)).Data
                    ))).ToList()
                    : new List<string>();

                return new ProductPricingConfigurationAttributeResponse
                {
                    Id=attr.Id,
                    AttributeId = attr.AttributeId,
                    AttributeName = attr.AttributeName,
                    AffectPricing = attr.AffectPricing,
                    EffectType = attr.EffectType,
                    AffectRate = attr.AffectRate,
                    CollectionSource = attr.Affects,
                    CoverIds = attr.CoverIds, // Ensure this is a List<int>
                    CoverNames = coverNames   // New property: List of cover names
                };
            }));

            var response = new List<ProductPricingConfigurationResponse>
            {
                new ProductPricingConfigurationResponse
                {
                    CategoryId = category.Id,
                    CategoryName = category.CategoryName,
                    Attributes = attributeResponses.ToList()
                }
            };

            return ResponseFactory.CreateSuccess(response, "Price Configuration retrieved successfully.");
        }
        public async Task<BaseResponse<GenericNameResponse>> BulkUpdateProductPricingConfigurations(List<BulkUpdateProductPricingConfigurationDto> requests)
        {
            var categoryIds = requests.Select(r => r.CategoryId).Distinct().ToList();
            var categories = await _rubyContext.ProductSubjectCategories
                                               .Include(c => c.ProductPriceConfigurations)
                                               .Where(c => categoryIds.Contains(c.Id))
                                               .ToListAsync();

            if (!categories.Any())
            {
                return ResponseFactory.CreateError<GenericNameResponse>(
                    "No valid categories found for update.", HttpStatusCode.NotFound);
            }

            foreach (var request in requests)
            {
                var category = categories.FirstOrDefault(c => c.Id == request.CategoryId);
                if (category == null) continue; // Skip if category is not found

                foreach (var attribute in request.Attributes)
                {
                    var attributeConfig = category.ProductPriceConfigurations
                                                  .FirstOrDefault(attr => attr.AttributeId == attribute.AttributeId);

                    if (attributeConfig != null)
                    {
                        
                        attributeConfig.AttributeName = attribute.AttributeName;
                        attributeConfig.AffectPricing = attribute.AffectPricing;
                        attributeConfig.EffectType = attribute.EffectType;
                        attributeConfig.AffectRate = attribute.AffectRate;
                        attributeConfig.Affects = attribute.CollectionSource;
                        attributeConfig.CoverIds = attribute.CoverIds ?? new List<int>(); 
                    }
                    else
                    {
                        var newAttributeConfig = new ProductPriceConfiguration
                        {
                            CategoryId = request.CategoryId,
                            AttributeId = attribute.AttributeId,
                            AttributeName = attribute.AttributeName,
                            AffectPricing = attribute.AffectPricing,
                            EffectType = attribute.EffectType,
                            AffectRate = attribute.AffectRate,
                            Affects = attribute.CollectionSource,
                            CoverIds = attribute.CoverIds ?? new List<int>() 
                        };
                        category.ProductPriceConfigurations.Add(newAttributeConfig);
                    }
                }
            }

            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>(
                "Bulk update completed successfully.", HttpStatusCode.OK);
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetPriceConfigurationAllApprovingOffice()
        {
            var offices = await _adminService.GetAllFunctions();
            if (offices == null || offices.Data == null || !offices.Data.Any())
                return ResponseFactory.CreateError<List<GenericNameResponse>>("Approving offices not available", HttpStatusCode.NotFound);
            var officeResponse = offices.Data.Select(d=> new GenericNameResponse
            {
                Id = d.Id,
                Name =d.Caption
            }).ToList();

            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(officeResponse, "Approving offices retrieved successfully.");
        }
        public async Task<BaseResponse<GenericNameResponse>> SetApprovalForPriceConfiguration(List<PriceConfigurationApprovingOfficeInfo> request)
        {
            if (request == null || !request.Any())
            {
                return ResponseFactory.CreateError<GenericNameResponse>("No approving office price configurations provided.", HttpStatusCode.BadRequest);
            }

            var approvingOfficePriceConfigurations = new List<ProductApprovingOfficePriceConfiguration>();

            foreach (var officeInfo in request)
            {
                // Find the corresponding ProductPriceConfiguration by CategoryId (assuming CategoryId is unique in ProductPriceConfiguration)
                var productPriceConfig = await _rubyContext.ProductPriceConfigurations
                    .FirstOrDefaultAsync(p => p.Id == officeInfo.PriceConfigurationId);

                if (productPriceConfig == null)
                {
                    return ResponseFactory.CreateError<GenericNameResponse>(
                        $"ProductPriceConfiguration not found.", HttpStatusCode.NotFound);
                }

                var officePriceConfig = new ProductApprovingOfficePriceConfiguration
                {
                    ConfigurationId = productPriceConfig.Id,
                    FunctionId = officeInfo.OfficeId,
                    MinPricePercentage = officeInfo.MinPricePercentage,
                    MaxPricePercentage = officeInfo.MaxPricePercentage,
                    
                };

                approvingOfficePriceConfigurations.Add(officePriceConfig);
            }

            await _rubyContext.ProductApprovingOfficePriceConfigurations.AddRangeAsync(approvingOfficePriceConfigurations);
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Approving Office Price Configuration Successfully setup", HttpStatusCode.Created);
        }
        public async Task<BaseResponse<GenericNameResponse>> UpdateApprovalForPriceConfiguration(UpdatePriceConfigurationApprovingOfficeInfo request)
        {
            if (request == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>("No approving office price configuration provided.", HttpStatusCode.BadRequest);
            }

            // Find the existing configuration by PriceConfigurationId and OfficeId
            var existingConfig = await _rubyContext.ProductApprovingOfficePriceConfigurations
                .FirstOrDefaultAsync(p => p.Id == request.Id);

            if (existingConfig == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>(
                    $"Approving Office Price Configuration for PriceConfigurationId {request.Id} and OfficeId {request.OfficeId} not found.", HttpStatusCode.NotFound);
            }

            // Update properties conditionally based on request data
            if (request.MinPricePercentage != null)
            {
                existingConfig.MinPricePercentage = request.MinPricePercentage;
            }

            if (request.MaxPricePercentage != null)
            {
                existingConfig.MaxPricePercentage = request.MaxPricePercentage;
            }

            if (request.OfficeId != null)
            {
                existingConfig.FunctionId = request.OfficeId;
            }

            // Mark the entity as modified
            _rubyContext.ProductApprovingOfficePriceConfigurations.Update(existingConfig);

            // Save changes to the database
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Approving Office Price Configuration successfully updated.", HttpStatusCode.OK);
        }
        public async Task<BaseResponse<GenericNameResponse>> DeleteApprovalForPriceConfiguration(int approvingOfficeId)
        {
            // Find the existing configuration by PriceConfigurationId and OfficeId
            var existingConfig = await _rubyContext.ProductApprovingOfficePriceConfigurations
                .FirstOrDefaultAsync(p => p.Id == approvingOfficeId);

            if (existingConfig == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>(
                    $"Approving Office Price Configuration for PriceConfiguration not found.", HttpStatusCode.NotFound);
            }

           
            _rubyContext.ProductApprovingOfficePriceConfigurations.Remove(existingConfig);

            // Save changes to the database
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Approving Office Price Configuration successfully deleted.", HttpStatusCode.OK);
        }

        public async Task<BaseResponse<List<OfficePricingConfigurationResponse>>> GetAllApprovalForPriceConfigurations(int priceConfigurationId)
        {
            // Fetch associated approving office configurations for the given price configuration ID
            var approvingOfficeConfigs = await _rubyContext.ProductApprovingOfficePriceConfigurations
                .Where(d => d.ConfigurationId == priceConfigurationId)
                .ToListAsync();

            if (approvingOfficeConfigs == null || !approvingOfficeConfigs.Any())
            {
                return ResponseFactory.CreateError<List<OfficePricingConfigurationResponse>>("Offices Not Found", HttpStatusCode.NotFound);
            }

            var responseList = new List<OfficePricingConfigurationResponse>();

            foreach (var config in approvingOfficeConfigs)
            {
                var functionNameResult = await _adminService.GetFunctionById(config.FunctionId);
                var officeName = functionNameResult?.Data?.Caption;

                responseList.Add(new OfficePricingConfigurationResponse
                {
                    Id = config.Id,
                    MinimumRate = config.MinPricePercentage,
                    MaximumRate = config.MaxPricePercentage,
                    OfficeId = config.FunctionId,
                    OfficeName = officeName
                });
            }

            return ResponseFactory.GetSuccessResponse(responseList, "Approving Office Price Configuration retrieved successfully");
        }



        #endregion



        #region Account setup 
        public async Task<BaseResponse<List<AccountSearchResponse>>> GetAccounts()
        {
            var response = new BaseResponse<List<AccountSearchResponse>>();
            var apiBaseUrl = _configuration["Finance:search"];

            if (string.IsNullOrEmpty(apiBaseUrl))
            {
                response.Success = false;
                response.ResponseMessage = "";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }
            var token = await _financeHelper.GetAccessToken();

            if (string.IsNullOrEmpty(token))
            {
                return ResponseFactory.CreateError<List<AccountSearchResponse>>("Unable to retrieve approving office", HttpStatusCode.BadRequest);
            }

            var apiUrl = $"{apiBaseUrl}/accounts/search";
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var httpResponse = await httpClient.GetAsync(apiUrl);

            if (!httpResponse.IsSuccessStatusCode)
            {
                response.Success = false;
                response.ResponseMessage = $"API returned error: {httpResponse.StatusCode} - {httpResponse.ReasonPhrase}";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var search = System.Text.Json.JsonSerializer.Deserialize<AccountApiResponse<AccountSearchResponse>>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

            var searchData = search.Data.Select(s => new AccountSearchResponse()
            {
                AccountNumber = s.AccountNumber,
                Name = s.Name,
            }).ToList();

            response.Success = true;
            response.ResponseMessage = search.Message;
            response.Data = searchData;
            response.StatusCode = HttpStatusCode.OK;
            return response;

        }
        public async Task<BaseResponse<GenericNameResponse>> CreateAccountForCostOfInsurance(CostOfInsuranceAccountRequest requests)
        {

         
            var product = await _rubyContext.Products.FirstOrDefaultAsync(d=>d.Id == requests.ProductId);
            if(product == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>("Product Not Found", HttpStatusCode.NotFound);
            }
            var costOfInsurance = await _rubyContext.ProductCostOfInsurances.SingleOrDefaultAsync(d => d.ProductId == requests.ProductId);
            if (costOfInsurance == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>("Cost of Insurance Not Found",HttpStatusCode.Found);
            }

            costOfInsurance.DebitAccount = requests.DebitAccount;
            costOfInsurance.ExpenseAccountName = requests.DebitAccountName;
            costOfInsurance.CreditAccount = requests.CreditAccount;
            costOfInsurance.PayableAccountName = requests.CreditAccountName;

            product.ProductSetupStages = ProductStageOrder.FinancialControl.GetDescription();
            product.PercentageProgress = 75;

            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Cost Of Insurance Created", HttpStatusCode.Created);

        }

        #region Get Ledgers from Admin
        public async Task<BaseResponse<List<AccountResponse>>> ProductIncomeAccount(string searchKeyword = null)
        {
            AccountNameSearch searchType = AccountNameSearch.ProductIncomeAccount;
            string searchParam = searchType.GetDescription();
            var productIncome = await _financeService.FinanceAccountSetup(searchParam, searchKeyword);

            if (productIncome.Data == null)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>("No product income accounts returned.", HttpStatusCode.NotFound);
            }

            var productResponse = productIncome.Data.Select(d => new AccountResponse()
            {
                Name = d.Name,
                AccountNumber = d.AccountNumber
            }).ToList();

            return ResponseFactory.CreateSuccess<List<AccountResponse>>(productResponse, "Product Income Account successfully retrieved");
        }

        public async Task<BaseResponse<List<AccountResponse>>> CoinsuranceManagementFees(string searchKeyword = null)
        {
           
            AccountNameSearch searchType = AccountNameSearch.CoinsuranceManagementFee;
            string searchParam = searchType.GetDescription();

            var productIncome = await _financeService.FinanceAccountSetup(searchParam, searchKeyword);

            if (productIncome.Data == null)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>("No accounts returned.", HttpStatusCode.NotFound);
            }

            var productResponse = productIncome.Data.Select(d => new AccountResponse()
            {
                Name = d.Name,
                AccountNumber = d.AccountNumber
            }).ToList();



            return   ResponseFactory.CreateSuccess<List<AccountResponse>>(productResponse, "Coinsurance Management Fee successfully retrieved ");
        }
        public async Task<BaseResponse<List<AccountResponse>>> ReinsuranceCommissions(string searchKeyword = null)
        {
            // Get the enum description
            AccountNameSearch searchType = AccountNameSearch.ReinsuranceCommissions;
            string searchParam = searchType.GetDescription();

            var productIncome = await _financeService.FinanceAccountSetup(searchParam, searchKeyword);

            if (productIncome.Data == null)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>("No accounts returned.", HttpStatusCode.NotFound);
            }

            var productResponse = productIncome.Data.Select(d => new AccountResponse()
            {
                Name = d.Name,
                AccountNumber = d.AccountNumber
            }).ToList();



            return ResponseFactory.CreateSuccess<List<AccountResponse>>(productResponse, "Reinsurance Commission successfully retrieved ");
        }
        public async Task<BaseResponse<List<AccountResponse>>> CoinsurancePremiumOutward(string searchKeyword = null)
        {
           
            // Get the enum description
            AccountNameSearch searchType = AccountNameSearch.CoinsurancePremiumOutward;
            string searchParam = searchType.GetDescription();

            var productIncome = await _financeService.FinanceAccountSetup(searchParam, searchKeyword);

            if (productIncome.Data == null)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>("No accounts returned.", HttpStatusCode.NotFound);
            }

            var productResponse = productIncome.Data.Select(d => new AccountResponse()
            {
                Name = d.Name,
                AccountNumber = d.AccountNumber
            }).ToList();



            return ResponseFactory.CreateSuccess<List<AccountResponse>>(productResponse, "Coinsurance Premium Account successfully retrieved ");
        }
        public async Task<BaseResponse<List<AccountResponse>>> ReinsurancePremiumExpense(string searchKeyword = null)
        {
           
            // Get the enum description
            AccountNameSearch searchType = AccountNameSearch.ReinsurancePremiumExpense;
            string searchParam = searchType.GetDescription();

            var productIncome = await _financeService.FinanceAccountSetup(searchParam, searchKeyword);

            if (productIncome.Data == null)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>("No accounts returned.", HttpStatusCode.NotFound);
            }

            var productResponse = productIncome.Data.Select(d => new AccountResponse()
            {
                Name = d.Name,
                AccountNumber = d.AccountNumber
            }).ToList();



            return ResponseFactory.CreateSuccess<List<AccountResponse>>(productResponse, "Reinsurance PremiumExpense successfully retrieved ");
        }
        public async Task<BaseResponse<List<AccountResponse>>> BrokerCommissionsExpense(string searchKeyword = null)
        {
           
            // Get the enum description
            AccountNameSearch searchType = AccountNameSearch.BrokerCommissionExpense;
            string searchParam = searchType.GetDescription();

            var productIncome = await _financeService.FinanceAccountSetup(searchParam, searchKeyword);

            if (productIncome.Data == null)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>("No accounts returned.", HttpStatusCode.NotFound);
            }

            var productResponse = productIncome.Data.Select(d => new AccountResponse()
            {
                Name = d.Name,
                AccountNumber = d.AccountNumber
            }).ToList();



            return ResponseFactory.CreateSuccess<List<AccountResponse>>(productResponse, "Broker CommissionExpense Fee successfully retrieved ");
        }
        public async Task<BaseResponse<List<AccountResponse>>> CoinsuranceReceivableLedger(string searchKeyword = null)
        {
           

            // Get the enum description
            AccountNameSearch searchType = AccountNameSearch.CoinsuranceReceivableLedger;
            string searchParam = searchType.GetDescription();

            var productIncome = await _financeService.FinanceAccountSetup(searchParam, searchKeyword);

            if (productIncome.Data == null)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>("No accounts returned.", HttpStatusCode.NotFound);
            }

            var productResponse = productIncome.Data.Select(d => new AccountResponse()
            {
                Name = d.Name,
                AccountNumber = d.AccountNumber
            }).ToList();



            return ResponseFactory.CreateSuccess<List<AccountResponse>>(productResponse, "Coinsurance Receivable Ledger Fee successfully retrieved ");
        }
        public async Task<BaseResponse<List<AccountResponse>>> VATExpenseLedger(string searchKeyword = null)
        {

            AccountNameSearch searchType = AccountNameSearch.VATExpenseLedger;
            string searchParam = searchType.GetDescription();

            var productIncome = await _financeService.FinanceAccountSetup(searchParam, searchKeyword);

            if (productIncome.Data == null)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>("No accounts returned.", HttpStatusCode.NotFound);
            }

            var productResponse = productIncome.Data.Select(d => new AccountResponse()
            {
                Name = d.Name,
                AccountNumber = d.AccountNumber
            }).ToList();



            return ResponseFactory.CreateSuccess<List<AccountResponse>>(productResponse, "Vat Expense Ledger successfully retrieved ");
        }

        public async Task<BaseResponse<List<AccountResponse>>> WHTPayableLedger(string searchKeyword = null)
        {

            AccountNameSearch searchType = AccountNameSearch.WithHoldingPayableLedger;
            string searchParam = searchType.GetDescription();

            var productIncome = await _financeService.FinanceAccountSetup(searchParam, searchKeyword);

            if (productIncome.Data == null)
            {
                return ResponseFactory.CreateError<List<AccountResponse>>("No accounts returned.", HttpStatusCode.NotFound);
            }

            var productResponse = productIncome.Data.Select(d => new AccountResponse()
            {
                Name = d.Name,
                AccountNumber = d.AccountNumber
            }).ToList();



            return ResponseFactory.CreateSuccess<List<AccountResponse>>(productResponse, "Vat Expense Ledger successfully retrieved ");
        }

        #endregion

        public async Task<BaseResponse<List<string>>> GetAllDataType()
        {
            var response = new BaseResponse<List<string>>();

            var getDataType = Enum.GetValues(typeof(FieldType))
                .Cast<FieldType>().Select(d=>d.ToString()).ToList();
                
            response.Success = true;
            response.ResponseMessage = "DataType retrieved successfully";
            response.Data = getDataType;
            response.StatusCode = HttpStatusCode.OK;
            return response;


        }

        #region Location Setup
       
        public async Task<BaseResponse<GenericNameResponse>> CreateLocationSetup(LocationSetupRequest request)
        {
            var response = new BaseResponse<GenericNameResponse>();

            if (request.RequireSpecificGenericLocation)
            {
                // Validate FieldType
                if (!Enum.TryParse(request.DataType, out FieldType fieldType))
                {
                    response.Success = false;
                    response.ResponseMessage = $"Invalid DataType: {request.DataType}";
                    return response;
                }


                // Check if the location already exists
                var existingLocation = await _rubyContext.ProductGenericLocations
                    .FirstOrDefaultAsync(l => l.Name.ToLower() == request.LocationName.ToLower() && l.ProductId == request.ProductId);

                if (existingLocation == null)
                {
                    // Create a new location if it doesn't exist
                    existingLocation = new ProductGenericLocation
                    {
                        ProductId = request.ProductId,
                        Name = request.LocationName,
                        RequiredGenericLocation = request.RequireGenericLocation,
                        RequiredSpecificGenericLocation = request.RequireSpecificGenericLocation

                    };
                    _rubyContext.ProductGenericLocations.Add(existingLocation);
                    await _rubyContext.SaveChangesAsync();
                }

                // Check if the field already exists for the location
                var existingField = await _rubyContext.ProductGenericLocationFields
                    .FirstOrDefaultAsync(f => f.GenericLocationId == existingLocation.Id && f.FieldName.ToLower() == request.AttributeName.ToLower());

                if (existingField != null)
                {
                    response.Success = false;
                    response.ResponseMessage = $"Field '{request.AttributeName}' already exists for location '{request.LocationName}'.";
                    response.StatusCode = HttpStatusCode.Conflict;
                    return response;
                }

                // Create the new field
                var locationField = new ProductGenericLocationField
                {
                    GenericLocationId = existingLocation.Id,
                    FieldName = request.AttributeName,
                    FieldType = fieldType,
                    IsRequired = request.IsRequired
                };
                _rubyContext.ProductGenericLocationFields.Add(locationField);
                await _rubyContext.SaveChangesAsync();

                // If the field is a Dropdown, add dropdown options
                if (fieldType == FieldType.Dropdown && request.DropdownValues != null && request.DropdownValues.Any())
                {
                    var dropdownOptions = request.DropdownValues.Select(value => new ProductGenericLocationDropdownOption
                    {
                        LocationFieldId = locationField.Id,
                        Value = value
                    });
                    _rubyContext.ProductGenericLocationDropdownOptions.AddRange(dropdownOptions);
                    await _rubyContext.SaveChangesAsync();
                }

                response.Success = true;
                response.ResponseMessage = "Generic Location Field Created Successfully";
                response.StatusCode = HttpStatusCode.Created;
                return response;
            }
            else
            {
                // Check if the location already exists
                var existingLocation = await _rubyContext.ProductGenericLocations
                    .FirstOrDefaultAsync(l => l.Name.ToLower() == request.LocationName.ToLower() && l.ProductId == request.ProductId);

                if (existingLocation == null)
                {
                    // Create a new location if it doesn't exist
                    existingLocation = new ProductGenericLocation
                    {
                        ProductId = request.ProductId,
                        Name = request.LocationName,
                        RequiredGenericLocation = request.RequireGenericLocation,
                        RequiredSpecificGenericLocation = request.RequireSpecificGenericLocation

                    };
                    _rubyContext.ProductGenericLocations.Add(existingLocation);
                    await _rubyContext.SaveChangesAsync();
                }

                response.Success = true;
                response.ResponseMessage = "Generic Location Field Created Successfully";
                response.StatusCode = HttpStatusCode.Created;
                return response;
            }
          
          
        }
        public async Task<BaseResponse<List<LocationFieldResponses>>> GetAllLocations(int productId)
        {
            var response = new BaseResponse<List<LocationFieldResponses>>();

            var locations = await _rubyContext.ProductGenericLocations
                .Include(l => l.ProductGenericLocationFields)
                .ThenInclude(l=>l.ProductGenericLocationDropdownOptions)
                .Where(d=>d.ProductId == productId)
                .ToListAsync();

            if (locations == null || !locations.Any())
            {
                response.Success = false;
                response.ResponseMessage = "No locations found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            var locationResponses = locations.Select(l => new LocationFieldResponses
            {
                LocationId =l.Id,
                LocationName = l.Name,
                ProductId = l.ProductId,
                RequiredGenericLocation = l.RequiredGenericLocation,
                RequiredSpecificGenericLocation = l.RequiredSpecificGenericLocation,
                Attributes = l.ProductGenericLocationFields.Select(f => new LocationFieldResponse
                {
                    AttributeId = f.Id,
                    AttributeName = f.FieldName,
                    AttributeType = f.FieldType.ToString(),
                    IsRequired = f.IsRequired,
                    DropdownOptions = f.ProductGenericLocationDropdownOptions?.Select(option => option.Value).ToList()
                }).ToList()
            }).ToList();

            response.Success = true;
            response.ResponseMessage = "Locations retrieved successfully.";
            response.Data = locationResponses;
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<string>> UpdateLocationSetup(UpdateLocationRequest request)
        {
            var response = new BaseResponse<string>();

            // Find the location by product ID and location name
            var existingLocation = await _rubyContext.ProductGenericLocations
                .FirstOrDefaultAsync(l => l.Name.ToLower() == request.LocationName.ToLower() && l.ProductId == request.ProductId);

            if (existingLocation == null)
            {
                response.Success = false;
                response.ResponseMessage = $"Location '{request.LocationName}' not found for product ID '{request.ProductId}'.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Update location properties
            existingLocation.RequiredGenericLocation = request.RequireGenericLocation;
            existingLocation.RequiredSpecificGenericLocation = request.RequireSpecificGenericLocation;
            _rubyContext.ProductGenericLocations.Update(existingLocation);

            if (request.RequireSpecificGenericLocation)
            {
                // Validate FieldType
                if (!Enum.TryParse(request.DataType, out FieldType fieldType))
                {
                    response.Success = false;
                    response.ResponseMessage = $"Invalid DataType: {request.DataType}";
                    return response;
                }

                // Find the field by name
                var existingField = await _rubyContext.ProductGenericLocationFields
                    .FirstOrDefaultAsync(f => f.GenericLocationId == existingLocation.Id && f.FieldName.ToLower() == request.AttributeName.ToLower());

                if (existingField != null)
                {
                    // Update field properties
                    existingField.FieldType = fieldType;
                    existingField.IsRequired = request.IsRequired;
                    _rubyContext.ProductGenericLocationFields.Update(existingField);

                    // Update dropdown values if the field is a Dropdown
                    if (fieldType == FieldType.Dropdown && request.DropdownValues != null)
                    {
                        // Delete existing dropdown options
                        var existingDropdownOptions = await _rubyContext.ProductGenericLocationDropdownOptions
                            .Where(o => o.LocationFieldId == existingField.Id)
                            .ToListAsync();

                        _rubyContext.ProductGenericLocationDropdownOptions.RemoveRange(existingDropdownOptions);

                        // Add new dropdown options
                        var newDropdownOptions = request.DropdownValues.Select(value => new ProductGenericLocationDropdownOption
                        {
                            LocationFieldId = existingField.Id,
                            Value = value
                        });
                        _rubyContext.ProductGenericLocationDropdownOptions.AddRange(newDropdownOptions);
                    }
                }
                else
                {
                    // If field doesn't exist, create it
                    var newField = new ProductGenericLocationField
                    {
                        GenericLocationId = existingLocation.Id,
                        FieldName = request.AttributeName,
                        FieldType = fieldType,
                        IsRequired = request.IsRequired
                    };
                    _rubyContext.ProductGenericLocationFields.Add(newField);

                    // Add dropdown values if applicable
                    if (fieldType == FieldType.Dropdown && request.DropdownValues != null && request.DropdownValues.Any())
                    {
                        var dropdownOptions = request.DropdownValues.Select(value => new ProductGenericLocationDropdownOption
                        {
                            LocationFieldId = newField.Id,
                            Value = value
                        });
                        _rubyContext.ProductGenericLocationDropdownOptions.AddRange(dropdownOptions);
                    }
                }
            }

            await _rubyContext.SaveChangesAsync();

            response.Success = true;
            response.ResponseMessage = "Location setup updated successfully.";
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<string>> DeleteLocationSetup(DeleteLocationRequest request)
        {
            var response = new BaseResponse<string>();

            // Find the location by product ID and location name
            var location = await _rubyContext.ProductGenericLocations
                .FirstOrDefaultAsync(l => l.Name.ToLower() == request.locationName.ToLower() && l.ProductId == request.productId);

            if (location == null)
            {
                response.Success = false;
                response.ResponseMessage = $"Location '{request.locationName}' not found for product ID '{request.productId}'.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            if (request.requireSpecificGenericLocation)
            {
                // Get all associated fields for the specific location
                var locationFields = await _rubyContext.ProductGenericLocationFields
                    .Where(f => f.GenericLocationId == location.Id)
                    .ToListAsync();

                if (locationFields.Any())
                {
                    // Delete dropdown options associated with the fields (if applicable)
                    var dropdownOptions = await _rubyContext.ProductGenericLocationDropdownOptions
                        .Where(o => locationFields.Select(f => f.Id).Contains(o.LocationFieldId))
                        .ToListAsync();

                    if (dropdownOptions.Any())
                    {
                        _rubyContext.ProductGenericLocationDropdownOptions.RemoveRange(dropdownOptions);
                    }

                    // Delete the fields
                    _rubyContext.ProductGenericLocationFields.RemoveRange(locationFields);
                }
            }

            // Delete the location
            _rubyContext.ProductGenericLocations.Remove(location);
            await _rubyContext.SaveChangesAsync();

            response.Success = true;
            response.ResponseMessage = $"Location '{request.locationName}' and its associated data have been deleted successfully.";
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }

        #endregion

       

        #region Approval setup 
        public async Task<BaseResponse<ProductResponse>> ApproveProduct(int productId)
        {
            // Fetch the product
            var product = await _rubyContext.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (product == null)
            {
                return ResponseFactory.CreateError<ProductResponse>("Sorry, we cannot retrieve Product Information with the specified Id.", HttpStatusCode.BadRequest);
            }

            
                    product.PercentageProgress = 100;
                    product.IsApproved = true;
                    product.CanBookPolicy = true;
                    product.PercentageProgress = 100;
                    product.ApprovalStatus = ApprovalStatusEnum.Completed.GetDescription();
                    product.SetupStatus = ApprovalStatusEnum.Completed.GetDescription();

                    var policyPremiumAccount = new AccountRequestDto
                    {
                        CurrencyId = configOptions.Value.FinanceCurrencyId,
                        Name = $"{product.Name}{GeneralGlobalValues.ProductExpenseSurfix}",
                        Remark = $"{product.Name}{GeneralGlobalValues.ProductExpenseSurfix}",
                        SetupName = "Product Credit Expense",
                        ControlAccountId = configOptions.Value.ControlAccountId,
                    };

                    // Create product expense account
                    var expenseAccount = await _financeSetup.CreateLedger(policyPremiumAccount);
                    if (expenseAccount.Status != RequestExecutionStatus.Successful.ToString())
                    {
                        return ResponseFactory.CreateError<ProductResponse>("Unable to create product account", HttpStatusCode.BadRequest);
                    }

                    if (expenseAccount.Data == null || expenseAccount.Data.AccountNumber == null)
                    {
                        return ResponseFactory.CreateError<ProductResponse>("Invalid response received from finance service.", HttpStatusCode.BadRequest);
                    }

                    product.IncomeAccount = expenseAccount.Data.AccountNumber;

                    policyPremiumAccount.Name = $"{product.Name}{GeneralGlobalValues.ProductIncomeSurfix}";
                    policyPremiumAccount.Remark = $"{product.Name}{GeneralGlobalValues.ProductIncomeSurfix}";
                    policyPremiumAccount.SetupName = "Product Income Account";

                    // Create product payable account
                    var payableAccount = await _financeSetup.CreateLedger(policyPremiumAccount);
                    if (payableAccount.Status != RequestExecutionStatus.Successful.ToString())
                    {
                        return ResponseFactory.CreateError<ProductResponse>("Unable to create product account", HttpStatusCode.BadRequest);
                    }


                    if (payableAccount.Data == null || payableAccount.Data.AccountNumber == null)
                    {
                        return ResponseFactory.CreateError<ProductResponse>("Invalid response received from finance service.", HttpStatusCode.BadRequest);
                    }

                    product.PremiumAccount = payableAccount.Data.AccountNumber;
                

                // Finalize product approval
                product.ApprovalStatus = ProductStatuses.Complete.ToString();
                product.IsCurrentlyRejected = false;

                // Update product in the database
                _rubyContext.Products.Update(product);
                await _rubyContext.SaveChangesAsync();

                // Send email
                //var teamEmails = await ProductEmails();
                //_productEmailService.SendProductSetupEmail(product, EmailFilesDefinition.PRODUCT_SETUP_TEMPLATE, EmailSubjectsKey.PRODUCT_TEAM_SETUP_COMPLETION, teamEmails, currentStage.Name);
            

            // Return success response
            return ResponseFactory.CreateSuccessWithOutData<ProductResponse>("The Approval to this Product has been successfully updated.", HttpStatusCode.OK);
        }



        public async Task<BaseResponse<object>> RejectProduct(ProductRejectionRequest request)
        {
            
            var product = await _rubyContext.Products.FirstOrDefaultAsync(x => x.Id == request.ProductId);
            if (product != null)
            {
                ProductDisapproval productDisapproval = new()
                {
                    ProductId = product.Id,
                    ActionUserId = UserClaims(),
                    DateCommented = DateTime.UtcNow,
                    Reason = request.Reason,
                    
                };
                await _rubyContext.ProductDisapprovals.AddAsync(productDisapproval);

                ProductStageAudit productStageAudit = new()
                {
                    DateCreated = DateTime.UtcNow,
                    ProductId = product.Id,
                    Status = ProductStatuses.Rejected.GetDescription(),
                    UserId= UserClaims(),
                };
                await _rubyContext.ProductStageAudits.AddAsync(productStageAudit);

                product.PercentageProgress = 50;
                product.ProductSetupStages = product.ProductSetupStages;
                product.ApprovalStatus = ProductStageOrder.ProductTeam.GetDescription();
                product.IsCurrentlyRejected = true;

                _rubyContext.Update(product);
                await _rubyContext.SaveChangesAsync();

                //var emails = await GetAllProductEmails();
                //_productEmailService.ProductRejectionEmail(product, EmailFilesDefinition.PRODUCT_SETUP_REJECTION_TEMPLATE, EmailSubjectsKey.PRODUCT_REJECTION, emails, currentStage.Name, request.Reason);

                return ResponseFactory.CreateSuccessWithOutData<object>("The Product have been successfully rejected and routed to the Product Team.",HttpStatusCode.OK);
                
            }

            return ResponseFactory.CreateError<object>("Unable to successfully reject and route to the Product Team, kindly try again later.",HttpStatusCode.BadRequest);
            
        }
        #endregion


        #endregion

        #region Threshold
        public async Task<BaseResponse<GenericNameResponse>> CreateThreshold(ThresholdRequestdto request)
        {
                var product = await _rubyContext.Products.FindAsync(request.ProductId);
                if (product == null)
                    return ResponseFactory.CreateError<GenericNameResponse>("Product not found.", HttpStatusCode.NotFound);

                var threshold = new ProductThreshold
                {
                    ProductId = request.ProductId,
                    Value = request.Value,
                };

                _rubyContext.ProductThresholds.Add(threshold);
                await _rubyContext.SaveChangesAsync();

                 return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Threshold created successfully.", HttpStatusCode.Created);
               
        }
        public async Task<BaseResponse<GenericNameResponse>> CreateProductDeductible(ProductDeductibleDto request)
        {
            var product = await _rubyContext.Products.FindAsync(request.ProductId);
            if (product == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product not found.", HttpStatusCode.NotFound);

            if (request.ProductDeductibleRequests == null || !request.ProductDeductibleRequests.Any())
                return ResponseFactory.CreateError<GenericNameResponse>("No deductible data provided.", HttpStatusCode.BadRequest);

            var deductibles = request.ProductDeductibleRequests.Select(d => new ProductDeductible()
            {
                InsuredSubject = d.InsuredSubject,
                DeductibleRate = d.DeductibleRate,
                ApplicationType = d.ApplicationType,
                FixedAmount = d.FixedAmount,
                ProductId = request.ProductId,
            }).ToList();

            using var transaction = await _rubyContext.Database.BeginTransactionAsync();
            try
            {
                _rubyContext.ProductDeductibles.AddRange(deductibles);
                await _rubyContext.SaveChangesAsync();
                await transaction.CommitAsync();

                return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Threshold created successfully.", HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return ResponseFactory.CreateError<GenericNameResponse>("An error occurred while creating the deductible.", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<GenericNameResponse>> CreateProductDurationRate(ProductDurationRatedto request)
        {
            var product = await _rubyContext.Products.FindAsync(request.ProductId);
            if (product == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product not found.", HttpStatusCode.NotFound);

            if (request.ProductDurationRatedRequest == null || !request.ProductDurationRatedRequest.Any())
                return ResponseFactory.CreateError<GenericNameResponse>("Product Duration Rate details are required.", HttpStatusCode.BadRequest);

            // Step 2: Create associated ProductDurationDetail records
            var productDurationDetails = request.ProductDurationRatedRequest.Select(d => new ProductDurationDetail
            {
                ProductId = product.Id,
                DurationInDays = d.DurationInDays,
                Rate = d.Rate,
                AppliedFor = d.AppliedFor
            }).ToList();

            _rubyContext.ProductDurationDetails.AddRange(productDurationDetails);

            // Step 3: Save all changes
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Product duration rate and details created successfully.", HttpStatusCode.Created);
        }

        public async Task<BaseResponse<List<ThresholdResponseDto>>> GetAllProductThresholds(int productId)
        {
            var thresholds = await _rubyContext.ProductThresholds
                .Where(d=>d.ProductId == productId)
                .Select(pt => new ThresholdResponseDto
                {
                    Id = pt.Id,
                    ProductId = pt.ProductId,
                    Value = pt.Value
                })
                .ToListAsync();

            if (thresholds == null || !thresholds.Any())
                return ResponseFactory.CreateError<List<ThresholdResponseDto>>("No thresholds found.", HttpStatusCode.NotFound);

            return ResponseFactory.GetSuccessResponse<List<ThresholdResponseDto>>(thresholds, "Thresholds retrieved successfully");
        }
        public async Task<BaseResponse<ThresholdResponseDto>> GetProductThresholdById(int id)
        {
            var threshold = await _rubyContext.ProductThresholds
                .Where(pt => pt.Id == id)
                .Select(pt => new ThresholdResponseDto
                {
                    Id = pt.Id,
                    ProductId = pt.ProductId,
                    Value = pt.Value
                })
                .FirstOrDefaultAsync();

            if (threshold == null)
                return ResponseFactory.CreateError<ThresholdResponseDto>("Product Threshold not found.", HttpStatusCode.NotFound);

            return ResponseFactory.GetSuccessResponse<ThresholdResponseDto>(threshold, "Thresholds retrieved successfully");
        }
        public async Task<BaseResponse<List<ProductDeductibleResponseDto>>> GetAllProductDeductibles(int productId)
        {
            var deductibles = await _rubyContext.ProductDeductibles
                .Where(d=>d.ProductId == productId)
                .Select(pd => new ProductDeductibleResponseDto
                {
                    Id = pd.Id,
                    ProductId = pd.ProductId,
                    InsuredSubject = pd.InsuredSubject,
                    DeductibleRate = pd.DeductibleRate,
                    ApplicationType = pd.ApplicationType,
                    FixedAmount = pd.FixedAmount
                })
                .ToListAsync();

            if (deductibles == null || !deductibles.Any())
                return ResponseFactory.CreateError<List<ProductDeductibleResponseDto>>("No deductibles found.", HttpStatusCode.NotFound);

            return ResponseFactory.GetSuccessResponse<List<ProductDeductibleResponseDto>>(deductibles, "Deductibles retrieved successfully");
        }
        public async Task<BaseResponse<ProductDeductibleResponseDto>> GetProductDeductibleById(int deductibleId)
        {
            var deductible = await _rubyContext.ProductDeductibles
                .Where(pd => pd.Id == deductibleId)
                .Select(pd => new ProductDeductibleResponseDto
                {
                    Id = pd.Id,
                    ProductId = pd.ProductId,
                    InsuredSubject = pd.InsuredSubject,
                    DeductibleRate = pd.DeductibleRate,
                    ApplicationType = pd.ApplicationType,
                    FixedAmount = pd.FixedAmount
                })
                .FirstOrDefaultAsync();

            if (deductible == null)
                return ResponseFactory.CreateError<ProductDeductibleResponseDto>("Product Deductible not found.", HttpStatusCode.NotFound);

            return ResponseFactory.GetSuccessResponse(deductible, "Deductible retrieved successfully");
        }

        public async Task<BaseResponse<List<ProductDurationRateResponseDto>>> GetAllProductDurationRates(int productId)
        {
            var productDurationDetails = await _rubyContext.ProductDurationDetails
                .Where(pdd => pdd.ProductId == productId)
                .Select(pdd => new ProductDurationRateResponseDto
                {
                    Id = pdd.Id,
                    ProductId = pdd.ProductId,
                    DurationInDays = pdd.DurationInDays,
                    Rate = pdd.Rate,
                    AppliedFor = pdd.AppliedFor
                }).ToListAsync(); // Make sure to use ToListAsync

            if (productDurationDetails == null || !productDurationDetails.Any())
                return ResponseFactory.CreateError<List<ProductDurationRateResponseDto>>("No product duration rates found.", HttpStatusCode.NotFound);

            return ResponseFactory.GetSuccessResponse(productDurationDetails, "Product Duration Rates retrieved successfully.");
        }

        public async Task<BaseResponse<ProductDurationRateResponseDto>> GetProductDurationRateById(int rateId)
        {
            var productDurationRate = await _rubyContext.ProductDurationDetails
                .Where(pdr => pdr.Id == rateId)
                .Select(pdr => new ProductDurationRateResponseDto
                {
                    Id = pdr.Id,
                    ProductId = pdr.ProductId,
                    DurationInDays = pdr.DurationInDays,
                    Rate = pdr.Rate,
                    AppliedFor = pdr.AppliedFor
                })
                .FirstOrDefaultAsync(); 

            if (productDurationRate == null)
                return ResponseFactory.CreateError<ProductDurationRateResponseDto>("Product Duration Rate not found.", HttpStatusCode.NotFound);

            return ResponseFactory.GetSuccessResponse(productDurationRate, "Product Duration Rate retrieved successfully");
        }

        public async Task<BaseResponse<GenericNameResponse>> UpdateProductThreshold(int id, ThresholdRequestdto request)
        {
            var threshold = await _rubyContext.ProductThresholds.FindAsync(id);
            if (threshold == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product Threshold not found.", HttpStatusCode.NotFound);

            // Update the necessary fields
            threshold.Value = request.Value;
            threshold.ProductId = request.ProductId;

            try
            {
                await _rubyContext.SaveChangesAsync();
                return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Product Threshold updated successfully.", HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<GenericNameResponse>("An error occurred while updating the Product Threshold.", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<GenericNameResponse>> DeleteThreshold(int thresholdId)
        {
            var threshold = await _rubyContext.ProductThresholds.FindAsync(thresholdId);
            if (threshold == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product Threshold not found.", HttpStatusCode.NotFound);

            _rubyContext.ProductThresholds.Remove(threshold);
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Product threshold deleted successfully.", HttpStatusCode.OK);
        }

        public async Task<BaseResponse<GenericNameResponse>> UpdateProductDeductible(int id, ProductDeductibleRequestDto request)
        {
            var deductible = await _rubyContext.ProductDeductibles.FindAsync(id);
            if (deductible == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product Deductible not found.", HttpStatusCode.NotFound);

            // Update the necessary fields
            deductible.InsuredSubject = request.InsuredSubject;
            deductible.DeductibleRate = request.DeductibleRate;
            deductible.ApplicationType = request.ApplicationType;
            deductible.FixedAmount = request.FixedAmount;
            deductible.ProductId = request.ProductId;

            try
            {
                await _rubyContext.SaveChangesAsync();
                return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Product Deductible updated successfully.", HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<GenericNameResponse>("An error occurred while updating the Product Deductible.", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<GenericNameResponse>> DeleteProductDeductible(int deductibleId)
        {
            var deductible = await _rubyContext.ProductDeductibles.FindAsync(deductibleId);
            if (deductible == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product Deductible not found.", HttpStatusCode.NotFound);

            _rubyContext.ProductDeductibles.Remove(deductible);
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Product deductible deleted successfully.", HttpStatusCode.OK);
        }

        public async Task<BaseResponse<GenericNameResponse>> UpdateProductDurationRate(int id, ProductDurationRatedUpdateRequest request)
        {
            var productDurationRate = await _rubyContext.ProductDurationDetails.FindAsync(id);
            if (productDurationRate == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product Duration Rate not found.", HttpStatusCode.NotFound);

            productDurationRate.AppliedFor = request.AppliedFor;
            productDurationRate.DurationInDays = request.DurationInDays;
            productDurationRate.Rate = request.Rate;
            
            await _rubyContext.SaveChangesAsync();
            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Product duration rate updated successfully.", HttpStatusCode.OK);
        }

        public async Task<BaseResponse<GenericNameResponse>> DeleteProductDurationRate(int durationId)
        {
            var productDurationRate = await _rubyContext.ProductDurationDetails.FindAsync(durationId);
            if (productDurationRate == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Product Duration Rate not found.", HttpStatusCode.NotFound);

            
            _rubyContext.ProductDurationDetails.RemoveRange(productDurationRate);
           

            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Product duration rate deleted successfully.", HttpStatusCode.OK);
        }

        #endregion


        #region Subject Configuration 

        public async Task<BaseResponse<GenericNameResponse>> CreateProductCategorySubjectDataAsync(ProductCategorySubjectSetupDto request)
        {

            var productSubjectCategories = new List<ProductSubjectCategory>();

            var genericSelections = request.GenericRequest.Select(genericId => new ProductCategorySelection
            {
                ProductId = request.ProductId,
                CategoryId = genericId,
                IsGeneric = true
            }).ToList();

            _rubyContext.ProductCategorySelections.AddRange(genericSelections);
            await _rubyContext.SaveChangesAsync();

            foreach (var category in request.SubjectCategories)
            {
                // Step 1: Create ProductSubjectCategory
                var productSubjectCategory = new ProductSubjectCategory
                {
                    ProductId = request.ProductId,
                    CategoryName = category.CategoryName,
                    DateCreated = DateTime.UtcNow,
                    IsDeleted = false
                };

                _rubyContext.ProductSubjectCategories.Add(productSubjectCategory);
                await _rubyContext.SaveChangesAsync(); // Save to get the ID

                var groupedSubjects = category.ProductSubjectAttributes.GroupBy(x => x.SubjectTypeId);
                var productSubjectTypes = new List<ProductSubjectType>();

                foreach (var subjectGroup in groupedSubjects)
                {
                    // Step 2: Create ProductSubjectType
                    var productSubjectType = new ProductSubjectType
                    {
                        SubjectTypeId = subjectGroup.Key,
                        DateCreated = DateTime.UtcNow,
                        IsDeleted = false,
                        ProductId = request.ProductId,
                        CategoryId = productSubjectCategory.Id // Linking to Category
                    };

                    _rubyContext.ProductSubjectTypes.Add(productSubjectType);
                    await _rubyContext.SaveChangesAsync(); // Save to get the ID

                    // Step 3: Create ProductSubjectTypeAttributes
                    var productSubjectTypeAttributes = subjectGroup.Select(attribute => new ProductSubjectTypeAttribute
                    {
                        Name = attribute.SubjectAttributeName,
                        ProductSubjectCategoryId = productSubjectCategory.Id,
                        ProductSubjectTypeId = productSubjectType.Id,
                        IsSumInsured = attribute.IsSumAssured,
                        FieldType = attribute.FieldType,
                        IsRequired = attribute.IsCompulsory,
                        DataLength = attribute.DataLength,
                        DataTypeId = attribute.DataTypeId,
                        SpecifyOperator = attribute.SpecifyOperator,
                        ComparativeValueType = attribute.ComparativeValueType,
                        ComparativeValue = attribute.ComparativeValue,
                        RequiresUnderwriting = attribute.RequiresUnderwriting,
                        AvailableAtQuotation = attribute.RequiredAtQuoting,
                        GenericStateLgaStreet = attribute.GenericStateLgaStreet,
                        DropdownValues = attribute.DropdownValues?.Select(dv => new DropdownValues
                        {
                            Value = dv.Value
                        }).ToList(),
                    }).ToList();

                    _rubyContext.ProductSubjectTypeAttributes.AddRange(productSubjectTypeAttributes);
                    await _rubyContext.SaveChangesAsync();

                    productSubjectTypes.Add(productSubjectType);
                }

                productSubjectCategory.ProductSubjectTypes = productSubjectTypes;
                productSubjectCategories.Add(productSubjectCategory);
            }

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("",HttpStatusCode.Created);
        }
        public async Task<BaseResponse<GenericNameResponse>> UpdateProductSubjectDataAsync(int categoryId, ProductSubjectCategoryRequest updatedCategory)
        {
            var existingCategory = await _rubyContext.ProductSubjectCategories
                .Include(c => c.ProductSubjectTypes)
                .ThenInclude(t => t.ProductSubjectTypeAttributes)
                .FirstOrDefaultAsync(c => c.Id == categoryId);

            if (existingCategory == null)
                throw new Exception("Category not found");

            if (!string.IsNullOrEmpty(updatedCategory.CategoryName))
            {
                existingCategory.CategoryName = updatedCategory.CategoryName;
            }
            existingCategory.DateCreated = DateTime.UtcNow;

            var productSubjectTypes = new List<ProductSubjectType>();

            foreach (var updatedType in updatedCategory.ProductSubjectAttributes?
                .GroupBy(t => t.SubjectTypeId) ?? Enumerable.Empty<IGrouping<int, ProductSubjectAttributeRequest>>()) // Fix applied here
            {
                var existingType = existingCategory.ProductSubjectTypes.FirstOrDefault(t => t.SubjectTypeId == updatedType.Key);
                if (existingType == null)
                {
                    existingType = new ProductSubjectType
                    {
                        SubjectTypeId = updatedType.Key,
                        DateCreated = DateTime.UtcNow,
                        IsDeleted = false,
                        ProductId = existingCategory.ProductId,
                        CategoryId = existingCategory.Id
                    };
                    _rubyContext.ProductSubjectTypes.Add(existingType);
                }
                else
                {
                    existingType.DateCreated = DateTime.UtcNow;
                    existingType.IsDeleted = false;
                }

                foreach (var updatedAttribute in updatedType)
                {
                    var existingAttribute = existingType.ProductSubjectTypeAttributes.FirstOrDefault(a => a.Name == updatedAttribute.SubjectAttributeName);
                    if (existingAttribute == null)
                    {
                        existingAttribute = new ProductSubjectTypeAttribute
                        {
                            Name = updatedAttribute.SubjectAttributeName,
                            ProductSubjectCategoryId = existingCategory.Id,
                            ProductSubjectTypeId = existingType.Id,
                            IsSumInsured = updatedAttribute.IsSumAssured,
                            FieldType = updatedAttribute.FieldType,
                            IsRequired = updatedAttribute.IsCompulsory,
                            DataLength = updatedAttribute?.DataLength, 
                            DataTypeId = updatedAttribute.DataTypeId,
                            SpecifyOperator = updatedAttribute?.SpecifyOperator,
                            ComparativeValueType = updatedAttribute?.ComparativeValueType,
                            ComparativeValue = updatedAttribute?.ComparativeValue,
                            RequiresUnderwriting = updatedAttribute.RequiresUnderwriting,
                            AvailableAtQuotation = updatedAttribute.RequiredAtQuoting,
                            GenericStateLgaStreet = updatedAttribute.GenericStateLgaStreet,
                            DropdownValues = updatedAttribute?.DropdownValues?.Select(dv => new DropdownValues { Value = dv.Value }).ToList()
                        };
                        _rubyContext.ProductSubjectTypeAttributes.Add(existingAttribute);
                    }
                    else
                    {
                        existingAttribute.IsRequired = updatedAttribute?.IsCompulsory ?? existingAttribute.IsRequired;
                        existingAttribute.DataLength = updatedAttribute?.DataLength ?? existingAttribute.DataLength;
                        existingAttribute.DataTypeId = updatedAttribute?.DataTypeId ?? existingAttribute.DataTypeId;
                        existingAttribute.ComparativeValue = updatedAttribute?.ComparativeValue ?? existingAttribute.ComparativeValue;

                    }
                }

                productSubjectTypes.Add(existingType);
            }

            existingCategory.ProductSubjectTypes = productSubjectTypes.Any() ? productSubjectTypes : existingCategory.ProductSubjectTypes;
            await _rubyContext.SaveChangesAsync();
            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("", HttpStatusCode.OK);
        }

        public async Task<BaseResponse<GenericNameResponse>> DeleteProductSubjectDataAsync(int categoryId)
        {
            var category = await _rubyContext.ProductSubjectCategories
                .Include(c => c.ProductSubjectTypes)
                .ThenInclude(t => t.ProductSubjectTypeAttributes)
                .FirstOrDefaultAsync(c => c.Id == categoryId);

            if (category == null)
                throw new Exception("Category not found");

            _rubyContext.ProductSubjectCategories.Remove(category);
            await _rubyContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("", HttpStatusCode.OK); ;
        }


        #endregion


      




        #region Product Setup Methods
        public async Task<BaseResponse<ProductResponse>> SetupProductTeam(ProductTeamRequest request)
        {
            var response = new BaseResponse<ProductResponse>();
            string productCode = GetNextNonLifeProductCode(_rubyContext).ToString();

            // Check if the product exists
            var product = await _rubyContext.Products
                .FirstOrDefaultAsync(d => d.Name == request.ProductName);

            if (product == null)
            {
                response.Success = false;
                response.ResponseMessage = "Product not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Update product details
            product.VariantId = request.VariantId;
            product.RequiresUnderWriter = request.RequiresUnderWriter;
            product.PercentageProgress = Math.Min(100, product.PercentageProgress +
                (int)ProductPercentageProcess.ProductSetupStage);
            product.SetupStatus = request.RequiresUnderWriter
                ? ProductStatuses.Complete.ToString()
                : ProductStatuses.InComplete.ToString();
            product.ApprovalStatus = ProductStatuses.InComplete.ToString();
            product.RequiresGenericLocation = request.RequiresGenericLocation;
            product.RequireUnderWritingAtBooking = request.RequireUnderWritingAtBooking;
            product.ProductSetupStages = ProductStageOrder.ProductTeam.GetDescription();

            var workflowService = _serviceProvider.GetRequiredService<IWorkflowService>();

            



            await _rubyContext.SaveChangesAsync();

            // Create product-related data
            var paymentFrequency = CreateAllowedPayment(request.paymentFrequencies, product.Id);

            

            var productBaseSubjectTypeCovers = CreateBaseSubjectTypeCovers(request.BaseSubjectTypeCovers, product.Id);
            var productAdditionalSubjectTypeCovers = CreateAdditionalSubjectTypeCovers(request.AdditionalSubjectTypeCoverRequest, product.Id);
            var productCostTypes = CreateProductCostTypes(request.CostTypes, product.Id);
            var productCostOfInsurances = CreateProductCostOfInsurances(request.CostsOfInsurance, product.Id);
            var productFee = CreateProductFeeSetup(request.ProductFeeSetupRequests, product.Id);


            try
            {
                await SaveProductSetupAsync(product, paymentFrequency, productBaseSubjectTypeCovers, productAdditionalSubjectTypeCovers, productCostTypes,
                    productCostOfInsurances, productFee);
                await CreateProductSubjectDataAsync(request.ProductSubjectAttributeRequests, product.Id, request.GenericRequest);
                await CreateWorkflowApproval(product.Id, product.Name);

                var delStaging = await _rubyContext.ProductStaging.SingleOrDefaultAsync(d => d.ProductName == request.ProductName);
                if (delStaging != null)
                {
                    _rubyContext.ProductStaging.Remove(delStaging);

                }

                // _workflowEmail.SendProductSetupEmail(product, EmailFilesDefinition.PRODUCT_SETUP_TEMPLATE, EmailSubjectsKey.PRODUCT_TEAM_SETUP_COMPLETION, teamEmails, ProductStageEnum.ProductTeam.GetDescription());
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ResponseMessage = $"Product Setup Failed: {ex}";
                response.StatusCode = HttpStatusCode.InternalServerError;
                return response;
            }

            response.Success = true;
            response.ResponseMessage = "Product Setup Initiated";
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }

        

        public async Task<BaseResponse<GenericNameResponse>> CreateWorkflowApproval(int productId, string productName)
        {
            // Fetch the workflow module from the external service
            var workflowService = _serviceProvider.GetRequiredService<IWorkflowService>();
            var module = await workflowService.GetAllWorkflowProcessByModule();

            if (module == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Workflow Module is not available", HttpStatusCode.NotFound);

            // Create a single workflow with multiple WorkflowProcessIds
            var workflowToAdd = new Workflow()
            {
                CreatedBy = GetUserClaims(),
                DateCreated = DateTime.UtcNow,
                IsApprovalCompleted = false,
                IsServiceNotified = false,
                ProgressPercentage = 0,
                RequestTitle = productName,
                Status = ApprovalStatusEnum.Pending.GetDescription(),
                ModuleId = configOptions.Value.ProductWorkflowModuleId,
                SourceId = productId,
                Type = "Product",
                // Add all WorkflowProcessIds from the module
                WorkflowProcessIds = module.Data.Select(w => w.Id).ToList()
            };

            // Add workflow to the context (will save this to get the generated WorkflowId)
            _rubyContext.Workflows.Add(workflowToAdd);
            await _rubyContext.SaveChangesAsync();  // Save to get the Workflow Id

            // Now create the associated WorkflowApprovingOffice records for each WorkflowProcessId in the list
            var workflowApprovingOfficesToAdd = new List<WorkflowApprovingOffice>();

            foreach (var workflowProcessId in workflowToAdd.WorkflowProcessIds)
            {
                var workflowProcess = module.Data.FirstOrDefault(w => w.Id == workflowProcessId);

                if (workflowProcess != null)
                {
                    var approvalSetups = workflowProcess.ApprovalSetups;
                    if (approvalSetups != null && approvalSetups.Any())
                    {
                        foreach (var approvalSetup in approvalSetups)
                        {
                            // Add a new WorkflowApprovingOffice record for each approval level for the current WorkflowProcessId
                            var workflowApprovingOfficeToAdd = new WorkflowApprovingOffice()
                            {
                                WorkflowId = workflowToAdd.Id,  // Set the WorkflowId from the saved workflow
                                IsApprovalCompleted = false,
                                ApprovingOffice = approvalSetup.ApprovingOffice,
                                ApprovingOfficeId = approvalSetup.ApprovingOfficeId ?? 0,
                                FunctionId = approvalSetup.FunctionId ?? 0,
                                ApprovalLevel = approvalSetup.Sequence,  // Sequence represents the approval level
                            };

                            workflowApprovingOfficesToAdd.Add(workflowApprovingOfficeToAdd);
                        }
                    }
                }
            }

            // Add all WorkflowApprovingOffices to the context
            _rubyContext.WorkflowApprovingOffices.AddRange(workflowApprovingOfficesToAdd);
            await _rubyContext.SaveChangesAsync(); // Save changes for WorkflowApprovingOffices

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Successfully saved workflow and approving offices.", HttpStatusCode.OK);
        }


        private string GetUserClaims()
        {
            var userNameClaim = _contextAccessor.HttpContext?.User?.FindFirst("FullName")?.Value;
            return !string.IsNullOrEmpty(userNameClaim) ? userNameClaim : "Anonymous";
        }
        private List<ProductAllowedPaymentFrequency> CreateAllowedPayment(List<PaymentFrequencyRequest> paymentFrequencies, int productId)
        {
            return paymentFrequencies?.Select(frequency => new ProductAllowedPaymentFrequency
            {
                ProductId = productId,
                DateCreated = DateTime.UtcNow,
                PaymentFrequency = frequency.PaymentIntervals,
                IsDeleted = false
            }).ToList() ?? new List<ProductAllowedPaymentFrequency>();
        }
        private async Task<List<ProductSubjectCategory>> CreateProductSubjectDataAsync(List<ProductSubjectCategoryRequest> subjectCategories, int productId,List<int> GenericRequest)
        {

            var productSubjectCategories = new List<ProductSubjectCategory>();

            var genericSelections = GenericRequest.Select(genericId => new ProductCategorySelection
            {
                ProductId = productId,
                CategoryId = genericId, 
                IsGeneric = true
            }).ToList();

            _rubyContext.ProductCategorySelections.AddRange(genericSelections);
            await _rubyContext.SaveChangesAsync();

            foreach (var category in subjectCategories)
            {
                // Step 1: Create ProductSubjectCategory
                var productSubjectCategory = new ProductSubjectCategory
                {
                    ProductId = productId,
                    CategoryName = category.CategoryName,
                    DateCreated = DateTime.UtcNow,
                    IsDeleted = false
                };

                _rubyContext.ProductSubjectCategories.Add(productSubjectCategory);
                await _rubyContext.SaveChangesAsync(); // Save to get the ID

                var groupedSubjects = category.ProductSubjectAttributes.GroupBy(x => x.SubjectTypeId);
                var productSubjectTypes = new List<ProductSubjectType>();

                foreach (var subjectGroup in groupedSubjects)
                {
                    // Step 2: Create ProductSubjectType
                    var productSubjectType = new ProductSubjectType
                    {
                        SubjectTypeId = subjectGroup.Key,
                        DateCreated = DateTime.UtcNow,
                        IsDeleted = false,
                        ProductId = productId,
                        CategoryId = productSubjectCategory.Id // Linking to Category
                    };

                    _rubyContext.ProductSubjectTypes.Add(productSubjectType);
                    await _rubyContext.SaveChangesAsync(); // Save to get the ID

                    // Step 3: Create ProductSubjectTypeAttributes
                    var productSubjectTypeAttributes = subjectGroup.Select(attribute => new ProductSubjectTypeAttribute
                    {
                        Name = attribute.SubjectAttributeName,
                        ProductSubjectCategoryId = productSubjectCategory.Id,
                        ProductSubjectTypeId = productSubjectType.Id,
                        IsSumInsured = attribute.IsSumAssured,
                        FieldType = attribute.FieldType,
                        IsRequired = attribute.IsCompulsory,
                        DataLength = attribute.DataLength,
                        DataTypeId = attribute.DataTypeId,
                        SpecifyOperator = attribute.SpecifyOperator,
                        ComparativeValueType = attribute.ComparativeValueType,
                        ComparativeValue = attribute.ComparativeValue,
                        RequiresUnderwriting = attribute.RequiresUnderwriting,
                        AvailableAtQuotation = attribute.RequiredAtQuoting,
                        GenericStateLgaStreet = attribute.GenericStateLgaStreet,
                        DropdownValues = attribute.DropdownValues?.Select(dv => new DropdownValues
                        {
                            Value = dv.Value
                        }).ToList(),
                    }).ToList();

                    _rubyContext.ProductSubjectTypeAttributes.AddRange(productSubjectTypeAttributes);
                    await _rubyContext.SaveChangesAsync();

                    productSubjectTypes.Add(productSubjectType);
                }

                productSubjectCategory.ProductSubjectTypes = productSubjectTypes;
                productSubjectCategories.Add(productSubjectCategory);
            }

            return productSubjectCategories;
        }
        private List<ProductBaseSubjectTypeCover> CreateBaseSubjectTypeCovers(List<BaseSubjectTypeCoverRequest> baseSubjectTypeCovers, int productId) 
        {
            return baseSubjectTypeCovers?.Select(baseSubjectTypeCover => new ProductBaseSubjectTypeCover
            {
                ProductId = productId,
                CoverStatus = baseSubjectTypeCover.Status,
                BaseCoverId = baseSubjectTypeCover.CoverId,
                LimitType = baseSubjectTypeCover.LimitType,
                RateTable = baseSubjectTypeCover.UseRateTable,
                MaximumAmount = baseSubjectTypeCover.MaximumAmount,
                RateApplied = baseSubjectTypeCover.RateApplied,
                DisplayFormula = baseSubjectTypeCover.DisplayFormula,
                FixedPremium  =  baseSubjectTypeCover.FixedPremium,
                isFixed = baseSubjectTypeCover.isFixed

            }).ToList() ?? new List<ProductBaseSubjectTypeCover>();
        }
        private List<ProductAdditionalSubjectTypeCover> CreateAdditionalSubjectTypeCovers(List<AdditionalSubjectTypeCoverRequest> additionalSubjectTypeCovers, int productId)
        {
            return additionalSubjectTypeCovers?.Select(additionalSubjectCover => new ProductAdditionalSubjectTypeCover
            {
                ProductId = productId,
                CoverStatus = additionalSubjectCover.Status,
                AdditionalCoverId = additionalSubjectCover.CoverId,
                //LimitAmount = additionalSubjectCover.CoverLimits,
                LimitType = additionalSubjectCover.LimitType,
                RateTable = additionalSubjectCover.UseRateTable,
                MaximumAmount = additionalSubjectCover.MaximumAmount,
                RateApplied = additionalSubjectCover.RateApplied,
                DisplayFormula = additionalSubjectCover.DisplayFomula,
                FixedPremium = additionalSubjectCover.FixedPremium,
                isFixed = additionalSubjectCover.isFixed
            }).ToList() ?? new List<ProductAdditionalSubjectTypeCover>();
        }
        private List<ProductCostType> CreateProductCostTypes(List<ProductCostTypeRequest> costTypes, int productId)
        {
            return costTypes?.Select(costType => new ProductCostType
            {
                ProductId = productId,
                DateCreated = DateTime.UtcNow,
                CostTypeId = costType.CostTypeId,
                Remark = costType.Remark,
                IsDeleted = false
            }).ToList() ?? new List<ProductCostType>();
        }
        private List<ProductCostOfInsurance> CreateProductCostOfInsurances(List<ProductCostOfInsuranceRequest> costsOfInsurance, int productId)
        {
            return costsOfInsurance?.Select(costOfInsurance => new ProductCostOfInsurance
            {
                ProductId = productId,
                CostTypeId = costOfInsurance.CostType,
                Year = costOfInsurance.Year,
                TermValue = (decimal)costOfInsurance.Value,
                DisplayFormula = costOfInsurance.DisplayFormula,
                Rate = costOfInsurance.Rate.ToString(),
                DateCreated = DateTime.UtcNow,
                CostBearer = costOfInsurance.CostBearer,
                CollectionSourceId = costOfInsurance.SourceId
            }).ToList() ?? new List<ProductCostOfInsurance>();
        }

        public List<ProductFeeSetup> CreateProductFeeSetup(List<ProductFeeSetupRequest> feeSetup, int productId)
        {
       
            return feeSetup?.Select(feeSetup => new ProductFeeSetup
            {
                ProductId = productId,
                FeeName = feeSetup.Name,
                PercentageValue = feeSetup.Value,
                Description = feeSetup.Description,
            }).ToList() ?? new List<ProductFeeSetup>();
        }
        private List<ProductDocument> CreateProductDocuments(List<ProductDocumentRequest> policyDocuments, int productId)
        {
            return policyDocuments?.Select(policyDocument => new ProductDocument
            {
               
                Name = policyDocument.Name,
                Size = policyDocument.Size,
                Format = policyDocument.Format,
                IsRequired = policyDocument.IsRequired,
                IsDeleted = false,
            }).ToList() ?? new List<ProductDocument>();
        }

       

        private async Task SaveProductSetupAsync(Product product,
                List<ProductAllowedPaymentFrequency> paymentFrequencies,
                List<ProductBaseSubjectTypeCover> productBaseSubjectTypeCovers,
                List<ProductAdditionalSubjectTypeCover> productAdditionalSubjectTypeCovers,
                List<ProductCostType> productCostTypes,
                List<ProductCostOfInsurance> productCostOfInsurances,
                List<ProductFeeSetup> productFeeSetups)

        {
            using (var transaction = await _rubyContext.Database.BeginTransactionAsync())
            {
                try
                {
                    // Save main product data
                    _rubyContext.Products.Update(product);
                    _rubyContext.ProductAllowedPaymentFrequencies.AddRange(paymentFrequencies);
                    _rubyContext.ProductBaseCovers.AddRange(productBaseSubjectTypeCovers);
                    _rubyContext.ProductAdditionalCovers.AddRange(productAdditionalSubjectTypeCovers);
                    _rubyContext.ProductCostTypes.AddRange(productCostTypes);
                    _rubyContext.ProductCostOfInsurances.AddRange(productCostOfInsurances);
                    _rubyContext.ProductFeeSetups.AddRange(productFeeSetups);
                    
                    // Commit all changes
                    await _rubyContext.SaveChangesAsync();
                    await transaction.CommitAsync();

                   
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }

        public async Task<BaseResponse<List<ProductSubjectAttributeDropdownMapping>>> CreateProductSubjectAttributeMapping(
                List<ProductSubjectAttributeDropdownMappingRequest> dropdownMappingRequests)
        {
            var response = new BaseResponse<List<ProductSubjectAttributeDropdownMapping>>();
            var dropdownMappings = new List<ProductSubjectAttributeDropdownMapping>();

            // Collect all attribute IDs needed
            var parentAttributeIds = dropdownMappingRequests.Select(r => r.ParentAttributeId).Distinct().ToList();
            var childAttributeIds = dropdownMappingRequests.Select(r => r.ChildAttributeId).Distinct().ToList();

            // Fetch all necessary attributes in one query (including ProductId)
            var parentAttributes = await _rubyContext.ProductSubjectTypeAttributes
                .Where(attr => parentAttributeIds.Contains(attr.Id))
                .Include(attr => attr.ProductSubjectType)
                .ToDictionaryAsync(attr => attr.Id);

            var childAttributes = await _rubyContext.ProductSubjectTypeAttributes
                .Where(attr => childAttributeIds.Contains(attr.Id))
                .Include(attr => attr.ProductSubjectType)
                .ToDictionaryAsync(attr => attr.Id);

            foreach (var dropdownMappingRequest in dropdownMappingRequests)
            {
                if (!parentAttributes.TryGetValue(dropdownMappingRequest.ParentAttributeId, out var parentAttribute))
                {
                    response.Success = false;
                    response.ResponseMessage = $"Parent attribute with ID {dropdownMappingRequest.ParentAttributeId} not found.";
                    response.StatusCode = HttpStatusCode.NotFound;
                    return response;
                }

                if (!childAttributes.TryGetValue(dropdownMappingRequest.ChildAttributeId, out var childAttribute))
                {
                    response.Success = false;
                    response.ResponseMessage = $"Child attribute with ID {dropdownMappingRequest.ChildAttributeId} not found.";
                    response.StatusCode = HttpStatusCode.NotFound;
                    return response;
                }

                // Create Mapping
                dropdownMappings.Add(new ProductSubjectAttributeDropdownMapping
                {
                    ProductId= parentAttribute.ProductSubjectType.ProductId,
                    ParentAttributeId = parentAttribute.Id,
                    ParentValue = dropdownMappingRequest.ParentValue,
                    ChildAttributeId = childAttribute.Id,
                    ChildValues = string.Join(",", dropdownMappingRequest.ChildValues),
                    DateCreated = DateTime.UtcNow
                });
            }

            if (dropdownMappings.Any())
            {
                await _rubyContext.ProductSubjectAttributeDropdownMappings.AddRangeAsync(dropdownMappings);
                await _rubyContext.SaveChangesAsync();
            }

            response.Success = true;
            response.ResponseMessage = "Subject Mapped Successfully.";
            response.StatusCode = HttpStatusCode.Created;
            return response;
        }

        public async Task<BaseResponse<ProductSubjectAttributeDropdownMapping>> UpdateProductSubjectAttributeMapping(
                int mappingId,
                     ProductSubjectAttributeDropdownMappingRequest updatedMappingRequest){
            var response = new BaseResponse<ProductSubjectAttributeDropdownMapping>();

            var existingMapping = await _rubyContext.ProductSubjectAttributeDropdownMappings
                .FirstOrDefaultAsync(m => m.Id == mappingId);

            if (existingMapping == null)
            {
                response.Success = false;
                response.ResponseMessage = "Mapping not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Fetch the updated Parent Attribute
            var parentAttribute = await _rubyContext.ProductSubjectTypeAttributes
                .FirstOrDefaultAsync(attr => attr.Id == updatedMappingRequest.ParentAttributeId);

            if (parentAttribute == null)
            {
                response.Success = false;
                response.ResponseMessage = "Parent attribute not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Fetch the updated Child Attribute
            var childAttribute = await _rubyContext.ProductSubjectTypeAttributes
                .FirstOrDefaultAsync(attr => attr.Id == updatedMappingRequest.ChildAttributeId);

            if (childAttribute == null)
            {
                response.Success = false;
                response.ResponseMessage = "Child attribute not found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Update the existing mapping
            existingMapping.ParentAttributeId = parentAttribute.Id;
            existingMapping.ParentValue = updatedMappingRequest.ParentValue;
            existingMapping.ChildAttributeId = childAttribute.Id;
            existingMapping.ChildValues = string.Join(",", updatedMappingRequest.ChildValues);
            existingMapping.UpdateDated = DateTime.UtcNow;

            _rubyContext.ProductSubjectAttributeDropdownMappings.Update(existingMapping);
            await _rubyContext.SaveChangesAsync();

            response.Success = true;
            response.ResponseMessage = "Mapping updated successfully.";
            response.StatusCode = HttpStatusCode.OK;
            response.Data = existingMapping;
            return response;
        }

       
         
       

        private static int GetNextNonLifeProductCode(RubyDbContext RubyContext)
        {

            int seqQuence;
            var connection = RubyContext.Database.GetDbConnection();
            connection.Open();
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = TableSequenceQueries.NON_LIFE_PRODUCT_CODE;
                var obj = cmd.ExecuteScalar();
                seqQuence = Convert.ToInt32(obj);
            }
            connection.Close();
            return seqQuence;

        }
        private int UserClaims()
        {
            // Retrieve UserId from claims
            var userIdClaim = _contextAccessor.HttpContext.User.FindFirst("UserId")?.Value;
            int.TryParse(userIdClaim, out int userId);
            return userId;
        }

        #endregion
        private async Task<List<ProductSubjectType>> CreateOrUpdateProductSubjectTypesAsync(
            List<int> subjectTypeIds,
            List<ProductSubjectCategoryRequest> productSubjectCategories,
            int productId,
            Dictionary<string, int> categoryNameToId){

            throw new NotImplementedException();
            //var productSubjectTypes = new List<ProductSubjectType>();

            //if (subjectTypeIds != null)
            //{
            //    var orderedSubjectTypes = subjectTypeIds.OrderBy(x => x);
            //    var groupedCategories = productSubjectCategories
            //        .SelectMany(c => c.ProductSubjectAttributes)
            //        .GroupBy(x => x.SubjectTypeId);

            //    foreach (var subjectTypeId in orderedSubjectTypes)
            //    {
            //        var filteredSubjects = groupedCategories.FirstOrDefault(x => x.Key == subjectTypeId);
            //        if (filteredSubjects != null)
            //        {
            //            var subjectList = filteredSubjects.ToList();
            //            foreach (var category in categoryNameToId)
            //            {
            //                // Ensure category exists in DB
            //                var existingCategory = await _rubyContext.ProductSubjectCategories
            //                    .FirstOrDefaultAsync(c => c.CategoryName == category.Key);

            //                if (existingCategory == null)
            //                {
            //                    existingCategory = new ProductSubjectCategory
            //                    {
            //                        CategoryName = category.Key,
            //                        ProductId = productId,
                                    
            //                    };
            //                    _rubyContext.ProductSubjectCategories.Add(existingCategory);
            //                    await _rubyContext.SaveChangesAsync(); // Save new category
            //                }

            //                // Now use the category ID
            //                var existingProductSubjectType = await _rubyContext.ProductSubjectTypes
            //                    .FirstOrDefaultAsync(pst => pst.ProductId == productId && pst.SubjectTypeId == subjectTypeId && pst.IsDeleted == false);

            //                if (existingProductSubjectType != null)
            //                {
            //                    existingProductSubjectType.ProductSubjectTypeAttributes =
            //                        UpdateProductSubjectTypeAttributes(existingProductSubjectType, subjectList, existingCategory.Id);
            //                    productSubjectTypes.Add(existingProductSubjectType);
            //                }
            //                else
            //                {
            //                    var newProductSubjectType = CreateProductSubjectType(subjectTypeId, subjectList, productId, existingCategory.Id);
            //                    productSubjectTypes.Add(newProductSubjectType);
            //                }
            //            }
            //        }
            //    }
            //}

            //return productSubjectTypes;
        }

        private List<ProductSubjectTypeAttribute> UpdateProductSubjectTypeAttributes(ProductSubjectType existingSubjectType, List<ProductSubjectRequest> subjects, int categoryId)
        {
            // Update the existing attributes (if necessary, you can apply logic to check which ones need updating)
            var updatedAttributes = subjects.Select(attribute => new ProductSubjectTypeAttribute
            {
                Name = attribute.SubjectAttributeName,
                ProductSubjectCategoryId = categoryId,
                ProductSubjectTypeId = existingSubjectType.Id,
                IsSumInsured = attribute.IsSumAssured,
                FieldType = attribute.FieldType,
                IsRequired = attribute.IsCompulsory,
                DataLength = attribute.DataLength,
                DataTypeId = attribute.DataTypeId,
                SpecifyOperator = attribute.SpecifyOperator,
                ComparativeValueType = attribute.ComparativeValueType,
                ComparativeValue = attribute.ComparativeValue,
                RequiresUnderwriting = attribute.RequiresUnderwriting,
                AvailableAtQuotation = attribute.RequiredAtQuoting,
                GenericStateLgaStreet = attribute.GenericStateLgaStreet,
                DropdownValues = attribute.DropdownValues?.Select(dv => new DropdownValues
                {
                    Value = dv.Value
                }).ToList(),
            }).ToList();

            return updatedAttributes;
        }
        private async Task<BaseResponse<Dictionary<int, string>>> GetCostTypeNamesById(List<int> costTypeIds)
        {
           

            var token = await _adminHelper.GetAccessToken();
            var baseUrl = _apiSettings.Value.AdminUrl.BaseUrl;
            var lineOfBusinessId = _apiSettings.Value.AdminUrl.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var result = await _httpClient.GetFromJsonAsync<AdminCentralApiResponse<object>>(
                $"{baseUrl}/CostType/Search?Filters.LineOfBusinessId={lineOfBusinessId}",
                jsonOptions
            );

            if (result?.Payload == null)
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No cost type found.", HttpStatusCode.NotFound);
            }

            // Force Deserialize as List
            var jsonString = System.Text.Json.JsonSerializer.Serialize(result.Payload);
            var costTypeList = System.Text.Json.JsonSerializer.Deserialize<List<AdminGenericResponse>>(jsonString, jsonOptions);

            if (costTypeList == null || !costTypeList.Any())
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No cost type found.", HttpStatusCode.NotFound);
            }

            var costTypeMap = costTypeList
                .Where(p => costTypeIds.Contains(p.Id))
            .ToDictionary(p => p.Id, p => p.Caption);

            

            return ResponseFactory.GetSuccessResponse(costTypeMap, "Cost Type names successfully retrieved.");
        }
        private async Task<BaseResponse<Dictionary<int, string>>> RiderNamesById(List<int> riderIds)
        {

            var token = await _adminHelper.GetAccessToken();
            var baseUrl = _apiSettings.Value.AdminUrl.BaseUrl;
            var lineOfBusinessId = _apiSettings.Value.AdminUrl.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var result = await _httpClient.GetFromJsonAsync<AdminCentralApiResponse<object>>(
                $"{baseUrl}/Rider/Search?Filters.LineOfBusinessId={lineOfBusinessId}",
                jsonOptions
            );

            if (result?.Payload == null)
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No cost type found.", HttpStatusCode.NotFound);
            }

            // Force Deserialize as List
            var jsonString = System.Text.Json.JsonSerializer.Serialize(result.Payload);
            var riderList = System.Text.Json.JsonSerializer.Deserialize<List<AdminGenericResponse>>(jsonString, jsonOptions);

            if (riderList == null || !riderList.Any())
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No cost type found.", HttpStatusCode.NotFound);
            }

            var costTypeMap = riderList
                .Where(p => riderIds.Contains(p.Id))
                .ToDictionary(p => p.Id, p => p.Caption);

            return ResponseFactory.GetSuccessResponse(costTypeMap, "Rider names successfully retrieved.");
        }
        private async Task<BaseResponse<Dictionary<int, string>>> GetCostOfInsuranceNamesById(List<int> costOfInsuranceIds)
        {
            var token = await _adminHelper.GetAccessToken();
            var baseUrl = _apiSettings.Value.AdminUrl.BaseUrl;
            var lineOfBusinessId = _apiSettings.Value.AdminUrl.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var result = await _httpClient.GetFromJsonAsync<AdminCentralApiResponse<object>>(
                $"{baseUrl}/SourceOfCollection/Search?Filters.LineOfBusinessId={lineOfBusinessId}",
                jsonOptions
            );

            if (result?.Payload == null)
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No cost of insurance found.", HttpStatusCode.NotFound);
            }

            // Force Deserialize as List
            var jsonString = System.Text.Json.JsonSerializer.Serialize(result.Payload);
            var costOfInsurance = System.Text.Json.JsonSerializer.Deserialize<List<AdminGenericResponse>>(jsonString, jsonOptions);

            if (costOfInsurance == null || !costOfInsurance.Any())
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No cost of Insurance found.", HttpStatusCode.NotFound);
            }

            var costOfInsuranceMapping = costOfInsurance
                .Where(p => costOfInsuranceIds.Contains(p.Id))
                .ToDictionary(p => p.Id, p => p.Caption);

            return ResponseFactory.GetSuccessResponse(costOfInsuranceMapping, "Cost Of Insurance names successfully retrieved.");
        }

        private async Task<BaseResponse<Dictionary<int, string>>> GetObjectOfInsuranceNamesById(List<int> objectOfInsuranceIds)
        {
            var token = await _adminHelper.GetAccessToken();
            var baseUrl = _apiSettings.Value.AdminUrl.BaseUrl;
            var lineOfBusinessId = _apiSettings.Value.AdminUrl.LineOfBusinessId;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var result = await _httpClient.GetFromJsonAsync<AdminCentralApiResponse<object>>(
                $"{baseUrl}/SubjectOfInsurance/Search?Filters.LineOfBusinessId={lineOfBusinessId}",
                jsonOptions
            );

            if (result?.Payload == null)
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No cost of insurance found.", HttpStatusCode.NotFound);
            }

            // Force Deserialize as List
            var jsonString = System.Text.Json.JsonSerializer.Serialize(result.Payload);
            var costOfInsurance = System.Text.Json.JsonSerializer.Deserialize<List<AdminGenericResponse>>(jsonString, jsonOptions);

            if (costOfInsurance == null || !costOfInsurance.Any())
            {
                return ResponseFactory.CreateError<Dictionary<int, string>>("No cost of Insurance found.", HttpStatusCode.NotFound);
            }

            var costOfInsuranceMapping = costOfInsurance
                .Where(p => objectOfInsuranceIds.Contains(p.Id))
                .ToDictionary(p => p.Id, p => p.Caption);

            return ResponseFactory.GetSuccessResponse(costOfInsuranceMapping, "Cost Of Insurance names successfully retrieved.");
        }





    }

}

