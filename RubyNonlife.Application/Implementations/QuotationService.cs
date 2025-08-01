using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using RubyNonlife.Application.Dtos.Requests.Quotation;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using RubyNonlife.Application.Dtos.Responses.Quotation;
using RubyNonlife.Infrastructure.Contract;
using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;
using RubyNonlife.Domain.Models.QuoteEntities;
using System.Net;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Caching.Memory;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using RubyNonlife.Infrastructure.Persistence;
using RubyNonlife.Application.Contract;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Application.Helper.GeneralHelper;
using Azure.Core;
using System.Drawing;
using System.Xml.Linq;
using System.Text.Json;
using RubyNonlife.Domain.Models.GenericEntities;
using Microsoft.Extensions.DependencyInjection;
using RubyNonlife.Application.Dtos.Responses.LineOfBuisnessGenericResponse;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.Ocsp;
using NLog.Filters;
using RubyNonlife.Application.Helper.UtitlityModel;
using Microsoft.Extensions.Logging;


namespace RubyNonlife.Infrastructure.Implementations
{
    public class QuotationService : IQuotationService {

        private readonly RubyDbContext _rubyContext;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IConfiguration _configuration;
        private readonly AdminUrlConfig _apiSettings;
        private readonly AdminAuthenticationHelper _adminHelper;
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _memoryCache;
        private readonly IAdminServiceIntegration _adminService;
        private readonly ConfigModels _configModels;
        private readonly ILogger<QuotationService> _logger;
        public QuotationService(RubyDbContext dbContext,IHttpContextAccessor httpContext,
            IConfiguration configuration, IOptions<ApiSettings> apiSettings, AdminAuthenticationHelper admin,
            HttpClient http, IMemoryCache memory, IAdminServiceIntegration adminService, IOptions<ConfigModels> configOptions,
             ILogger<QuotationService> logger
            )
        { 
            _rubyContext = dbContext;
            _contextAccessor = httpContext;
            _configuration = configuration;
            _apiSettings = apiSettings.Value.AdminUrl;
            _adminHelper = admin;
            _httpClient = http;
            _memoryCache = memory;
            _adminService = adminService;
            _configModels = configOptions.Value;
            _logger =logger;

        }
    
        public async Task<BaseResponse<List<GenericNameResponse>>> GetQuotePreference()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var quotePreference = await _rubyContext.QuotePreferences.ToListAsync();
            var quotePreferenceData = quotePreference.Select(x => new GenericNameResponse()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();

            response.Success = true;
            response.ResponseMessage = "Quote Preference successfully retrieved.";
            response.Data = quotePreferenceData;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetBusinessType()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var businessType = await _rubyContext.BusinessTypes.ToListAsync();
            var businessTypeResponse = businessType.Select(d => new GenericNameResponse()
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();
            response.Success = true;
            response.ResponseMessage = "Business Type successfully retrieved.";
            response.Data = businessTypeResponse;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetPolicyDuration()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var policyDuration = await _rubyContext.PolicyDurations.ToListAsync();

            var policyDurationData = policyDuration.Select(d => new GenericNameResponse() {
                Id = d.Id,
                Name = d.Name,
            }).ToList();

            response.Success = true;
            response.ResponseMessage = "Policy Duration successfully retrieved";
            response.Data = policyDurationData;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetQuoteType()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var quoteType = await _rubyContext.QuoteTypes.ToListAsync();
            var quoteTypeData = quoteType.Select(d => new GenericNameResponse()
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();

            response.Success = true;
            response.ResponseMessage = "Quote Type successfully retrieved";
            response.Data = quoteTypeData;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetQuoteChannel()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var quoteChannel = await _rubyContext.QuoteChannels.ToListAsync();
            var quoteChannelData = quoteChannel.Select(d => new GenericNameResponse()
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();
            response.Success = true;
            response.ResponseMessage = "Quote Channel successfully retrieved";
            response.Data = quoteChannelData;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetProduct()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var product = await _rubyContext.Products.
                Where(x=>x.PercentageProgress == 100).
                ToListAsync();
            var productData = product.Select(d => new GenericNameResponse()
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();

            response.Success = true;
            response.ResponseMessage = "Product successfully retrieved";
            response.Data = productData;
            response.StatusCode= System.Net.HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetStates()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var state = await _adminService.GetStates();
            var stateData = state.Data.Select(d => new GenericNameResponse()
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();
            response.Success = true;
            response.ResponseMessage = "state successfully retrieved";
            response.Data = stateData;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<GetSingleProductResponse>> GetSingleProductAsync(int productId)
        {
            var response = new BaseResponse<GetSingleProductResponse>();

            // Fetch the product details
            var product = await _rubyContext.Products
                .Include(p => p.ProductSubjectCategories)
                .Include(p => p.ProductSubjectTypes)
                .Include(p => p.ProductBaseSubjectTypeCovers)
                .Include(p => p.ProductAdditionalSubjectTypeCovers)
                .Include(p => p.ProductCostType)
                .Include(p => p.ProductCostOfInsurances)
                .Include(p => p.ProductCategorySelections)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                return new BaseResponse<GetSingleProductResponse>
                {
                    Success = false,
                    ResponseMessage = "Product not found",
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
            }

            var dropdownMappingResponse = await GetProductSubjectAttributeMappings(productId);
            var dropdownMappings = dropdownMappingResponse.Data ?? new List<object>();

           

            // Fetch distinct category IDs for the product
            var categoryIds = await _rubyContext.ProductCategorySelections
                .Where(d => d.ProductId == productId)
                .Select(d => d.CategoryId)
                .Distinct()
                .ToListAsync();

            // Fetch additional attributes from getCategory
            var getCategory = await _rubyContext.LineOfBusinessAttributeItems
                .Where(d => categoryIds.Contains(d.CategoryId) && d.RequiredAtQuoting == true)
                .ToListAsync();


           
            var categoryAttributes = getCategory
                .Select(d => new ProductSubjectTypeAttributeResponse
                {
                    Id = d.Id,
                    Name = d.Name, // Assuming this is the attribute name
                    FieldType = d.DataType,
                    IsRequired =true,
                    IsSumInsured = d.IsSumAssured,
                    DataTypeId = 0,
                    DataLength = 0,
                    SpecifyOperator = null,
                    ComparativeValueType = null,
                    ComparativeValue = null,
                    RequiresUnderwriting = false,
                    RequiredAtQuoting = d.RequiredAtQuoting,
                    HasParentChildOptions = false,
                    ProductSubjectTypeId = 0 // Since getCategory attributes are not tied to a specific SubjectTypeId
                })
                .ToList();

            // Fetch ProductSubjectTypes attributes
            var productSubjectTypes = await _rubyContext.ProductSubjectTypes
                .Where(d => d.ProductId == productId)
                .Select(pst => new
                {
                    pst.Id,
                    pst.SubjectTypeId,
                    CategoryName = _rubyContext.ProductSubjectCategories
                        .Where(c => c.ProductId == pst.ProductId)
                        .Select(c => c.CategoryName)
                        .FirstOrDefault() ?? "Unknown",
                    ProductSubjectTypeAttributes = pst.ProductSubjectTypeAttributes
                        .Where(attr => attr.AvailableAtQuotation == true)
                        .Select(attr => new ProductSubjectTypeAttributeResponse
                        {
                            Id = attr.Id,
                            Name = attr.Name,
                            FieldType = attr.FieldType,
                            IsRequired = attr.IsRequired,
                            IsSumInsured = attr.IsSumInsured,
                            DataTypeId = attr.DataTypeId,
                            DataLength = attr.DataLength,
                            SpecifyOperator = attr.SpecifyOperator,
                            ComparativeValueType = attr.ComparativeValueType,
                            ComparativeValue = attr.ComparativeValue,
                            RequiresUnderwriting = attr.RequiresUnderwriting,
                            RequiredAtQuoting = attr.AvailableAtQuotation,
                            HasParentChildOptions = attr.HasParentChildOptions,
                            ProductSubjectTypeId = pst.SubjectTypeId
                        }).ToList()
                })
                .ToListAsync();

            // Merge attributes if both are available, otherwise return the available one
            List<SubjectTypeResponse> subjectTypeResponses = new List<SubjectTypeResponse>();

            if (productSubjectTypes.Any() || categoryAttributes.Any())
            {
                subjectTypeResponses = productSubjectTypes
                    .Select(pst => new SubjectTypeResponse
                    {
                        Id = pst.Id,
                        SubjectTypeId = pst.SubjectTypeId,
                        CategoryName = pst.CategoryName, // From ProductSubjectTypes
                        Attributes = pst.ProductSubjectTypeAttributes.Concat(categoryAttributes).ToList() // Merge attributes
                    })
                    .ToList();

                // If ProductSubjectTypes is empty but getCategory has values, add a default entry
                if (!productSubjectTypes.Any() && categoryAttributes.Any())
                {
                    subjectTypeResponses.Add(new SubjectTypeResponse
                    {
                        Id = 0, // Default ID since there are no ProductSubjectTypes
                        SubjectTypeId = 0,
                        CategoryName = "General Category Attributes", // A default name
                        Attributes = categoryAttributes
                    });
                }
            }

            // Load Base and Additional covers list
            var baseCoversList = product.ProductBaseSubjectTypeCovers.Select(x => x.BaseCoverId).Distinct().ToList();
            var additionalCoverList = product.ProductAdditionalSubjectTypeCovers.Select(x => x.AdditionalCoverId).Distinct().ToList();

            var baseCoverNamesResponse = await _adminService.RiderNamesById(baseCoversList);
            var additionalCoverNamesResponse = await _adminService.RiderNamesById(additionalCoverList);

            var baseCoverDict = baseCoversList.Zip(baseCoverNamesResponse.Data ?? new List<string>(), (id, name) => new { id, name })
                                              .ToDictionary(x => x.id, x => x.name);

            var additionalCoverDict = additionalCoverList.Zip(additionalCoverNamesResponse.Data ?? new List<string>(), (id, name) => new { id, name })
                                                         .ToDictionary(x => x.id, x => x.name);

            // Fetch base covers
            var baseCovers = await _rubyContext.ProductBaseCovers
                .Where(p => p.ProductId == productId)
                .Select(p => new ProductBaseSubjectTypeCoverResponse
                {
                    Id = p.Id,
                    CoverStatus = CoverStatusConstants.MapCoverStatus(p.CoverStatus),
                    BaseCoverId = p.BaseCoverId,
                    CoverName = baseCoverDict.ContainsKey(p.BaseCoverId) ? baseCoverDict[p.BaseCoverId] : "Unknown",
                    LimitType = p.LimitType,
                    RateTable = p.RateTable,
                    RateApplied = p.RateApplied,
                    DisplayFormula = p.DisplayFormula,
                    MaximumAmount = p.MaximumAmount
                })
                .ToListAsync();

            // Fetch additional covers
            var additionalCovers = await _rubyContext.ProductAdditionalCovers
                .Where(p => p.ProductId == productId)
                .Select(p => new ProductAdditionalSubjectTypeCoverResponse
                {
                    Id = p.Id,
                    CoverStatus = CoverStatusConstants.MapCoverStatus(p.CoverStatus),
                    CoverName = additionalCoverDict.ContainsKey(p.AdditionalCoverId) ? additionalCoverDict[p.AdditionalCoverId] : "Unknown",
                    AdditionalCoverId = p.AdditionalCoverId,
                    LimitType = p.LimitType,
                    RateTable = p.RateTable,
                    MaximumAmount = p.MaximumAmount,
                    RateApplied = p.RateApplied,
                    DisplayFormula = p.DisplayFormula
                })
                .ToListAsync();
            // Fetch payment frequencies
            var paymentFrequencies = await _rubyContext.ProductAllowedPaymentFrequencies
                .Where(p => p.ProductId == productId)
                .Select(p => new PaymentFrequencyResponse
                {
                    PaymentFrequencyId = p.Id,
                    PaymentFrequency = p.PaymentFrequency
                })
                .ToListAsync();

            // Fetch product documents
            var documents = await _rubyContext.ProductDocumentCategories.Include(d => d.ProductDocuments)
                .Where(p => p.ProductId == productId)
                .Select(p => new ProductCategoryDocumentResponse
                {
                    Id = p.Id,
                    Category = p.CategoryName,
                    SubCategory = p.SubCategory,
                    ProductDocuments = p.ProductDocuments.Select(d => new ProductDocumentResponse()
                    {
                        Id = d.Id,
                        Name = d.Name,
                        Size = d.Size,
                        Format = d.Format,
                        IsRequired = d.IsRequired
                    }).ToList(),
                }).ToListAsync();

            var costTypeIds = product.ProductCostType.Select(c => c.CostTypeId).Distinct().ToList();
            var costTypeNamesResponse = await _adminService.GetCostTypeNamesById(costTypeIds);
            var costTypeNames = costTypeNamesResponse.Data ?? new List<string>();


            var costTypeNameDict = costTypeIds.Zip(costTypeNames, (id, name) => new { id, name })
                                              .ToDictionary(x => x.id, x => x.name);


            var costTypes = await _rubyContext.ProductCostTypes
                .Where(p => p.ProductId == productId)
                .Select(p => new CostTypeResponse
                {
                    Id = p.Id,
                    CostType = p.CostTypeId,
                    CostTypeName = costTypeNameDict.ContainsKey(p.CostTypeId) ? costTypeNameDict[p.CostTypeId] : "Unknown",
                    Remark = p.Remark
                })
                .ToListAsync();


            var costOfInsuranceIds = product.ProductCostOfInsurances.Select(c => c.CollectionSourceId).Distinct().ToList();
            var costOfInsuranceNameResponse = await _adminService.GetCostOfInsuranceNamesById(costOfInsuranceIds);
            var costOfInsuranceNames = costTypeNamesResponse.Data ?? new List<string>();

            var costofInsuranceNameDict = costOfInsuranceIds.Zip(costOfInsuranceNames, (id, name) => new { id, name })
                                                            .ToDictionary(x => x.id, x => x.name);
            // Fetch cost of insurances
            var costOfInsurances = await _rubyContext.ProductCostOfInsurances
                .Where(p => p.ProductId == productId)
                .Select(p => new CostOfInsuranceResponse
                {
                    Id = p.ProductId,
                    CostTypeId = p.CostTypeId,
                    CostypeName = costofInsuranceNameDict.ContainsKey(p.CostTypeId) ? costofInsuranceNameDict[p.CostTypeId] : "Unknown",
                    Year = p.Year,
                    TermValue = p.TermValue,
                    Rate = p.Rate,
                    CostBearer = p.CostBearer,
                    CollectionSourceId = p.CollectionSourceId,
                    CollectionSourceName = costofInsuranceNameDict.ContainsKey(p.CollectionSourceId) ? costofInsuranceNameDict[p.CollectionSourceId] : "Unknown",
                    DisplayFormula = p.DisplayFormula
                })
                .ToListAsync();


            // Build the final response
            var productResponse = new GetSingleProductResponse
            {
                Id = product.Id,
                ProductName = product.Name,
                ProductDescription = product.Description,
                ProductClassId = product.ProductClassId,
                VariantId = product.VariantId,
                Code = product.Code,
                Alias = product.Alias,
                ApprovalStatus = product.ApprovalStatus,
                RequiresUnderwriter = product.RequiresUnderWriter,
                PaymentFrequencies = paymentFrequencies,
                SubjectTypes = subjectTypeResponses, 
                Documents = documents,
                BaseSubjectTypeCovers = baseCovers,
                AdditionalSubjectTypeCovers = additionalCovers,
                CostTypes = costTypes,
                CostOfInsurances = costOfInsurances,
                DropdownMappings = dropdownMappings
            };

            response.Success = true;
            response.ResponseMessage = "Product details retrieved successfully";
            response.Data = productResponse;
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return response;
        }
        //public async Task<BaseResponse<QuotationCodeResponse>> CreateQuotation(QuotationCreateRequest request)
        //{
        //    var response = new BaseResponse<QuotationCodeResponse>();


        //    // Check for a customer name, fallback to 'Anonymous' if missing
        //    string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

        //    // Validate business type and ensure LostRatio is supplied for Renewals
        //    var businessType = await _rubyContext.BusinessTypes.FirstOrDefaultAsync(x => x.Id == request.BusinessTypeId);
        //    if (businessType?.Name == "Renewal" && request.LostRatio == 0)
        //    {
        //        return ResponseFactory.CreateError<QuotationCodeResponse>($"Please supply lost ratio because this is {businessType.Name}",HttpStatusCode.BadRequest);
        //    }

        //    // Validate product existence
        //    var product = await _rubyContext.Products.SingleOrDefaultAsync(x => x.Id == request.ProductId);
        //    if (product == null)
        //    {
        //        return ResponseFactory.CreateError<QuotationCodeResponse>($"Product with the specified Id {request.ProductId} does not exist", HttpStatusCode.BadRequest);
        //    }

        //    // Retrieve subject attributes
        //    var subjectAttributes = await _rubyContext.ProductSubjectTypes
        //        .Include(s => s.ProductSubjectTypeAttributes)
        //        .FirstOrDefaultAsync(s => s.ProductId == request.ProductId);

        //    if (subjectAttributes == null)
        //    {
        //        return ResponseFactory.CreateError<QuotationCodeResponse>($"Subject attributes not found for Product Id {request.ProductId}", HttpStatusCode.BadRequest);
        //    }

        //    var quoteStatus = product?.RequiresUnderWriter == true
        //        ? QuotationStatus.RequireUnderWriting.ToString()
        //        : QuotationStatus.Pending.ToString();

        //    // Generate quotation code
        //    string quotationCode = GetNextQuotationCode(_rubyContext).ToString();

        //    var costOfInsurance = await _rubyContext.ProductCostOfInsurances
        //        .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);

        //    if (costOfInsurance == null)
        //    {
        //        return ResponseFactory.CreateError<QuotationCodeResponse>($"Cost of insurance not found ", HttpStatusCode.NotFound);
        //    }

        //    // Fetch base covers for the product that are not inclusive
        //    var baseCovers = await _rubyContext.ProductBaseCovers
        //        .Where(bc => bc.ProductId == request.ProductId)

        //        .ToListAsync();

        //    // Fetch additional covers for the product that are not inclusive
        //    var additionalCovers = await _rubyContext.ProductAdditionalCovers
        //        .Where(ac => ac.ProductId == request.ProductId)

        //        .ToListAsync();


        //   var productPricing = await _rubyContext.ProductSubjectCategories
        //                        .Include(d=>d.ProductPriceConfigurations)
        //                        .Where(d=>d.ProductId == request.ProductId)
        //                        .ToListAsync();



        //    // Create the new quotation object
        //    var quotation = new Quotation
        //    {
        //        ProductClass = request.ProductClass,
        //        QuoteId = quotationCode,
        //        BusinessTypeId = request.BusinessTypeId,
        //        QuotePreferencesId = request.QuotePreferencesId,
        //        QuoteTypeId = request.QuoteTypeId,
        //        PolicyDurationId = request.PolicyDurationId,
        //        ProductId = request.ProductId,
        //        RiskLocation = request.RiskLocation,
        //        StateOfOperation = request.StateOfOperation,
        //        Channel = request.Channel,
        //        CreateAt = DateTime.UtcNow,
        //        CreateBy = UserClaims(),
        //        Customer = customerName,
        //        SLA = CalculateSLAInMinutes(),
        //        Rate = 0,
        //        LostRatio = request.LostRatio,
        //        SLAUsage = 0,
        //        QuoteStatus = quoteStatus,
        //        VersionNumber = 1,
        //        IsActive = true,
        //        CustomerNumber = request.CustomerNumber,
        //        RequiresUnderwritingApproval= false,
        //    };

        //    // Transaction to ensure atomicity
        //    using var transaction = await _rubyContext.Database.BeginTransactionAsync();
        //    try
        //    {
        //        // Add and save quotation
        //        _rubyContext.Quotations.Add(quotation);
        //        await _rubyContext.SaveChangesAsync();

        //        Guid entityId = Guid.NewGuid();
        //        decimal TotalPremium = 0;
        //        decimal totalCoverPrice = 0;
        //        // Add Base Covers
        //        var quotationBaseCovers = request.BaseCoverRequest.Select(baseCover => 
        //        {
        //             var matchingBaseCover = baseCovers.FirstOrDefault(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);
        //             decimal baseCoverPremium = 0;

        //            if (matchingBaseCover != null)
        //            {
        //                if(matchingBaseCover.isFixed)
        //                {
        //                    baseCoverPremium = matchingBaseCover.FixedPremium ?? 0;
        //                }
        //                else
        //                {
        //                    baseCoverPremium = (matchingBaseCover.RateApplied / 100) * matchingBaseCover.MaximumAmount;
        //                }

        //                TotalPremium += baseCoverPremium; // Add to total sum insured
        //                totalCoverPrice += baseCover.Price;
        //            }
        //            return new QuotationBaseCover
        //            {
        //                EntityId = entityId,
        //                ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
        //                CoverName = baseCover.CoverName,
        //                CoverStatus = baseCover.CoverStatus,
        //                Price = baseCover.Price,
        //                QuotationId = quotation.Id
        //            };
        //        }).ToList();
        //        _rubyContext.QuotationBaseCovers.AddRange(quotationBaseCovers);

        //        // Add Additional Covers
        //        var quotationAdditionalCovers = request.AdditionalCoverRequest.Select(additionalCover => 
        //        {
        //            var matchingAdditionalCover = additionalCovers.FirstOrDefault(bc => bc.Id == additionalCover.ProductBaseSubjectTypeCoverId);
        //            decimal additionalCoverPremium = 0;

        //            if (matchingAdditionalCover != null)
        //            {
        //                if (matchingAdditionalCover.isFixed) {
        //                    additionalCoverPremium = matchingAdditionalCover.FixedPremium ?? 0;
        //                }
        //                else
        //                {
        //                    additionalCoverPremium = (matchingAdditionalCover.RateApplied / 100) * matchingAdditionalCover.MaximumAmount;
        //                }

        //                TotalPremium += additionalCoverPremium;
        //                totalCoverPrice += additionalCover.Price;
        //            }


        //            return new QuotationAdditionalCover
        //            {
        //                EntityId = entityId,
        //                ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
        //                CoverStatus = additionalCover.CoverStatus,
        //                CoverName = additionalCover.CoverName,
        //                Price = additionalCover.Price,
        //                QuotationId = quotation.Id
        //            };
        //        }).ToList();
        //        _rubyContext.QuotationAdditionalCovers.AddRange(quotationAdditionalCovers);

        //        // Add dynamic attributes and calculate sum insured
        //        decimal calculatedSumInsured = 0;

        //        foreach (var attr in request.QuoteAttributes)
        //        {

        //            var attributeMetadata = subjectAttributes.ProductSubjectTypeAttributes
        //                .FirstOrDefault(a => a.Id == attr.AttributeId);

        //            if (attributeMetadata != null)
        //            {
        //                var attributeValueAsString = attr.AttributeValue?.ToString();
        //                var quotationAttribute = new QuotationAttributeValue
        //                {
        //                    QuotationId = quotation.Id,
        //                    AttributeName = attr.AttributeName,
        //                    AttributeValue = attributeValueAsString,
        //                    AttributeId = attr.AttributeId,
        //                    EntityId = entityId

        //                };
        //                _rubyContext.QuotationAttributeValues.Add(quotationAttribute);

        //                if (attributeMetadata.IsSumInsured)
        //                {
        //                    if (decimal.TryParse(attributeValueAsString, out decimal parsedValue))
        //                    {
        //                        calculatedSumInsured += parsedValue;
        //                    }
        //                }
        //            }
        //        }


        //        decimal finalRateApplied = 0;
        //        if (TotalPremium > 0)
        //        {
        //            finalRateApplied = TotalPremium / totalCoverPrice  * 100;
        //        }



        //        quotation.SumInsured = calculatedSumInsured;
        //        quotation.Premium = TotalPremium; 
        //        quotation.Rate = finalRateApplied;

        //        await _rubyContext.SaveChangesAsync();

        //        // Commit the transaction
        //        await transaction.CommitAsync();

        //        // Create and return response
        //        var codeResponse = new QuotationCodeResponse
        //        {
        //            QuotationCode = quotationCode,
        //            QuoteId = quotation.Id
        //        };

        //        return ResponseFactory.CreateSuccess<QuotationCodeResponse>(codeResponse,$"Quote Code Generated Successfully");

        //    }
        //    catch (Exception ex)
        //    {
        //        // Rollback transaction and log error
        //        await transaction.RollbackAsync();
        //        return ResponseFactory.CreateError<QuotationCodeResponse>($"Failed to create quotation: {ex}", HttpStatusCode.InternalServerError);
        //    }

        //}

        #region Create Single Quote

        //public async Task<BaseResponse<QuotationCodeResponse>> CreateQuotation(QuotationCreateRequest request)
        //{
        //    var response = new BaseResponse<QuotationCodeResponse>();


        //    // Check for a customer name, fallback to 'Anonymous' if missing
        //    string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

        //    // Validate business type and ensure LostRatio is supplied for Renewals
        //    var businessType = await _rubyContext.BusinessTypes.FirstOrDefaultAsync(x => x.Id == request.BusinessTypeId);
        //    if (businessType?.Name == "Renewal" && request.LostRatio == 0)
        //    {
        //        return ResponseFactory.CreateError<QuotationCodeResponse>($"Please supply lost ratio because this is {businessType.Name}", HttpStatusCode.BadRequest);
        //    }

        //    // Validate product existence
        //    var product = await _rubyContext.Products.SingleOrDefaultAsync(x => x.Id == request.ProductId);
        //    if (product == null)
        //    {
        //        return ResponseFactory.CreateError<QuotationCodeResponse>($"Product with the specified Id {request.ProductId} does not exist", HttpStatusCode.BadRequest);
        //    }

        //    // Retrieve subject attributes
        //    var subjectAttributes = await _rubyContext.ProductSubjectTypes
        //        .Include(s => s.ProductSubjectTypeAttributes)
        //        .FirstOrDefaultAsync(s => s.ProductId == request.ProductId);

        //    if (subjectAttributes == null)
        //    {
        //        return ResponseFactory.CreateError<QuotationCodeResponse>($"Subject attributes not found for Product Id {request.ProductId}", HttpStatusCode.BadRequest);
        //    }

        //    var quoteStatus = product?.RequiresUnderWriter == true
        //        ? QuotationStatus.RequireUnderWriting.ToString()
        //        : QuotationStatus.Pending.ToString();

        //    // Generate quotation code
        //    string quotationCode = GetNextQuotationCode(_rubyContext).ToString();

        //    var costOfInsurance = await _rubyContext.ProductCostOfInsurances
        //        .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);

        //    if (costOfInsurance == null)
        //    {
        //        return ResponseFactory.CreateError<QuotationCodeResponse>($"Cost of insurance not found ", HttpStatusCode.NotFound);
        //    }

        //    // Fetch base covers for the product that are not inclusive
        //    var baseCovers = await _rubyContext.ProductBaseCovers
        //        .Where(bc => bc.ProductId == request.ProductId)

        //        .ToListAsync();

        //    // Fetch additional covers for the product that are not inclusive
        //    var additionalCovers = await _rubyContext.ProductAdditionalCovers
        //        .Where(ac => ac.ProductId == request.ProductId)

        //        .ToListAsync();


        //    var productPricing = await _rubyContext.ProductSubjectCategories
        //                         .Include(d => d.ProductPriceConfigurations)
        //                         .Where(d => d.ProductId == request.ProductId)
        //                         .ToListAsync();



        //    // Create the new quotation object
        //    var quotation = new Quotation
        //    {
        //        ProductClass = request.ProductClass,
        //        QuoteId = quotationCode,
        //        BusinessTypeId = request.BusinessTypeId,
        //        QuotePreferencesId = request.QuotePreferencesId,
        //        QuoteTypeId = request.QuoteTypeId,
        //        PolicyDurationId = request.PolicyDurationId,
        //        ProductId = request.ProductId,
        //        RiskLocation = request.RiskLocation,
        //        StateOfOperation = request.StateOfOperation,
        //        Channel = request.Channel,
        //        CreateAt = DateTime.UtcNow,
        //        CreateBy = UserClaims(),
        //        Customer = customerName,
        //        SLA = CalculateSLAInMinutes(),
        //        Rate = 0,
        //        LostRatio = request.LostRatio,
        //        SLAUsage = 0,
        //        QuoteStatus = quoteStatus,
        //        VersionNumber = 1,
        //        IsActive = true,
        //        CustomerNumber = request.CustomerNumber,
        //        RequiresUnderwritingApproval = false,
        //    };

        //    // Transaction to ensure atomicity
        //    using var transaction = await _rubyContext.Database.BeginTransactionAsync();
        //    try
        //    {
        //        // Add and save quotation
        //        _rubyContext.Quotations.Add(quotation);
        //        await _rubyContext.SaveChangesAsync();


        //        // Get category IDs for base covers and additional covers
        //        var categoryIds = await _rubyContext.ProductCategorySelections
        //            .Where(d => d.ProductId == request.ProductId)
        //            .Select(d => d.CategoryId)
        //            .Distinct()
        //            .ToListAsync();

        //        var getCategory = await _rubyContext.LineOfBusinessAttributeItems
        //            .Where(d => categoryIds.Contains(d.CategoryId) && d.RequiredAtQuoting)
        //            .ToListAsync();

        //        Guid entityId = Guid.NewGuid();
        //        decimal TotalPremium = 0;
        //        decimal totalCoverPrice = 0;
        //        decimal calculatedSumInsured = 0;

        //        var productCategory = await _rubyContext.ProductSubjectCategories
        //      .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);

        //        var priceConfigs = await _rubyContext.ProductPriceConfigurations
        //            .Where(p => p.CategoryId == productCategory.Id)
        //            .ToListAsync();

        //        // Add Base Covers
        //        var quotationBaseCovers = request.BaseCoverRequest.Select(baseCover =>
        //        {
        //            var matchingBaseCover = baseCovers.FirstOrDefault(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);
        //            decimal baseCoverPremium = 0;

        //            if (matchingBaseCover != null)
        //            {
        //                if (matchingBaseCover.isFixed)
        //                {
        //                    baseCoverPremium = matchingBaseCover.FixedPremium ?? 0;
        //                }
        //                else
        //                {
        //                    baseCoverPremium = (matchingBaseCover.RateApplied / 100) * matchingBaseCover.MaximumAmount;
        //                }

        //                TotalPremium += baseCoverPremium; // Add to total sum insured
        //                totalCoverPrice += baseCover.Price;
        //            }

        //            foreach (var attr in request.QuoteAttributes)
        //            {
        //                var config = priceConfigs.FirstOrDefault(p =>
        //                    p.AttributeName == attr.AttributeValue.GetString() &&
        //                    p.CoverIds.Contains(matchingBaseCover.BaseCoverId));

        //                if (config != null)
        //                {
        //                    if (config.Affects == "Sum Assured")
        //                    {
        //                        baseCoverPremium += baseCover.Price * config.AffectRate;
        //                    }
        //                    else if (config.Affects == "Final quote")
        //                    {
        //                        calculatedSumInsured += calculatedSumInsured * config.AffectRate;
        //                    }

        //                    var auditLog = new QuotationPriceCalculationAudit
        //                    {
        //                        QuoteId = quotation.Id,
        //                        AttributeId = attr.AttributeId,
        //                        CoverId = matchingBaseCover.BaseCoverId,
        //                        AppliedRate = config.AffectRate,
        //                        AdjustedPremium = baseCoverPremium,
        //                        Affects = config.Affects,
        //                        Timestamp = DateTime.UtcNow,
        //                        Comment = "Applied attribute to base cover and modified premium based on configuration."
        //                    };

        //                    _rubyContext.QuotationPriceCalculationAudits.Add(auditLog);
        //                }
        //            }

        //            return new QuotationBaseCover
        //            {
        //                EntityId = entityId,
        //                ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
        //                CoverName = baseCover.CoverName,
        //                CoverStatus = baseCover.CoverStatus,
        //                Price = baseCover.Price,
        //                QuotationId = quotation.Id
        //            };


        //        }).ToList();
        //        _rubyContext.QuotationBaseCovers.AddRange(quotationBaseCovers);



        //        // Add Additional Covers
        //        var quotationAdditionalCovers = request.AdditionalCoverRequest.Select(additionalCover =>
        //        {
        //            var matchingAdditionalCover = additionalCovers.FirstOrDefault(bc => bc.Id == additionalCover.ProductBaseSubjectTypeCoverId);
        //            decimal additionalCoverPremium = 0;

        //            if (matchingAdditionalCover != null)
        //            {
        //                if (matchingAdditionalCover.isFixed)
        //                {
        //                    additionalCoverPremium = matchingAdditionalCover.FixedPremium ?? 0;
        //                }
        //                else
        //                {
        //                    additionalCoverPremium = (matchingAdditionalCover.RateApplied / 100) * matchingAdditionalCover.MaximumAmount;
        //                }

        //                TotalPremium += additionalCoverPremium;
        //                totalCoverPrice += additionalCover.Price;
        //            }

        //            foreach (var attr in request.QuoteAttributes)
        //            {
        //                var config = priceConfigs.FirstOrDefault(p =>
        //                    p.AttributeName == attr.AttributeValue.GetString() &&
        //                    p.CoverIds.Contains(matchingAdditionalCover.AdditionalCoverId));

        //                if (config != null)
        //                {
        //                    if (config.Affects == "Sum Assured")
        //                    {
        //                        additionalCoverPremium += additionalCover.Price * config.AffectRate;
        //                    }
        //                    else if (config.Affects == "Final quote")
        //                    {
        //                        calculatedSumInsured += calculatedSumInsured * config.AffectRate;
        //                    }

        //                    var auditLog = new QuotationPriceCalculationAudit
        //                    {
        //                        QuoteId = quotation.Id,
        //                        AttributeId = attr.AttributeId,
        //                        CoverId = matchingAdditionalCover.AdditionalCoverId,
        //                        AppliedRate = config.AffectRate,
        //                        AdjustedPremium = additionalCoverPremium,
        //                        Affects = config.Affects,
        //                        Timestamp = DateTime.UtcNow,
        //                        Comment = "Applied attribute to base cover and modified premium based on configuration."
        //                    };

        //                    _rubyContext.QuotationPriceCalculationAudits.Add(auditLog);
        //                }
        //            }


        //            return new QuotationAdditionalCover
        //            {
        //                EntityId = entityId,
        //                ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
        //                CoverStatus = additionalCover.CoverStatus,
        //                CoverName = additionalCover.CoverName,
        //                Price = additionalCover.Price,
        //                QuotationId = quotation.Id
        //            };




        //        }).ToList();
        //        _rubyContext.QuotationAdditionalCovers.AddRange(quotationAdditionalCovers);

        //        // Add dynamic attributes and calculate sum insured


        //        foreach (var attr in request.QuoteAttributes)
        //        {

        //            var attributeMetadata = subjectAttributes.ProductSubjectTypeAttributes
        //                .FirstOrDefault(a => a.Id == attr.AttributeId);

        //            var businessattributeMetadata = getCategory
        //                   .FirstOrDefault(a => a.Id == attr.AttributeId);

        //            if (attributeMetadata != null || businessattributeMetadata != null)
        //            {
        //                var attributeValueAsString = attr.AttributeValue?.ToString();

        //                var quotationAttribute = new QuotationAttributeValue
        //                {
        //                    QuotationId = quotation.Id,
        //                    AttributeName = attr.AttributeName,
        //                    AttributeValue = attributeValueAsString,
        //                    AttributeId = attr.AttributeId,
        //                    EntityId = attr.EntityId
        //                };

        //                _rubyContext.QuotationAttributeValues.Add(quotationAttribute);

        //                // Update sum insured calculation
        //                decimal parsedValue = 0;
        //                bool isSumInsured = attributeMetadata?.IsSumInsured == true || businessattributeMetadata?.IsSumAssured == true;
        //                if (isSumInsured && decimal.TryParse(attributeValueAsString, out parsedValue))
        //                {
        //                    calculatedSumInsured += parsedValue;
        //                }
        //            }
        //        }

        //        // Process price config and audit logs for base covers

        //        decimal finalRateApplied = 0;
        //        if (TotalPremium > 0)
        //        {
        //            finalRateApplied = TotalPremium / totalCoverPrice * 100;
        //        }



        //        quotation.SumInsured = calculatedSumInsured;
        //        quotation.Premium = TotalPremium;
        //        quotation.Rate = finalRateApplied;

        //        await _rubyContext.SaveChangesAsync();

        //        // Commit the transaction
        //        await transaction.CommitAsync();

        //        // Create and return response
        //        var codeResponse = new QuotationCodeResponse
        //        {
        //            QuotationCode = quotationCode,
        //            QuoteId = quotation.Id
        //        };

        //        return ResponseFactory.CreateSuccess<QuotationCodeResponse>(codeResponse, $"Quote Code Generated Successfully");

        //    }
        //    catch (Exception ex)
        //    {
        //        // Rollback transaction and log error
        //        await transaction.RollbackAsync();
        //        return ResponseFactory.CreateError<QuotationCodeResponse>($"Failed to create quotation: {ex}", HttpStatusCode.InternalServerError);
        //    }

        //}


        public async Task<BaseResponse<QuotationCodeResponse>> CpreateQuotation(QuotationCreateRequest request)
        {
            var response = new BaseResponse<QuotationCodeResponse>();

            // Check for a customer name, fallback to 'Anonymous' if missing
            string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

            // Check if a quotation already exists for this customer
            var existingQuotation = await _rubyContext.Quotations
                .FirstOrDefaultAsync(q => q.Customer == customerName && q.ProductId == request.ProductId && q.QuoteStatus != "Closed");

            //if (existingQuotation != null)
            //{
            //    return ResponseFactory.CreateError<QuotationCodeResponse>(
            //        $"A quotation already exists for this customer ({customerName}) with the same product. Please check the quotation status.",
            //        HttpStatusCode.Conflict);
            //}

            // Validate business type and ensure LostRatio is supplied for Renewals
            var businessType = await _rubyContext.BusinessTypes.FirstOrDefaultAsync(x => x.Id == request.BusinessTypeId);
            if (businessType?.Name == "Renewal" && request.LostRatio == 0)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Please supply lost ratio because this is {businessType.Name}", HttpStatusCode.BadRequest);
            }

            // Validate product existence
            var product = await _rubyContext.Products.SingleOrDefaultAsync(x => x.Id == request.ProductId);
            if (product == null)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Product with the specified Id {request.ProductId} does not exist", HttpStatusCode.BadRequest);
            }

            // Retrieve subject attributes
            var subjectAttributes = await _rubyContext.ProductSubjectTypes
                .Include(s => s.ProductSubjectTypeAttributes)
                .FirstOrDefaultAsync(s => s.ProductId == request.ProductId);

            if (subjectAttributes == null)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Subject attributes not found for Product Id {request.ProductId}", HttpStatusCode.BadRequest);
            }

            var quoteStatus = product?.RequiresUnderWriter == true
                ? QuotationStatus.RequireUnderWriting.ToString()
                : QuotationStatus.Pending.ToString();

            // Generate quotation code
            string quotationCode = GetNextQuotationCode(_rubyContext).ToString();

            var costOfInsurance = await _rubyContext.ProductCostOfInsurances
                .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);

            if (costOfInsurance == null)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Cost of insurance not found ", HttpStatusCode.NotFound);
            }

            // Fetch base covers for the product that are not inclusive
            var baseCovers = await _rubyContext.ProductBaseCovers
                .Where(bc => bc.ProductId == request.ProductId)
                .ToListAsync();

            // Fetch additional covers for the product that are not inclusive
            var additionalCovers = await _rubyContext.ProductAdditionalCovers
                .Where(ac => ac.ProductId == request.ProductId)
                .ToListAsync();

            var productPricing = await _rubyContext.ProductSubjectCategories
                                  .Include(d => d.ProductPriceConfigurations)
                                  .Where(d => d.ProductId == request.ProductId)
                                  .ToListAsync();

            // Create the new quotation object
            var quotation = new Quotation
            {
                ProductClass = request.ProductClass,
                QuoteId = quotationCode,
                BusinessTypeId = request.BusinessTypeId,
                QuotePreferencesId = request.QuotePreferencesId,
                QuoteTypeId = request.QuoteTypeId,
                PolicyDurationId = request.PolicyDurationId,
                ProductId = request.ProductId,
                RiskLocation = request.RiskLocation,
                StateOfOperation = request.StateOfOperation,
                Channel = request.Channel,
                CreateAt = DateTime.UtcNow,
                CreateBy = UserClaims(),
                Customer = customerName,
                SLA = CalculateSLAInMinutes(),
                Rate = 0,
                LostRatio = request.LostRatio,
                SLAUsage = 0,
                QuoteStatus = quoteStatus,
                VersionNumber = 1,
                IsActive = true,
                CustomerNumber = request.CustomerNumber,
                RequiresUnderwritingApproval = false,
            };

            // Transaction to ensure atomicity
            using var transaction = await _rubyContext.Database.BeginTransactionAsync();
            try
            {
                // Add and save quotation
                _rubyContext.Quotations.Add(quotation);
                await _rubyContext.SaveChangesAsync();

                // Get category IDs for base covers and additional covers
                var categoryIds = await _rubyContext.ProductCategorySelections
                    .Where(d => d.ProductId == request.ProductId)
                    .Select(d => d.CategoryId)
                    .Distinct()
                    .ToListAsync();

                var getCategory = await _rubyContext.LineOfBusinessAttributeItems
                    .Where(d => categoryIds.Contains(d.CategoryId) && d.RequiredAtQuoting)
                    .ToListAsync();

                Guid entityId = Guid.NewGuid();
                decimal TotalPremium = 0;
                decimal totalCoverPrice = 0;
                decimal calculatedSumInsured = 0;

                var productCategory = await _rubyContext.ProductSubjectCategories
                    .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);

                var priceConfigs = await _rubyContext.ProductPriceConfigurations
                    .Where(p => p.CategoryId == productCategory.Id)
                    .ToListAsync();

                // Add Base Covers
                var quotationBaseCovers = request.BaseCoverRequest.Select(baseCover =>
                {
                    var matchingBaseCover = baseCovers.FirstOrDefault(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);
                    decimal baseCoverPremium = 0;

                    if (matchingBaseCover != null)
                    {
                        if (matchingBaseCover.isFixed)
                        {
                            baseCoverPremium = matchingBaseCover.FixedPremium ?? 0;
                        }
                        else
                        {
                            baseCoverPremium = (matchingBaseCover.RateApplied / 100) * matchingBaseCover.MaximumAmount;
                        }

                        TotalPremium += baseCoverPremium; // Add to total sum insured
                        totalCoverPrice += baseCover.Price;
                    }

                    foreach (var attr in request.QuoteAttributes)
                    {
                        var config = priceConfigs.FirstOrDefault(p =>
                            p.AttributeName == attr.AttributeValue.GetString() &&
                            p.CoverIds.Contains(matchingBaseCover.BaseCoverId));

                        if (config != null)
                        {
                            if (config.Affects == "Sum Assured")
                            {
                                baseCoverPremium += baseCover.Price * config.AffectRate;
                            }
                            else if (config.Affects == "Final quote")
                            {
                                calculatedSumInsured += calculatedSumInsured * config.AffectRate;
                            }

                            var auditLog = new QuotationPriceCalculationAudit
                            {
                                QuoteId = quotation.Id,
                                AttributeId = attr.AttributeId,
                                CoverId = matchingBaseCover.BaseCoverId,
                                AppliedRate = config.AffectRate,
                                AdjustedPremium = baseCoverPremium,
                                Affects = config.Affects,
                                Timestamp = DateTime.UtcNow,
                                Comment = "Applied attribute to base cover and modified premium based on configuration."
                            };

                            _rubyContext.QuotationPriceCalculationAudits.Add(auditLog);
                        }
                    }

                    return new QuotationBaseCover
                    {
                        EntityId = entityId,
                        ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
                        CoverName = baseCover.CoverName,
                        CoverStatus = baseCover.CoverStatus,
                        Price = baseCover.Price,
                        QuotationId = quotation.Id
                    };

                }).ToList();

                // Ensure Base Covers are added to the context properly
                _rubyContext.QuotationBaseCovers.AddRange(quotationBaseCovers);

                // Add Additional Covers
                var quotationAdditionalCovers = request.AdditionalCoverRequest.Select(additionalCover =>
                {
                    var matchingAdditionalCover = additionalCovers.FirstOrDefault(bc => bc.Id == additionalCover.ProductBaseSubjectTypeCoverId);
                    decimal additionalCoverPremium = 0;

                    if (matchingAdditionalCover != null)
                    {
                        if (matchingAdditionalCover.isFixed)
                        {
                            additionalCoverPremium = matchingAdditionalCover.FixedPremium ?? 0;
                        }
                        else
                        {
                            additionalCoverPremium = (matchingAdditionalCover.RateApplied / 100) * matchingAdditionalCover.MaximumAmount;
                        }

                        TotalPremium += additionalCoverPremium;
                        totalCoverPrice += additionalCover.Price;
                    }

                    foreach (var attr in request.QuoteAttributes)
                    {
                        var config = priceConfigs.FirstOrDefault(p =>
                            p.AttributeName == attr.AttributeValue.GetString() &&
                            p.CoverIds.Contains(matchingAdditionalCover.AdditionalCoverId));

                        if (config != null)
                        {
                            if (config.Affects == "Sum Assured")
                            {
                                additionalCoverPremium += additionalCover.Price * config.AffectRate;
                            }
                            else if (config.Affects == "Final quote")
                            {
                                calculatedSumInsured += calculatedSumInsured * config.AffectRate;
                            }

                            var auditLog = new QuotationPriceCalculationAudit
                            {
                                QuoteId = quotation.Id,
                                AttributeId = attr.AttributeId,
                                CoverId = matchingAdditionalCover.AdditionalCoverId,
                                AppliedRate = config.AffectRate,
                                AdjustedPremium = additionalCoverPremium,
                                Affects = config.Affects,
                                Timestamp = DateTime.UtcNow,
                                Comment = "Applied attribute to additional cover and modified premium based on configuration."
                            };

                            _rubyContext.QuotationPriceCalculationAudits.Add(auditLog);
                        }
                    }

                    return new QuotationAdditionalCover
                    {
                        EntityId = entityId,
                        ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
                        CoverStatus = additionalCover.CoverStatus,
                        CoverName = additionalCover.CoverName,
                        Price = additionalCover.Price,
                        QuotationId = quotation.Id
                    };

                }).ToList();

                // Ensure Additional Covers are added to the context properly
                _rubyContext.QuotationAdditionalCovers.AddRange(quotationAdditionalCovers);

                // Add dynamic attributes and calculate sum insured
                foreach (var attr in request.QuoteAttributes)
                {
                    var attributeMetadata = subjectAttributes.ProductSubjectTypeAttributes
                        .FirstOrDefault(a => a.Id == attr.AttributeId);

                    var businessattributeMetadata = getCategory
                            .FirstOrDefault(a => a.Id == attr.AttributeId);

                    if (attributeMetadata != null || businessattributeMetadata != null)
                    {
                        var attributeValueAsString = attr.AttributeValue?.ToString();

                        var quotationAttribute = new QuotationAttributeValue
                        {
                            QuotationId = quotation.Id,
                            AttributeName = attr.AttributeName,
                            AttributeValue = attributeValueAsString,
                            AttributeId = attr.AttributeId,
                            EntityId = attr.EntityId
                        };

                        _rubyContext.QuotationAttributeValues.Add(quotationAttribute);
                    }
                }

                // Save the changes within the transaction
                await _rubyContext.SaveChangesAsync();

                // Commit the transaction
                await transaction.CommitAsync();

                //Create and return response

                        var codeResponse = new QuotationCodeResponse
                        {
                            QuotationCode = quotationCode,
                            QuoteId = quotation.Id
                        };

                return ResponseFactory.CreateSuccess<QuotationCodeResponse>(codeResponse, $"Quote Code Generated Successfully");
            }
            catch (Exception ex)
            {
                // Rollback transaction if something goes wrong
                await transaction.RollbackAsync();
                return ResponseFactory.CreateError<QuotationCodeResponse>("An error occurred while creating the quotation.", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<QuotationCodeResponse>> CdeateQuotation(QuotationCreateRequest request)
        {
            var response = new BaseResponse<QuotationCodeResponse>();

            // Check for a customer name, fallback to 'Anonymous' if missing
            string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

            // Validate business type and ensure LostRatio is supplied for Renewals
            var businessType = await _rubyContext.BusinessTypes.FirstOrDefaultAsync(x => x.Id == request.BusinessTypeId);
            if (businessType?.Name == "Renewal" && request.LostRatio == 0)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Please supply lost ratio because this is {businessType.Name}", HttpStatusCode.BadRequest);
            }

            // Validate product existence
            var product = await _rubyContext.Products.SingleOrDefaultAsync(x => x.Id == request.ProductId);
            if (product == null)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Product with the specified Id {request.ProductId} does not exist", HttpStatusCode.BadRequest);
            }

            // Retrieve subject attributes
            var subjectAttributes = await _rubyContext.ProductSubjectTypes
                .Include(s => s.ProductSubjectTypeAttributes)
                .FirstOrDefaultAsync(s => s.ProductId == request.ProductId);

            if (subjectAttributes == null)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Subject attributes not found for Product Id {request.ProductId}", HttpStatusCode.BadRequest);
            }

            var quoteStatus = product?.RequiresUnderWriter == true
                ? QuotationStatus.RequireUnderWriting.ToString()
                : QuotationStatus.Pending.ToString();

            // Generate quotation code
            string quotationCode = GetNextQuotationCode(_rubyContext).ToString();

            var costOfInsurance = await _rubyContext.ProductCostOfInsurances
                .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);

            if (costOfInsurance == null)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Cost of insurance not found ", HttpStatusCode.NotFound);
            }

            // Fetch base covers for the product that are not inclusive
            var baseCovers = await _rubyContext.ProductBaseCovers
                .Where(bc => bc.ProductId == request.ProductId)
                .ToListAsync();

            // Fetch additional covers for the product that are not inclusive
            var additionalCovers = await _rubyContext.ProductAdditionalCovers
                .Where(ac => ac.ProductId == request.ProductId)
                .ToListAsync();

            var productPricing = await _rubyContext.ProductSubjectCategories
                                     .Include(d => d.ProductPriceConfigurations)
                                     .Where(d => d.ProductId == request.ProductId)
                                     .ToListAsync();

            // Get category IDs for base covers and additional covers
            var categoryIds = await _rubyContext.ProductCategorySelections
                .Where(d => d.ProductId == request.ProductId)
                .Select(d => d.CategoryId)
                .Distinct()
                .ToListAsync();

            var getCategory = await _rubyContext.LineOfBusinessAttributeItems
                .Where(d => categoryIds.Contains(d.CategoryId) && d.RequiredAtQuoting)
                .ToListAsync();


            // Create the new quotation object
            var quotation = new Quotation
            {
                ProductClass = request.ProductClass,
                QuoteId = quotationCode,
                BusinessTypeId = request.BusinessTypeId,
                QuotePreferencesId = request.QuotePreferencesId,
                QuoteTypeId = request.QuoteTypeId,
                PolicyDurationId = request.PolicyDurationId,
                ProductId = request.ProductId,
                RiskLocation = request.RiskLocation,
                StateOfOperation = request.StateOfOperation,
                Channel = request.Channel,
                CreateAt = DateTime.UtcNow,
                CreateBy = UserClaims(),
                Customer = customerName,
                SLA = CalculateSLAInMinutes(),
                Rate = 0,
                LostRatio = request.LostRatio,
                SLAUsage = 0,
                QuoteStatus = quoteStatus,
                VersionNumber = 1,
                IsActive = true,
                CustomerNumber = request.CustomerNumber,
                RequiresUnderwritingApproval = false,
            };

            // Transaction to ensure atomicity
            using var transaction = await _rubyContext.Database.BeginTransactionAsync();
            try
            {
                // Add and save quotation
                _rubyContext.Quotations.Add(quotation);
                await _rubyContext.SaveChangesAsync();

                Guid entityId = Guid.NewGuid();
                decimal TotalPremium = 0;
                decimal totalCoverPrice = 0;
                decimal calculatedSumInsured = 0;

                // Add Base Covers
                var quotationBaseCovers = request.BaseCoverRequest.Select(baseCover =>
                {
                    var matchingBaseCover = baseCovers.FirstOrDefault(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);
                    decimal baseCoverPremium = 0;

                    if (matchingBaseCover != null)
                    {
                        if (matchingBaseCover.isFixed)
                        {
                            baseCoverPremium = matchingBaseCover.FixedPremium ?? 0;
                        }
                        else
                        {
                            baseCoverPremium = (matchingBaseCover.RateApplied / 100) * matchingBaseCover.MaximumAmount;
                        }

                        TotalPremium += baseCoverPremium; // Add to total sum insured
                        totalCoverPrice += baseCover.Price;
                      

                        // Missing logic - apply price configurations
                        var priceConfigs = productPricing.SelectMany(p => p.ProductPriceConfigurations);
                        foreach (var attr in request.QuoteAttributes)
                        {
                            var config = priceConfigs.FirstOrDefault(p =>
                                p.AttributeName == attr.AttributeValue?.ToString() &&
                                p.CoverIds.Contains(matchingBaseCover.BaseCoverId));

                            if (config != null)
                            {
                                if (config.Affects == "Sum Assured")
                                {
                                    baseCoverPremium += baseCover.Price * config.AffectRate;
                                }
                                else if (config.Affects == "Final quote")
                                {
                                    calculatedSumInsured += calculatedSumInsured * config.AffectRate;
                                }

                                var auditLog = new QuotationPriceCalculationAudit
                                {
                                    QuoteId = quotation.Id,
                                    AttributeId = attr.AttributeId,
                                    CoverId = matchingBaseCover.BaseCoverId,
                                    AppliedRate = config.AffectRate,
                                    AdjustedPremium = baseCoverPremium,
                                    Affects = config.Affects,
                                    Timestamp = DateTime.UtcNow,
                                    Comment = "Applied attribute to base cover and modified premium based on configuration."
                                };

                                // Save audit log
                                _rubyContext.QuotationPriceCalculationAudits.Add(auditLog);
                            }
                        }
                    }

                    return new QuotationBaseCover
                    {
                        EntityId = entityId,
                        ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
                        CoverName = baseCover.CoverName,
                        CoverStatus = baseCover.CoverStatus,
                        Price = baseCover.Price,
                        QuotationId = quotation.Id
                    };
                }).ToList();
                _rubyContext.QuotationBaseCovers.AddRange(quotationBaseCovers);

                // Add Additional Covers (similar to base covers)
                var quotationAdditionalCovers = request.AdditionalCoverRequest.Select(additionalCover =>
                {
                    var matchingAdditionalCover = additionalCovers.FirstOrDefault(bc => bc.Id == additionalCover.ProductBaseSubjectTypeCoverId);
                    decimal additionalCoverPremium = 0;

                    if (matchingAdditionalCover != null)
                    {
                        if (matchingAdditionalCover.isFixed)
                        {
                            additionalCoverPremium = matchingAdditionalCover.FixedPremium ?? 0;
                        }
                        else
                        {
                            additionalCoverPremium = (matchingAdditionalCover.RateApplied / 100) * matchingAdditionalCover.MaximumAmount;
                        }

                        TotalPremium += additionalCoverPremium; // Add to total sum insured
                        totalCoverPrice += additionalCover.Price;
                    }

                    return new QuotationAdditionalCover
                    {
                        EntityId = entityId,
                        ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
                        CoverStatus = additionalCover.CoverStatus,
                        CoverName = additionalCover.CoverName,
                        Price = additionalCover.Price,
                        QuotationId = quotation.Id
                    };
                }).ToList();
                _rubyContext.QuotationAdditionalCovers.AddRange(quotationAdditionalCovers);

                // Add dynamic attributes and calculate sum insured
               
                foreach (var attr in request.QuoteAttributes)
                {
                    var attributeMetadata = subjectAttributes.ProductSubjectTypeAttributes
                            .FirstOrDefault(a => a.Id == attr.AttributeId);

                    var businessattributeMetadata = getCategory
                        .FirstOrDefault(a => a.Id == attr.AttributeId);

                    if (attributeMetadata != null || businessattributeMetadata != null)
                    {
                        var attributeValueAsString = attr.AttributeValue?.ToString();
                        var quotationAttribute = new QuotationAttributeValue
                        {
                            QuotationId = quotation.Id,
                            AttributeName = attr.AttributeName,
                            AttributeValue = attributeValueAsString,
                            AttributeId = attr.AttributeId,
                            EntityId = entityId
                        };
                        _rubyContext.QuotationAttributeValues.Add(quotationAttribute);

                        decimal parsedValue = 0;
                        bool isSumInsured = attributeMetadata?.IsSumInsured == true || businessattributeMetadata?.IsSumAssured == true;
                        if (isSumInsured && decimal.TryParse(attributeValueAsString, out parsedValue))
                        {
                            calculatedSumInsured += parsedValue;
                        }
                    }
                }

                decimal finalRateApplied = 0;
                if (TotalPremium > 0)
                {
                    finalRateApplied = TotalPremium / totalCoverPrice * 100;
                }

                quotation.SumInsured = calculatedSumInsured;
                quotation.Premium = TotalPremium;
                quotation.Rate = finalRateApplied;

                await _rubyContext.SaveChangesAsync();

                // Commit the transaction
                await transaction.CommitAsync();

                // Create and return response
                var codeResponse = new QuotationCodeResponse
                {
                    QuotationCode = quotationCode,
                    QuoteId = quotation.Id
                };

                return ResponseFactory.CreateSuccess<QuotationCodeResponse>(codeResponse, $"Quote Code Generated Successfully");

            }
            catch (Exception ex)
            {
                // Rollback transaction and log error
                await transaction.RollbackAsync();
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Failed to create quotation: {ex}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<QuotationCodeResponse>> CreateQuotation(QuotationCreateRequest request)
        {
            var response = new BaseResponse<QuotationCodeResponse>();
            _logger.LogInformation("Received request to create quotation for ProductId: {ProductId}", request.ProductId);

            string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

            var businessType = await _rubyContext.BusinessTypes.FirstOrDefaultAsync(x => x.Id == request.BusinessTypeId);
            if (businessType?.Name == "Renewal" && request.LostRatio == 0)
            {
                _logger.LogWarning("Lost Ratio required for renewal quotes.");
                return ResponseFactory.CreateError<QuotationCodeResponse>("Please supply lost ratio because this is Renewal", HttpStatusCode.BadRequest);
            }

            var product = await _rubyContext.Products.SingleOrDefaultAsync(x => x.Id == request.ProductId);
            if (product == null)
            {
                _logger.LogError("Product not found for ID: {ProductId}", request.ProductId);
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Product with the specified Id {request.ProductId} does not exist", HttpStatusCode.BadRequest);
            }

            var subjectAttributes = await _rubyContext.ProductSubjectTypes
                .Include(s => s.ProductSubjectTypeAttributes)
                .FirstOrDefaultAsync(s => s.ProductId == request.ProductId);

            if (subjectAttributes == null)
            {
                _logger.LogError("Subject attributes not found for Product Id: {ProductId}", request.ProductId);
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Subject attributes not found for Product Id {request.ProductId}", HttpStatusCode.BadRequest);
            }

            string quotationCode = GetNextQuotationCode(_rubyContext).ToString();
            var quoteStatus = product.RequiresUnderWriter ? QuotationStatus.RequireUnderWriting.ToString() : QuotationStatus.Pending.ToString();

            var costOfInsurance = await _rubyContext.ProductCostOfInsurances.FirstOrDefaultAsync(d => d.ProductId == request.ProductId);
            if (costOfInsurance == null)
            {
                _logger.LogWarning("No cost of insurance found for product {ProductId}", request.ProductId);
                return ResponseFactory.CreateError<QuotationCodeResponse>("Cost of insurance not found", HttpStatusCode.NotFound);
            }

            var baseCovers = await _rubyContext.ProductBaseCovers.Where(bc => bc.ProductId == request.ProductId).ToListAsync();
            var additionalCovers = await _rubyContext.ProductAdditionalCovers.Where(ac => ac.ProductId == request.ProductId).ToListAsync();

            var productPricing = await _rubyContext.ProductSubjectCategories
                .Include(d => d.ProductPriceConfigurations)
                .Where(d => d.ProductId == request.ProductId)
                .ToListAsync();

            var categoryIds = await _rubyContext.ProductCategorySelections
                .Where(d => d.ProductId == request.ProductId)
                .Select(d => d.CategoryId)
                .Distinct()
                .ToListAsync();

            var getCategory = await _rubyContext.LineOfBusinessAttributeItems
                .Where(d => categoryIds.Contains(d.CategoryId) && d.RequiredAtQuoting)
                .ToListAsync();

            var quotation = new Quotation
            {
                ProductClass = request.ProductClass,
                QuoteId = quotationCode,
                BusinessTypeId = request.BusinessTypeId,
                QuotePreferencesId = request.QuotePreferencesId,
                QuoteTypeId = request.QuoteTypeId,
                PolicyDurationId = request.PolicyDurationId,
                ProductId = request.ProductId,
                RiskLocation = request.RiskLocation,
                StateOfOperation = request.StateOfOperation,
                Channel = request.Channel,
                CreateAt = DateTime.UtcNow,
                CreateBy = UserClaims(),
                Customer = customerName,
                SLA = CalculateSLAInMinutes(),
                Rate = 0,
                LostRatio = request.LostRatio,
                SLAUsage = 0,
                QuoteStatus = quoteStatus,
                VersionNumber = 1,
                IsActive = true,
                CustomerNumber = request.CustomerNumber,
                RequiresUnderwritingApproval = false
            };

            using var transaction = await _rubyContext.Database.BeginTransactionAsync();
            try
            {
                _rubyContext.Quotations.Add(quotation);
                await _rubyContext.SaveChangesAsync();

                Guid entityId = Guid.NewGuid();
                decimal TotalPremium = 0;
                decimal totalCoverPrice = 0;
                decimal calculatedSumInsured = 0;

                var quotationBaseCovers = request.BaseCoverRequest.Select(baseCover =>
                {
                    var matchingBaseCover = baseCovers.FirstOrDefault(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);
                    decimal baseCoverPremium = 0;

                    if (matchingBaseCover != null)
                    {
                        baseCoverPremium = matchingBaseCover.isFixed
                            ? matchingBaseCover.FixedPremium ?? 0
                            : (matchingBaseCover.RateApplied / 100) * matchingBaseCover.MaximumAmount;

                        TotalPremium += baseCoverPremium;
                        totalCoverPrice += baseCover.Price;

                        var priceConfigs = productPricing.SelectMany(p => p.ProductPriceConfigurations);
                        foreach (var attr in request.QuoteAttributes)
                        {
                            var config = priceConfigs.FirstOrDefault(p =>
                                p.AttributeName == attr.AttributeValue?.ToString() &&
                                p.CoverIds.Contains(matchingBaseCover.BaseCoverId));

                            if (config != null)
                            {
                                if (config.Affects == "Sum Assured")
                                {
                                    baseCoverPremium += baseCover.Price * config.AffectRate;
                                }
                                else if (config.Affects == "Final quote")
                                {
                                    calculatedSumInsured += calculatedSumInsured * config.AffectRate;
                                }

                                _rubyContext.QuotationPriceCalculationAudits.Add(new QuotationPriceCalculationAudit
                                {
                                    QuoteId = quotation.Id,
                                    AttributeId = attr.AttributeId,
                                    CoverId = matchingBaseCover.BaseCoverId,
                                    AppliedRate = config.AffectRate,
                                    AdjustedPremium = baseCoverPremium,
                                    Affects = config.Affects,
                                    Timestamp = DateTime.UtcNow,
                                    Comment = "Applied attribute to base cover and modified premium based on configuration."
                                });
                            }
                        }
                    }

                    return new QuotationBaseCover
                    {
                        EntityId = entityId,
                        ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
                        CoverName = baseCover.CoverName,
                        CoverStatus = baseCover.CoverStatus,
                        Price = baseCover.Price,
                        QuotationId = quotation.Id
                    };
                }).ToList();
                _rubyContext.QuotationBaseCovers.AddRange(quotationBaseCovers);

                var quotationAdditionalCovers = request.AdditionalCoverRequest.Select(additionalCover =>
                {
                    var matchingAdditionalCover = additionalCovers.FirstOrDefault(bc => bc.Id == additionalCover.ProductBaseSubjectTypeCoverId);
                    decimal additionalCoverPremium = 0;

                    if (matchingAdditionalCover != null)
                    {
                        additionalCoverPremium = matchingAdditionalCover.isFixed
                            ? matchingAdditionalCover.FixedPremium ?? 0
                            : (matchingAdditionalCover.RateApplied / 100) * matchingAdditionalCover.MaximumAmount;

                        TotalPremium += additionalCoverPremium;
                        totalCoverPrice += additionalCover.Price;
                    }

                    return new QuotationAdditionalCover
                    {
                        EntityId = entityId,
                        ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
                        CoverStatus = additionalCover.CoverStatus,
                        CoverName = additionalCover.CoverName,
                        Price = additionalCover.Price,
                        QuotationId = quotation.Id
                    };
                }).ToList();
                _rubyContext.QuotationAdditionalCovers.AddRange(quotationAdditionalCovers);

                foreach (var attr in request.QuoteAttributes)
                {
                    var attributeMetadata = subjectAttributes.ProductSubjectTypeAttributes
                            .FirstOrDefault(a => a.Id == attr.AttributeId);
                    var businessattributeMetadata = getCategory
                        .FirstOrDefault(a => a.Id == attr.AttributeId);

                    if (attributeMetadata != null || businessattributeMetadata != null)
                    {
                        var value = attr.AttributeValue?.ToString();
                        _rubyContext.QuotationAttributeValues.Add(new QuotationAttributeValue
                        {
                            QuotationId = quotation.Id,
                            AttributeName = attr.AttributeName,
                            AttributeValue = value,
                            AttributeId = attr.AttributeId,
                            EntityId = entityId
                        });

                        decimal parsedValue = 0;
                        bool isSumInsured = attributeMetadata?.IsSumInsured == true || businessattributeMetadata?.IsSumAssured == true;
                        if (isSumInsured && decimal.TryParse(value, out parsedValue))
                        {
                            calculatedSumInsured += parsedValue;
                        }
                    }
                }

                decimal finalRateApplied = TotalPremium > 0 ? TotalPremium / totalCoverPrice * 100 : 0;

                quotation.SumInsured = calculatedSumInsured;
                quotation.Premium = TotalPremium;
                quotation.Rate = finalRateApplied;

                await _rubyContext.SaveChangesAsync();
                await transaction.CommitAsync();

                _logger.LogInformation("Quotation {QuotationCode} created successfully", quotation.QuoteId);

                return ResponseFactory.CreateSuccess(new QuotationCodeResponse
                {
                    QuotationCode = quotation.QuoteId,
                    QuoteId = quotation.Id
                }, "Quote Code Generated Successfully");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                _logger.LogError(ex, "Failed to create quotation for product {ProductId}", request.ProductId);
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Failed to create quotation: {ex.Message}", HttpStatusCode.InternalServerError);
            }

        }

            #endregion






            #region present use
            //public async Task<BaseResponse<QuotationCodeResponse>> CreateBulkQuotation(BulkQuotationCreateRequest request)
            //{
            //    var response = new BaseResponse<QuotationCodeResponse>();

            //    string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

            //    var businessType = await _rubyContext.BusinessTypes.FirstOrDefaultAsync(x => x.Id == request.BusinessTypeId);
            //    if (businessType?.Name == "Renewal" && request.LostRatio == 0)
            //    {
            //        response.Success = false;
            //        response.ResponseMessage = $"Please supply lost ratio because this is {businessType.Name}";
            //        response.StatusCode = HttpStatusCode.BadRequest;
            //        return response;
            //    }

            //    var product = await _rubyContext.Products.SingleOrDefaultAsync(x => x.Id == request.ProductId);
            //    if (product == null)
            //    {
            //        response.Success = false;
            //        response.ResponseMessage = $"Product with the specified Id {request.ProductId} does not exist";
            //        response.StatusCode = HttpStatusCode.BadRequest;
            //        return response;
            //    }

            //    var subjectAttributes = await _rubyContext.ProductSubjectTypes
            //        .Include(s => s.ProductSubjectTypeAttributes)
            //        .FirstOrDefaultAsync(s => s.ProductId == request.ProductId);

            //    if (subjectAttributes == null)
            //    {
            //        response.Success = false;
            //        response.ResponseMessage = $"Subject attributes not found for Product Id {request.ProductId}";
            //        response.StatusCode = HttpStatusCode.BadRequest;
            //        return response;
            //    }

            //    var minitestResponse = await Minitest(request.QuoteDetails, request.ProductId);
            //    if (!minitestResponse.Success)
            //    {
            //        return ResponseFactory.CreateError<QuotationCodeResponse>(minitestResponse.ResponseMessage, minitestResponse.StatusCode);
            //    }

            //    var quoteStatus = product?.RequiresUnderWriter == true
            //        ? QuotationStatus.RequireUnderWriting.ToString()
            //        : QuotationStatus.Pending.ToString();

            //    string quotationCode = GetNextQuotationCode(_rubyContext).ToString();

            //    var costOfInsurance = await _rubyContext.ProductCostOfInsurances
            //        .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);

            //    if (costOfInsurance == null)
            //    {
            //        response.Success = false;
            //        response.ResponseMessage = "Cost of insurance not found.";
            //        response.StatusCode = HttpStatusCode.BadRequest;
            //        return response;
            //    }

            //    var baseCovers = await _rubyContext.ProductBaseCovers
            //        .Where(bc => bc.ProductId == request.ProductId).ToListAsync();

            //    var additionalCovers = await _rubyContext.ProductAdditionalCovers
            //        .Where(ac => ac.ProductId == request.ProductId).ToListAsync();

            //    var quotation = new Quotation
            //    {
            //        ProductClass = request.ProductClass,
            //        QuoteId = quotationCode,
            //        BusinessTypeId = request.BusinessTypeId,
            //        QuotePreferencesId = request.QuotePreferencesId,
            //        QuoteTypeId = request.QuoteTypeId,
            //        PolicyDurationId = request.PolicyDurationId,
            //        ProductId = request.ProductId,
            //        RiskLocation = request.RiskLocation,
            //        StateOfOperation = request.StateOfOperation,
            //        Channel = request.Channel,
            //        CreateAt = DateTime.UtcNow,
            //        CreateBy = UserClaims(),
            //        Customer = customerName,
            //        SLA = CalculateSLAInMinutes(),
            //        Rate = 0,
            //        LostRatio = request.LostRatio,
            //        SLAUsage = 0,
            //        QuoteStatus = quoteStatus,
            //        VersionNumber = 0,
            //        IsActive = true,
            //        CustomerNumber = request.CustomerNumber,
            //        RequiresUnderwritingApproval = false,
            //    };

            //    decimal TotalPremium = 0;
            //    decimal totalCoverPrice = 0;

            //    var categoryIds = await _rubyContext.ProductCategorySelections
            //        .Where(d => d.ProductId == request.ProductId)
            //        .Select(d => d.CategoryId)
            //        .Distinct()
            //        .ToListAsync();

            //    var getCategory = await _rubyContext.LineOfBusinessAttributeItems
            //        .Where(d => categoryIds.Contains(d.CategoryId) && d.RequiredAtQuoting == true)
            //        .ToListAsync();

            //    using var transaction = await _rubyContext.Database.BeginTransactionAsync();
            //    try
            //    {
            //        _rubyContext.Quotations.Add(quotation);
            //        await _rubyContext.SaveChangesAsync();

            //        decimal calculatedSumInsured = 0;
            //        var attributesToAdd = new List<QuotationAttributeValue>();
            //        var baseCoversToAdd = new List<QuotationBaseCover>();
            //        var additionalCoversToAdd = new List<QuotationAdditionalCover>();

            //        foreach (var quoteDetail in request.QuoteDetails)
            //        {
            //            foreach (var attr in quoteDetail.QuoteAttributes)
            //            {
            //                var attributeMetadata = subjectAttributes.ProductSubjectTypeAttributes
            //                    .FirstOrDefault(a => a.Id == attr.AttributeId);

            //                var businessattributeMetadata = getCategory
            //                    .FirstOrDefault(a => a.Id == attr.AttributeId);

            //                // If either one exists, continue
            //                if (attributeMetadata != null || businessattributeMetadata != null)
            //                {
            //                    var attributeValueAsString = attr.AttributeValue?.ToString();

            //                    var quotationAttribute = new QuotationAttributeValue
            //                    {
            //                        QuotationId = quotation.Id,
            //                        AttributeName = attr.AttributeName,
            //                        AttributeValue = attributeValueAsString,
            //                        AttributeId = attr.AttributeId,
            //                        EntityId = attr.EntityId
            //                    };

            //                    attributesToAdd.Add(quotationAttribute);
            //                    decimal parsedValue = 0;

            //                    bool isSumInsured = attributeMetadata?.IsSumInsured == true || businessattributeMetadata?.IsSumAssured == true;


            //                    if (isSumInsured && decimal.TryParse(attributeValueAsString, out parsedValue))
            //                    {
            //                        calculatedSumInsured += parsedValue;
            //                    }

            //                }
            //            }

            //            var entityId = quoteDetail.QuoteAttributes.FirstOrDefault()?.EntityId;

            //            foreach (var baseCover in request.BaseCoverRequest)
            //            {
            //                var matchingBaseCover = baseCovers.FirstOrDefault(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);
            //                decimal baseCoverPremium = 0;

            //                if (matchingBaseCover != null)
            //                {
            //                    baseCoverPremium = matchingBaseCover.isFixed
            //                        ? matchingBaseCover.FixedPremium ?? 0
            //                        : (matchingBaseCover.RateApplied / 100) * matchingBaseCover.MaximumAmount;

            //                    TotalPremium += baseCoverPremium;
            //                    totalCoverPrice += baseCover.Price;
            //                }


            //                var quotationBaseCover = new QuotationBaseCover
            //                {
            //                    EntityId = entityId ?? Guid.NewGuid(),
            //                    ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
            //                    CoverStatus = baseCover.CoverStatus,
            //                    CoverName = baseCover.CoverName,
            //                    Price = baseCover.Price,
            //                    QuotationId = quotation.Id
            //                };
            //                baseCoversToAdd.Add(quotationBaseCover);
            //            }

            //            foreach (var additionalCover in request.AdditionalCoverRequest)
            //            {
            //                var matchingAdditionalCover = additionalCovers.FirstOrDefault(ac => ac.Id == additionalCover.ProductBaseSubjectTypeCoverId);
            //                decimal additionalCoverPremium = 0;

            //                if (matchingAdditionalCover != null)
            //                {
            //                    additionalCoverPremium = matchingAdditionalCover.isFixed
            //                        ? matchingAdditionalCover.FixedPremium ?? 0
            //                        : (matchingAdditionalCover.RateApplied / 100) * matchingAdditionalCover.MaximumAmount;

            //                    TotalPremium += additionalCoverPremium;
            //                    totalCoverPrice += additionalCover.Price;
            //                }

            //                var quotationAdditionalCover = new QuotationAdditionalCover
            //                {
            //                    EntityId = entityId ?? Guid.NewGuid(),
            //                    ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
            //                    CoverStatus = additionalCover.CoverStatus,
            //                    CoverName = additionalCover.CoverName,
            //                    Price = additionalCover.Price,
            //                    QuotationId = quotation.Id,
            //                };
            //                additionalCoversToAdd.Add(quotationAdditionalCover);
            //            }
            //        }

            //        _rubyContext.QuotationAttributeValues.AddRange(attributesToAdd);
            //        _rubyContext.QuotationBaseCovers.AddRange(baseCoversToAdd);
            //        _rubyContext.QuotationAdditionalCovers.AddRange(additionalCoversToAdd);

            //        var uniqueEntityCount = request.QuoteDetails
            //            .SelectMany(q => q.QuoteAttributes)
            //            .Select(a => a.EntityId)
            //            .Distinct()
            //            .Count();

            //        var Premium = TotalPremium * uniqueEntityCount;
            //        decimal finalRateApplied = 0;

            //        if (Premium > 0)
            //        {
            //            finalRateApplied = Premium / totalCoverPrice * 100;
            //        }

            //        quotation.SumInsured = calculatedSumInsured;
            //        quotation.Premium = Premium;
            //        quotation.Rate = finalRateApplied;

            //        await _rubyContext.SaveChangesAsync();
            //        await transaction.CommitAsync();

            //        var codeResponse = new QuotationCodeResponse
            //        {
            //            QuotationCode = quotationCode,
            //            QuoteId = quotation.Id
            //        };

            //        response.Success = true;
            //        response.ResponseMessage = "Quote Code Generated Successfully";
            //        response.Data = codeResponse;
            //        response.StatusCode = HttpStatusCode.Created;
            //    }
            //    catch (Exception ex)
            //    {
            //        await transaction.RollbackAsync();
            //        response.Success = false;
            //        response.ResponseMessage = $"Failed to create quotation: {ex}";
            //        response.StatusCode = HttpStatusCode.InternalServerError;
            //    }

            //    return response;
            //}
            #endregion


            #region present use
            //public async Task<BaseResponse<QuotationCodeResponse>> CreateBulkQuotation(BulkQuotationCreateRequest request)
            //{
            //    var response = new BaseResponse<QuotationCodeResponse>();

            //    string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

            //    var businessType = await _rubyContext.BusinessTypes.FirstOrDefaultAsync(x => x.Id == request.BusinessTypeId);
            //    if (businessType?.Name == "Renewal" && request.LostRatio == 0)
            //    {
            //        response.Success = false;
            //        response.ResponseMessage = $"Please supply lost ratio because this is {businessType.Name}";
            //        response.StatusCode = HttpStatusCode.BadRequest;
            //        return response;
            //    }

            //    var product = await _rubyContext.Products.SingleOrDefaultAsync(x => x.Id == request.ProductId);
            //    if (product == null)
            //    {
            //        response.Success = false;
            //        response.ResponseMessage = $"Product with the specified Id {request.ProductId} does not exist";
            //        response.StatusCode = HttpStatusCode.BadRequest;
            //        return response;
            //    }

            //    var subjectAttributes = await _rubyContext.ProductSubjectTypes
            //        .Include(s => s.ProductSubjectTypeAttributes)
            //        .FirstOrDefaultAsync(s => s.ProductId == request.ProductId);

            //    if (subjectAttributes == null)
            //    {
            //        response.Success = false;
            //        response.ResponseMessage = $"Subject attributes not found for Product Id {request.ProductId}";
            //        response.StatusCode = HttpStatusCode.BadRequest;
            //        return response;
            //    }

            //    var minitestResponse = await Minitest(request.QuoteDetails, request.ProductId);
            //    if (!minitestResponse.Success)
            //    {
            //        return ResponseFactory.CreateError<QuotationCodeResponse>(minitestResponse.ResponseMessage, minitestResponse.StatusCode);
            //    }

            //    var quoteStatus = product?.RequiresUnderWriter == true
            //        ? QuotationStatus.RequireUnderWriting.ToString()
            //        : QuotationStatus.Pending.ToString();

            //    string quotationCode = GetNextQuotationCode(_rubyContext).ToString();

            //    var costOfInsurance = await _rubyContext.ProductCostOfInsurances
            //        .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);

            //    if (costOfInsurance == null)
            //    {
            //        response.Success = false;
            //        response.ResponseMessage = "Cost of insurance not found.";
            //        response.StatusCode = HttpStatusCode.BadRequest;
            //        return response;
            //    }

            //    var baseCovers = await _rubyContext.ProductBaseCovers
            //        .Where(bc => bc.ProductId == request.ProductId).ToListAsync();

            //    var additionalCovers = await _rubyContext.ProductAdditionalCovers
            //        .Where(ac => ac.ProductId == request.ProductId).ToListAsync();

            //    var productCategory = await _rubyContext.ProductSubjectCategories
            //        .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);

            //    var priceConfigs = await _rubyContext.ProductPriceConfigurations
            //        .Where(p => p.CategoryId == productCategory.Id) // Don't filter by AttributeId here
            //        .ToListAsync();

            //    var quotation = new Quotation
            //    {
            //        ProductClass = request.ProductClass,
            //        QuoteId = quotationCode,
            //        BusinessTypeId = request.BusinessTypeId,
            //        QuotePreferencesId = request.QuotePreferencesId,
            //        QuoteTypeId = request.QuoteTypeId,
            //        PolicyDurationId = request.PolicyDurationId,
            //        ProductId = request.ProductId,
            //        RiskLocation = request.RiskLocation,
            //        StateOfOperation = request.StateOfOperation,
            //        Channel = request.Channel,
            //        CreateAt = DateTime.UtcNow,
            //        CreateBy = UserClaims(),
            //        Customer = customerName,
            //        SLA = CalculateSLAInMinutes(),
            //        Rate = 0,
            //        LostRatio = request.LostRatio,
            //        SLAUsage = 0,
            //        QuoteStatus = quoteStatus,
            //        VersionNumber = 0,
            //        IsActive = true,
            //        CustomerNumber = request.CustomerNumber,
            //        RequiresUnderwritingApproval = false,
            //    };

            //    decimal TotalPremium = 0;
            //    decimal totalCoverPrice = 0;

            //    var categoryIds = await _rubyContext.ProductCategorySelections
            //        .Where(d => d.ProductId == request.ProductId)
            //        .Select(d => d.CategoryId)
            //        .Distinct()
            //        .ToListAsync();

            //    var getCategory = await _rubyContext.LineOfBusinessAttributeItems
            //        .Where(d => categoryIds.Contains(d.CategoryId) && d.RequiredAtQuoting == true)
            //        .ToListAsync();

            //    using var transaction = await _rubyContext.Database.BeginTransactionAsync();
            //    try
            //    {
            //        _rubyContext.Quotations.Add(quotation);
            //        await _rubyContext.SaveChangesAsync();

            //        decimal calculatedSumInsured = 0;
            //        var attributesToAdd = new List<QuotationAttributeValue>();
            //        var baseCoversToAdd = new List<QuotationBaseCover>();
            //        var additionalCoversToAdd = new List<QuotationAdditionalCover>();

            //        foreach (var quoteDetail in request.QuoteDetails)
            //        {
            //            foreach (var attr in quoteDetail.QuoteAttributes)
            //            {
            //                var attributeMetadata = subjectAttributes.ProductSubjectTypeAttributes
            //                    .FirstOrDefault(a => a.Id == attr.AttributeId);

            //                var businessattributeMetadata = getCategory
            //                    .FirstOrDefault(a => a.Id == attr.AttributeId);

            //                // If either one exists, continue
            //                if (attributeMetadata != null || businessattributeMetadata != null)
            //                {
            //                    var attributeValueAsString = attr.AttributeValue?.ToString();

            //                    var quotationAttribute = new QuotationAttributeValue
            //                    {
            //                        QuotationId = quotation.Id,
            //                        AttributeName = attr.AttributeName,
            //                        AttributeValue = attributeValueAsString,
            //                        AttributeId = attr.AttributeId,
            //                        EntityId = attr.EntityId
            //                    };

            //                    attributesToAdd.Add(quotationAttribute);
            //                    decimal parsedValue = 0;

            //                    bool isSumInsured = attributeMetadata?.IsSumInsured == true || businessattributeMetadata?.IsSumAssured == true;


            //                    if (isSumInsured && decimal.TryParse(attributeValueAsString, out parsedValue))
            //                    {
            //                        calculatedSumInsured += parsedValue;
            //                    }

            //                }




            //            }

            //            var entityId = quoteDetail.QuoteAttributes.FirstOrDefault()?.EntityId;


            //            foreach (var baseCover in request.BaseCoverRequest)
            //            {
            //                var matchingBaseCover = baseCovers.FirstOrDefault(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);
            //                decimal baseCoverPremium = 0;

            //                if (matchingBaseCover != null)
            //                {
            //                    baseCoverPremium = matchingBaseCover.isFixed
            //                        ? matchingBaseCover.FixedPremium ?? 0
            //                        : (matchingBaseCover.RateApplied / 100) * matchingBaseCover.MaximumAmount;

            //                    TotalPremium += baseCoverPremium;
            //                    totalCoverPrice += baseCover.Price;
            //                }


            //                var quotationBaseCover = new QuotationBaseCover
            //                {
            //                    EntityId = entityId ?? Guid.NewGuid(),
            //                    ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
            //                    CoverStatus = baseCover.CoverStatus,
            //                    CoverName = baseCover.CoverName,
            //                    Price = baseCover.Price,
            //                    QuotationId = quotation.Id
            //                };
            //                baseCoversToAdd.Add(quotationBaseCover);



            //                // Now check all quote attributes to match configs
            //                foreach (var attr in quoteDetail.QuoteAttributes)
            //                {
            //                    var config = priceConfigs.FirstOrDefault(p =>
            //                        p.AttributeId == attr.AttributeId &&
            //                        p.CoverIds.Contains(matchingBaseCover.BaseCoverId));

            //                    if (config != null)
            //                    {
            //                        if (config.Affects == "Sum Assured")
            //                        {
            //                            baseCoverPremium += baseCover.Price * config.AffectRate;
            //                        }
            //                        else if (config.Affects == "Final quote")
            //                        {
            //                            calculatedSumInsured += calculatedSumInsured * config.AffectRate;
            //                        }

            //                        var auditLog = new QuotationPriceCalculationAudit
            //                        {
            //                            QuoteId = quotation.Id,
            //                            AttributeId = attr.AttributeId,
            //                            CoverId = matchingBaseCover.BaseCoverId,
            //                            AppliedRate = config.AffectRate,
            //                            AdjustedPremium = baseCoverPremium,
            //                            Affects = config.Affects,
            //                            Timestamp = DateTime.UtcNow,
            //                            Comment = "Applied attribute to base cover and modified premium based on configuration."
            //                        };
            //                        _rubyContext.QuotationPriceCalculationAudits.Add(auditLog);
            //                    }
            //                }

            //            }

            //            foreach (var additionalCover in request.AdditionalCoverRequest)
            //            {
            //                var matchingAdditionalCover = additionalCovers.FirstOrDefault(ac => ac.Id == additionalCover.ProductBaseSubjectTypeCoverId);
            //                decimal additionalCoverPremium = 0;

            //                if (matchingAdditionalCover != null)
            //                {
            //                    additionalCoverPremium = matchingAdditionalCover.isFixed
            //                        ? matchingAdditionalCover.FixedPremium ?? 0
            //                        : (matchingAdditionalCover.RateApplied / 100) * matchingAdditionalCover.MaximumAmount;

            //                    TotalPremium += additionalCoverPremium;
            //                    totalCoverPrice += additionalCover.Price;
            //                }

            //                var quotationAdditionalCover = new QuotationAdditionalCover
            //                {
            //                    EntityId = entityId ?? Guid.NewGuid(),
            //                    ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
            //                    CoverStatus = additionalCover.CoverStatus,
            //                    CoverName = additionalCover.CoverName,
            //                    Price = additionalCover.Price,
            //                    QuotationId = quotation.Id,
            //                };
            //                additionalCoversToAdd.Add(quotationAdditionalCover);



            //                // Now check all quote attributes to match configs
            //                foreach (var attr in quoteDetail.QuoteAttributes)
            //                {
            //                    var config = priceConfigs.FirstOrDefault(p =>
            //                        p.AttributeId == attr.AttributeId &&
            //                        p.CoverIds.Contains(matchingAdditionalCover.AdditionalCoverId));

            //                    if (config != null)
            //                    {
            //                        if (config.Affects == "Sum Assured")
            //                        {
            //                            additionalCoverPremium += additionalCover.Price * config.AffectRate;
            //                        }
            //                        else if (config.Affects == "Final quote")
            //                        {
            //                            calculatedSumInsured += calculatedSumInsured * config.AffectRate;
            //                        }

            //                        var auditLog = new QuotationPriceCalculationAudit
            //                        {
            //                            QuoteId = quotation.Id,
            //                            AttributeId = attr.AttributeId,
            //                            CoverId = matchingAdditionalCover.AdditionalCoverId,
            //                            AppliedRate = config.AffectRate,
            //                            AdjustedPremium = additionalCoverPremium,
            //                            Affects = config.Affects,
            //                            Timestamp = DateTime.UtcNow,
            //                            Comment = "Applied attribute to base cover and modified premium based on configuration."
            //                        };
            //                        _rubyContext.QuotationPriceCalculationAudits.Add(auditLog);
            //                    }
            //                }
            //            }
            //        }

            //        _rubyContext.QuotationAttributeValues.AddRange(attributesToAdd);
            //        _rubyContext.QuotationBaseCovers.AddRange(baseCoversToAdd);
            //        _rubyContext.QuotationAdditionalCovers.AddRange(additionalCoversToAdd);

            //        var uniqueEntityCount = request.QuoteDetails
            //            .SelectMany(q => q.QuoteAttributes)
            //            .Select(a => a.EntityId)
            //            .Distinct()
            //            .Count();

            //        var Premium = TotalPremium * uniqueEntityCount;
            //        decimal finalRateApplied = 0;

            //        if (Premium > 0)
            //        {
            //            finalRateApplied = Premium / totalCoverPrice * 100;
            //        }

            //        quotation.SumInsured = calculatedSumInsured;
            //        quotation.Premium = Premium;
            //        quotation.Rate = finalRateApplied;

            //        await _rubyContext.SaveChangesAsync();
            //        await transaction.CommitAsync();

            //        var codeResponse = new QuotationCodeResponse
            //        {
            //            QuotationCode = quotationCode,
            //            QuoteId = quotation.Id
            //        };

            //        response.Success = true;
            //        response.ResponseMessage = "Quote Code Generated Successfully";
            //        response.Data = codeResponse;
            //        response.StatusCode = HttpStatusCode.Created;
            //    }
            //    catch (Exception ex)
            //    {
            //        await transaction.RollbackAsync();
            //        response.Success = false;
            //        response.ResponseMessage = $"Failed to create quotation: {ex}";
            //        response.StatusCode = HttpStatusCode.InternalServerError;
            //    }

            //    return response;
            //}


            public async Task<BaseResponse<QuotationCodeResponse>> CreateBulkQuotation(BulkQuotationCreateRequest request)
        {
            var response = new BaseResponse<QuotationCodeResponse>();

            string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

            // Fetch business type and validate lost ratio
            var businessType = await _rubyContext.BusinessTypes.FirstOrDefaultAsync(x => x.Id == request.BusinessTypeId);
            if (businessType?.Name == "Renewal" && request.LostRatio == 0)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>("Please supply lost ratio because this is Renewal.", HttpStatusCode.BadRequest);
            }

            // Fetch product and validate its existence
            var product = await _rubyContext.Products.SingleOrDefaultAsync(x => x.Id == request.ProductId);
            if (product == null)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Product with the specified Id {request.ProductId} does not exist", HttpStatusCode.BadRequest);
            }

            // Fetch subject attributes for the product
            var subjectAttributes = await _rubyContext.ProductSubjectTypes
                .Include(s => s.ProductSubjectTypeAttributes)
                .FirstOrDefaultAsync(s => s.ProductId == request.ProductId);
            if (subjectAttributes == null)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Subject attributes not found for Product Id {request.ProductId}", HttpStatusCode.BadRequest);
            }

            // Run minitest check
            var minitestResponse = await Minitest(request.QuoteDetails, request.ProductId);
            if (!minitestResponse.Success)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>(minitestResponse.ResponseMessage, minitestResponse.StatusCode);
            }

            // Determine the quote status
            var quoteStatus = product?.RequiresUnderWriter == true
                ? QuotationStatus.RequireUnderWriting.ToString()
                : QuotationStatus.Pending.ToString();

            // Get the next quotation code
            string quotationCode = GetNextQuotationCode(_rubyContext).ToString();

            // Fetch cost of insurance details for the product
            var costOfInsurance = await _rubyContext.ProductCostOfInsurances
                .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);
            if (costOfInsurance == null)
            {
                return ResponseFactory.CreateError<QuotationCodeResponse>("Cost of insurance not found.", HttpStatusCode.BadRequest);
            }

            // Fetch base covers, additional covers, and price configurations for the product
            var baseCovers = await _rubyContext.ProductBaseCovers
                .Where(bc => bc.ProductId == request.ProductId)
                .ToListAsync();
            var additionalCovers = await _rubyContext.ProductAdditionalCovers
                .Where(ac => ac.ProductId == request.ProductId)
                .ToListAsync();
            var productCategory = await _rubyContext.ProductSubjectCategories
                .FirstOrDefaultAsync(d => d.ProductId == request.ProductId);

            var priceConfigs = await _rubyContext.ProductPriceConfigurations
                .Where(p => p.CategoryId == productCategory.Id)
                .ToListAsync();

            // Create the new quotation record
            var quotation = new Quotation
            {
                ProductClass = request.ProductClass,
                QuoteId = quotationCode,
                BusinessTypeId = request.BusinessTypeId,
                QuotePreferencesId = request.QuotePreferencesId,
                QuoteTypeId = request.QuoteTypeId,
                PolicyDurationId = request.PolicyDurationId,
                ProductId = request.ProductId,
                RiskLocation = request.RiskLocation,
                StateOfOperation = request.StateOfOperation,
                Channel = request.Channel,
                CreateAt = DateTime.UtcNow,
                CreateBy = UserClaims(),
                Customer = customerName,
                SLA = CalculateSLAInMinutes(),
                Rate = 0,
                LostRatio = request.LostRatio,
                SLAUsage = 0,
                QuoteStatus = quoteStatus,
                VersionNumber = 0,
                IsActive = true,
                CustomerNumber = request.CustomerNumber,
                RequiresUnderwritingApproval = false,
            };

            decimal TotalPremium = 0;
            decimal totalCoverPrice = 0;
            decimal calculatedSumInsured = 0;

            // Get category IDs for base covers and additional covers
            var categoryIds = await _rubyContext.ProductCategorySelections
                .Where(d => d.ProductId == request.ProductId)
                .Select(d => d.CategoryId)
                .Distinct()
                .ToListAsync();

            var getCategory = await _rubyContext.LineOfBusinessAttributeItems
                .Where(d => categoryIds.Contains(d.CategoryId) && d.RequiredAtQuoting)
                .ToListAsync();

            using var transaction = await _rubyContext.Database.BeginTransactionAsync();
            try
            {
                // Add quotation record to the database
                _rubyContext.Quotations.Add(quotation);
                await _rubyContext.SaveChangesAsync();

                var attributesToAdd = new List<QuotationAttributeValue>();
                var baseCoversToAdd = new List<QuotationBaseCover>();
                var additionalCoversToAdd = new List<QuotationAdditionalCover>();
                var auditLogs = new List<QuotationPriceCalculationAudit>();

                foreach (var quoteDetail in request.QuoteDetails)
                {
                    // Process quote attributes
                    foreach (var attr in quoteDetail.QuoteAttributes)
                    {
                        var attributeMetadata = subjectAttributes.ProductSubjectTypeAttributes
                            .FirstOrDefault(a => a.Id == attr.AttributeId);
                        var businessattributeMetadata = getCategory
                            .FirstOrDefault(a => a.Id == attr.AttributeId);

                        if (attributeMetadata != null || businessattributeMetadata != null)
                        {
                            var attributeValueAsString = attr.AttributeValue?.ToString();

                            var quotationAttribute = new QuotationAttributeValue
                            {
                                QuotationId = quotation.Id,
                                AttributeName = attr.AttributeName,
                                AttributeValue = attributeValueAsString,
                                AttributeId = attr.AttributeId,
                                EntityId = attr.EntityId
                            };

                            attributesToAdd.Add(quotationAttribute);

                            // Update sum insured calculation
                            decimal parsedValue = 0;
                            bool isSumInsured = attributeMetadata?.IsSumInsured == true || businessattributeMetadata?.IsSumAssured == true;
                            if (isSumInsured && decimal.TryParse(attributeValueAsString, out parsedValue))
                            {
                                calculatedSumInsured += parsedValue;
                            }
                        }
                    }

                    // Process base covers
                    var entityId = quoteDetail.QuoteAttributes.FirstOrDefault()?.EntityId;
                    foreach (var baseCover in request.BaseCoverRequest)
                    {
                        var matchingBaseCover = baseCovers.FirstOrDefault(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);
                        decimal baseCoverPremium = 0;

                        if (matchingBaseCover != null)
                        {
                            baseCoverPremium = matchingBaseCover.isFixed
                                ? matchingBaseCover.FixedPremium ?? 0
                                : (matchingBaseCover.RateApplied / 100) * matchingBaseCover.MaximumAmount;

                            TotalPremium += baseCoverPremium;
                            totalCoverPrice += baseCover.Price;
                        }

                        var quotationBaseCover = new QuotationBaseCover
                        {
                            EntityId = entityId ?? Guid.NewGuid(),
                            ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
                            CoverStatus = baseCover.CoverStatus,
                            CoverName = baseCover.CoverName,
                            Price = baseCover.Price,
                            QuotationId = quotation.Id
                        };

                        baseCoversToAdd.Add(quotationBaseCover);

                        // Process price config and audit logs for base covers
                        foreach (var attr in quoteDetail.QuoteAttributes)
                        {
                            var config = priceConfigs.FirstOrDefault(p =>
                                p.AttributeName == attr.AttributeValue.GetString() &&
                                p.CoverIds.Contains(matchingBaseCover.BaseCoverId));

                            if (config != null)
                            {
                                if (config.Affects == "Sum Assured")
                                {
                                    baseCoverPremium += baseCover.Price * config.AffectRate;
                                }
                                else if (config.Affects == "Final quote")
                                {
                                    calculatedSumInsured += calculatedSumInsured * config.AffectRate;
                                }

                                var auditLog = new QuotationPriceCalculationAudit
                                {
                                    QuoteId = quotation.Id,
                                    AttributeId = attr.AttributeId,
                                    CoverId = matchingBaseCover.BaseCoverId,
                                    AppliedRate = config.AffectRate,
                                    AdjustedPremium = baseCoverPremium,
                                    Affects = config.Affects,
                                    Timestamp = DateTime.UtcNow,
                                    Comment = "Applied attribute to base cover and modified premium based on configuration."
                                };

                                auditLogs.Add(auditLog);
                            }
                        }
                    }

                    // Process additional covers
                    foreach (var additionalCover in request.AdditionalCoverRequest)
                    {
                        var matchingAdditionalCover = additionalCovers.FirstOrDefault(ac => ac.Id == additionalCover.ProductBaseSubjectTypeCoverId);
                        decimal additionalCoverPremium = 0;

                        if (matchingAdditionalCover != null)
                        {
                            additionalCoverPremium = matchingAdditionalCover.isFixed
                                ? matchingAdditionalCover.FixedPremium ?? 0
                                : (matchingAdditionalCover.RateApplied / 100) * matchingAdditionalCover.MaximumAmount;

                            TotalPremium += additionalCoverPremium;
                            totalCoverPrice += additionalCover.Price;
                        }

                        var quotationAdditionalCover = new QuotationAdditionalCover
                        {
                            EntityId = entityId ?? Guid.NewGuid(),
                            ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
                            CoverStatus = additionalCover.CoverStatus,
                            CoverName = additionalCover.CoverName,
                            Price = additionalCover.Price,
                            QuotationId = quotation.Id
                        };

                        additionalCoversToAdd.Add(quotationAdditionalCover);

                        // Process price config and audit logs for additional covers
                        foreach (var attr in quoteDetail.QuoteAttributes)
                        {
                            var config = priceConfigs.FirstOrDefault(p =>
                                p.AttributeName == attr.AttributeValue.GetString() &&
                                p.CoverIds.Contains(matchingAdditionalCover.AdditionalCoverId));

                            if (config != null)
                            {
                                if (config.Affects == "Sum Assured")
                                {
                                    additionalCoverPremium += additionalCover.Price * config.AffectRate;
                                }
                                else if (config.Affects == "Final quote")
                                {
                                    calculatedSumInsured += calculatedSumInsured * config.AffectRate;
                                }

                                var auditLog = new QuotationPriceCalculationAudit
                                {
                                    QuoteId = quotation.Id,
                                    AttributeId = attr.AttributeId,
                                    CoverId = matchingAdditionalCover.AdditionalCoverId,
                                    AppliedRate = config.AffectRate,
                                    AdjustedPremium = additionalCoverPremium,
                                    Affects = config.Affects,
                                    Timestamp = DateTime.UtcNow,
                                    Comment = "Applied attribute to additional cover and modified premium based on configuration."
                                };

                                auditLogs.Add(auditLog);
                            }
                        }
                    }
                }

                // Add collected data to the context
                _rubyContext.QuotationAttributeValues.AddRange(attributesToAdd);
                _rubyContext.QuotationBaseCovers.AddRange(baseCoversToAdd);
                _rubyContext.QuotationAdditionalCovers.AddRange(additionalCoversToAdd);
                _rubyContext.QuotationPriceCalculationAudits.AddRange(auditLogs);

                // Calculate premium and final rate
                var uniqueEntityCount = request.QuoteDetails
                    .SelectMany(q => q.QuoteAttributes)
                    .Select(a => a.EntityId)
                    .Distinct()
                    .Count();

                var Premium = TotalPremium * uniqueEntityCount;
                decimal finalRateApplied = 0;

                if (Premium > 0)
                {
                    finalRateApplied = Premium / totalCoverPrice * 100;
                }

                quotation.SumInsured = calculatedSumInsured;
                quotation.Premium = Premium;
                quotation.Rate = finalRateApplied;

                await _rubyContext.SaveChangesAsync();
                await transaction.CommitAsync();

                // Return response with quotation code and ID
                var codeResponse = new QuotationCodeResponse
                {
                    QuotationCode = quotationCode,
                    QuoteId = quotation.Id
                };

                response.Success = true;
                response.ResponseMessage = "Quote Code Generated Successfully";
                response.Data = codeResponse;
                response.StatusCode = HttpStatusCode.Created;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return ResponseFactory.CreateError<QuotationCodeResponse>($"Failed to create quotation: {ex}", HttpStatusCode.InternalServerError);
            }

            return response;
        }

        #endregion





        private async Task<BaseResponse<GenericNameResponse>> Minitest(List<QuoteDetailsDto> attributetest, int productId)
        {
            // Get the subject type for the product
            var subjectType = await _rubyContext.ProductSubjectTypes
                .FirstOrDefaultAsync(d => d.ProductId == productId);
            if (subjectType == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>(
                    "Subject type not found", HttpStatusCode.NotFound);
            }

            // Fetch attribute mappings (Parent -> Allowed Children)
            var mappedValues = await _rubyContext.ProductSubjectAttributeDropdownMappings
                .Where(d => d.ProductId == productId)
                .ToListAsync();

            // Group the mappings by ParentAttributeId to easily check each parent-child relationship
            var attributeMappings = mappedValues
                .GroupBy(m => m.ParentAttributeId)
                .ToDictionary(g => g.Key, g => g.ToList());

            // Group the input attributes by EntityId for validation
            var groupedAttributes = attributetest
                .SelectMany(quote => quote.QuoteAttributes)
                .GroupBy(a => a.EntityId)
                .ToList();

            foreach (var entityGroup in groupedAttributes)
            {
                foreach (var attribute in entityGroup)
                {
                    // Check if the current attribute is a parent attribute
                    if (attributeMappings.ContainsKey(attribute.AttributeId))
                    {
                        var parentMappings = attributeMappings[attribute.AttributeId];
                        var parentValue = attribute.AttributeValue?.ToString();

                        // Find the corresponding mapping for the parent value (e.g., "Toyota" for car make)
                        var parentMapping = parentMappings.FirstOrDefault(m => m.ParentValue.Equals(parentValue, StringComparison.OrdinalIgnoreCase));

                        if (parentMapping != null)
                        {
                            // We have found a valid mapping for this parent value
                            var childAttributeId = parentMapping.ChildAttributeId;
                            var allowedChildValues = parentMapping.ChildValues.Split(',')
                                .Select(v => v.Trim())
                                .ToHashSet();

                            // Check if the child attribute exists in the current entity
                            var childAttribute = entityGroup.FirstOrDefault(a => a.AttributeId == childAttributeId);

                            if (childAttribute != null)
                            {
                                // Validate if the child's value is allowed
                                if (!allowedChildValues.Contains(childAttribute.AttributeValue?.ToString()))
                                {
                                    return ResponseFactory.CreateError<GenericNameResponse>(
                                        $"Invalid value '{childAttribute.AttributeValue}' matched with '{parentValue}'",
                                        HttpStatusCode.BadRequest
                                    );
                                }
                            }
                        }
                    }
                }
            }

            // If all validations pass, return success
            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>(
                "Validation passed", HttpStatusCode.OK);
        }
        public async Task<BaseResponse<QuotationCodeResponse>> CreateQuotationIteration(int quotationId, QuotationUpdateRequest request)
        {
            var response = new BaseResponse<QuotationCodeResponse>();

            // Retrieve the existing quotation by QuoteId or QuotationId
            var quotation = await _rubyContext.Quotations
                .Include(q => q.QuotationBaseCovers)
                .Include(q => q.QuotationAdditionalCovers)
                .FirstOrDefaultAsync(q => q.Id == quotationId);

            if (quotation == null)
            {
                response.Success = false;
                response.ResponseMessage = $"Quotation with Id {quotationId} not found";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Check for a customer name, fallback to 'Anonymous' if missing
            string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

            var businessType = await _rubyContext.BusinessTypes.FirstOrDefaultAsync(x => x.Id == request.BusinessTypeId);
            if (businessType?.Name == "Renewal" && request.LostRatio == 0)
            {
                response.Success = false;
                response.ResponseMessage = $"Please supply loss ratio because this is a {businessType.Name}";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            // Validate product existence
            var product = await _rubyContext.Products.FirstOrDefaultAsync(x => x.Id == request.ProductId);
            if (product == null)
            {
                response.Success = false;
                response.ResponseMessage = $"Product with the specified Id {request.ProductId} does not exist";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            // Retrieve subject attributes
            var subjectAttributes = await _rubyContext.ProductSubjectTypes
                .Include(s => s.ProductSubjectTypeAttributes)
                .FirstOrDefaultAsync(s => s.ProductId == request.ProductId);

            if (subjectAttributes == null)
            {
                response.Success = false;
                response.ResponseMessage = $"Subject attributes not found for Product Id {request.ProductId}";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }




            // Replicate the existing quote to create a new iteration
            var newQuotation = new Quotation
            {
                ProductClass = request.ProductClass,
                BusinessTypeId = request.BusinessTypeId,
                QuotePreferencesId = request.QuotePreferencesId,
                QuoteTypeId = request.QuoteTypeId,
                PolicyDurationId = request.PolicyDurationId,
                ProductId = request.ProductId,
                RiskLocation = request.RiskLocation,
                StateOfOperation = request.StateOfOperation,
                Channel = request.Channel,
                CreateAt = DateTime.UtcNow,
                CreateBy = UserClaims(),
                Customer = customerName,
                LostRatio = request.LostRatio,
                CustomerAddress = request.CustomerAddress,
                RequiresUnderwritingApproval = true,
                Rate = request.Rate,
                CustomerNumber = request.CustomerNumber,
                Product = product,
                PreviousQuoteId = quotation.Id,
                Premium = request.Premium,
                SumInsured = request.SumInsured
            };

            // Transaction to ensure atomicity
            using var transaction = await _rubyContext.Database.BeginTransactionAsync();

            try
            {
                // Add new quotation
                await _rubyContext.Quotations.AddAsync(newQuotation);
                await _rubyContext.SaveChangesAsync();

                // Copy all relevant base covers
                var baseCoversToAdd = new List<QuotationBaseCover>();
                foreach (var baseCover in request.BaseCoverRequest)
                {
                    var quotationBaseCover = new QuotationBaseCover
                    {
                        EntityId = baseCover.EntityId,
                        ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
                        CoverStatus = baseCover.CoverStatus,
                        CoverName = baseCover.CoverName,
                        QuotationId = newQuotation.Id,
                        Price = baseCover.Price
                    };
                    baseCoversToAdd.Add(quotationBaseCover);
                }
                _rubyContext.QuotationBaseCovers.AddRange(baseCoversToAdd);
                await _rubyContext.SaveChangesAsync();

                // Copy all relevant additional covers
                var additionalCoversToAdd = new List<QuotationAdditionalCover>();
                foreach (var additionalCover in request.AdditionalCoverRequest)
                {
                    var quotationAdditionalCover = new QuotationAdditionalCover
                    {
                        EntityId = additionalCover.EntityId,
                        ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
                        CoverStatus = additionalCover.CoverStatus,
                        CoverName = additionalCover.CoverName,
                        QuotationId = newQuotation.Id,
                        Price = additionalCover.Price
                    };
                    additionalCoversToAdd.Add(quotationAdditionalCover);
                }
                _rubyContext.QuotationAdditionalCovers.AddRange(additionalCoversToAdd);
                await _rubyContext.SaveChangesAsync();

                // Copy dynamic attributes (QuotationAttributeValues)
                var attributesToAdd = new List<QuotationAttributeValue>();
                decimal calculatedSumInsured = 0;
                foreach (var quoteDetail in request.QuoteDetails)
                {
                    foreach (var attr in quoteDetail.QuoteAttributes)
                    {
                        var attributeMetadata = subjectAttributes.ProductSubjectTypeAttributes
                            .FirstOrDefault(a => a.Id == attr.AttributeId);

                        if (attributeMetadata != null)
                        {
                            var attributeValueAsString = attr.AttributeValue?.ToString();
                            var quotationAttribute = new QuotationAttributeValue
                            {
                                QuotationId = newQuotation.Id,
                                AttributeName = attr.AttributeName,
                                AttributeValue = attributeValueAsString,
                                AttributeId = attr.AttributeId,
                                EntityId = attr.EntityId // Store the EntityId from request
                            };

                            attributesToAdd.Add(quotationAttribute);

                            if (attributeMetadata.IsSumInsured)
                            {
                                if (decimal.TryParse(attributeValueAsString, out decimal parsedValue))
                                {
                                    calculatedSumInsured += parsedValue;
                                }
                            }
                        }
                    }
                }
                _rubyContext.QuotationAttributeValues.AddRange(attributesToAdd);
                await _rubyContext.SaveChangesAsync();

                
                //newQuotation.SumInsured = calculatedSumInsured;
                //newQuotation.Premium = premium;

                var newNegotiation = new QuoteNegotiation
                {
                    QuoteId = newQuotation.Id,
                    NegotiationRound = await GetNextNegotiationRound(newQuotation.Id),
                    RequestedDiscount = 0,
                    NegotiationStatus = QuotationStatus.Review.ToString(),
                    InitiatedBy = UserClaims(),
                    Remarks = request.remarks,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                await _rubyContext.QuoteNegotiations.AddAsync(newNegotiation);

                newQuotation.QuoteStatus = QuotationStatus.Review.ToString();

                await _rubyContext.SaveChangesAsync();

                // Commit the transaction
                await transaction.CommitAsync();

                // Create and return response
                var codeResponse = new QuotationCodeResponse
                {
                    QuotationCode = newQuotation.QuoteId,
                    QuoteId = newQuotation.Id
                };

                response.Success = true;
                response.ResponseMessage = "Quotation replicated and updated successfully";
                response.Data = codeResponse;
                response.StatusCode = HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                // Rollback transaction and log error
                await transaction.RollbackAsync();
                response.Success = false;
                response.ResponseMessage = $"Failed to replicate and update quotation: {ex}";
                response.StatusCode = HttpStatusCode.InternalServerError;
            }

            return response;
        }
        public async Task<BaseResponse<ValidateCustomerResponse>> ValidateCustomer(string customer)
        {
            var response = new BaseResponse<ValidateCustomerResponse>();

            var customerLower = customer.ToLower();
            var customerDetails = await _rubyContext.Customers
               .FirstOrDefaultAsync(d =>
           d.CustomerNumber == customer ||
           (d.FirstName + " " + d.LastName).ToLower() == customerLower ||
           d.Email.ToLower() == customerLower); 

            if (customer == null)
            {
                response.Success = false;
                response.ResponseMessage = "Customer not found or invalid credentials.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // Populate the response object with customer details
            var customerNameResponse = new ValidateCustomerResponse
            {
                CustomerName = $"{customerDetails.FirstName} {customerDetails.LastName}",
                CustomerNumber = customerDetails.CustomerNumber,
                // Add other properties as needed
            };

            response.Success = true;
            response.ResponseMessage = "Customer Found";
            response.Data = customerNameResponse;
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<ValidateCustomerResponse>> CustomerValidation(string Name, string Email)
        {
            var response = new BaseResponse<ValidateCustomerResponse>();
            var validateCustomer = await _rubyContext.Customers
                .FirstOrDefaultAsync(c => c.FirstName + c.LastName == Name || c.Email == Email);

            if (validateCustomer == null)
            {
              
                    response.Success = false;
                    response.ResponseMessage = $"Customer not found or invalid credentials.";
                    response.StatusCode = HttpStatusCode.BadRequest;
                    return response;
                
            }
            ValidateCustomerResponse customerNameResponse = new()
            {
                CustomerName = validateCustomer.FirstName + validateCustomer.LastName,
            };

            response.Success = true;
            response.ResponseMessage = "Customer Found";
            response.Data = customerNameResponse;
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }

        public async Task<BaseResponse<QuotationCodeResponse>> UpdateQuotation(int quotationId, QuotationUpdateRequest request)
        {
            var response = new BaseResponse<QuotationCodeResponse>();

            var quotation = await _rubyContext.Quotations
                .Include(q => q.QuotationBaseCovers)
                .Include(q => q.QuotationAdditionalCovers)
                .FirstOrDefaultAsync(q => q.Id == quotationId);

            if (quotation == null)
            {
                response.Success = false;
                response.ResponseMessage = $"Quotation with Id {quotationId} not found";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

            var businessType = await _rubyContext.BusinessTypes.FirstOrDefaultAsync(x => x.Id == request.BusinessTypeId);
            if (businessType?.Name == "Renewal" && request.LostRatio == 0)
            {
                response.Success = false;
                response.ResponseMessage = $"Please supply loss ratio because this is a {businessType.Name}";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            var product = await _rubyContext.Products.FirstOrDefaultAsync(x => x.Id == request.ProductId);
            if (product == null)
            {
                response.Success = false;
                response.ResponseMessage = $"Product with the specified Id {request.ProductId} does not exist";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            var subjectAttributes = await _rubyContext.ProductSubjectTypes
                .Include(s => s.ProductSubjectTypeAttributes)
                .FirstOrDefaultAsync(s => s.ProductId == request.ProductId);

            if (subjectAttributes == null)
            {
                response.Success = false;
                response.ResponseMessage = $"Subject attributes not found for Product Id {request.ProductId}";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }
            if (string.IsNullOrWhiteSpace(request.remarks))
            {
                response.Success = false;
                response.ResponseMessage = "Please provide a response for your changes";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            // Update quotation details
            quotation.ProductClass = request.ProductClass;
            quotation.BusinessTypeId = request.BusinessTypeId;
            quotation.QuotePreferencesId = request.QuotePreferencesId;
            quotation.QuoteTypeId = request.QuoteTypeId;
            quotation.PolicyDurationId = request.PolicyDurationId;
            quotation.ProductId = request.ProductId;
            quotation.RiskLocation = request.RiskLocation;
            quotation.StateOfOperation = request.StateOfOperation;
            quotation.Channel = request.Channel;
            quotation.CreateAt = DateTime.UtcNow;
            quotation.CreateBy = UserClaims();
            quotation.Customer = customerName;
            quotation.LostRatio = request.LostRatio;
            quotation.CustomerAddress = request.CustomerAddress;
            quotation.RequiresUnderwritingApproval = true;
            quotation.Rate = request.Rate;
            quotation.CustomerNumber = request.CustomerNumber;
            quotation.Premium = request.Premium;
            quotation.QuoteStatus = QuotationStatus.Review.ToString();

            using var transaction = await _rubyContext.Database.BeginTransactionAsync();
            try
            {
                // Update covers in a grouped manner (by EntityId under the same QuotationId)
                await UpdateQuotationCoversGroupedByEntity(quotationId, request);

                // Here we update the 'Indicator' field for modified covers only
                var updatedBaseCovers = quotation.QuotationBaseCovers
                    .Where(bc => bc.QuotationId == quotationId && bc.Indicator == true) // If cover has been updated, Indicator should be true
                    .ToList();

                foreach (var baseCover in updatedBaseCovers)
                {
                    // If any cover's properties were updated, set the Indicator to true
                    baseCover.Indicator = true;
                }

                var updatedAdditionalCovers = quotation.QuotationAdditionalCovers
                    .Where(ac => ac.QuotationId == quotationId && ac.Indicator == true) // Same condition for Additional Covers
                    .ToList();

                foreach (var additionalCover in updatedAdditionalCovers)
                {
                    // If any cover's properties were updated, set the Indicator to true
                    additionalCover.Indicator = true;
                }

                // Create a new negotiation record
                var newNegotiation = new QuoteNegotiation
                {
                    QuoteId = quotationId,
                    NegotiationRound = await GetNextNegotiationRound(quotationId),
                    RequestedDiscount = 0,
                    NegotiationStatus = QuotationStatus.Review.ToString(),
                    InitiatedBy = UserClaims(),
                    Remarks = request.remarks,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                _rubyContext.QuoteNegotiations.Add(newNegotiation);

                decimal totalPremium = 0;
                decimal totalCoverPrice = 0;

                // Group base covers by EntityId
                var baseCoversByEntity = quotation.QuotationBaseCovers
                    .Where(bc => !bc.Indicator) // Exclude covers with Indicator = true
                    .GroupBy(bc => bc.EntityId)
                    .ToList();

                foreach (var group in baseCoversByEntity)
                {
                    decimal groupPremium = 0;
                    decimal groupCoverPrice = 0;

                    foreach (var baseCover in group)
                    {
                        var matchingBaseCover = await _rubyContext.ProductBaseCovers
                            .FirstOrDefaultAsync(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);

                        if (matchingBaseCover != null)
                        {
                            decimal baseCoverPremium = CalculatePremium(
                                matchingBaseCover.RateApplied,
                                matchingBaseCover.MaximumAmount,
                                matchingBaseCover.FixedPremium,
                                matchingBaseCover.isFixed
                            );

                            groupPremium += baseCoverPremium;
                            groupCoverPrice += baseCover.Price;
                        }
                    }

                    totalPremium += groupPremium;
                    totalCoverPrice += groupCoverPrice;
                }

                // Group additional covers by EntityId
                var additionalCoversByEntity = quotation.QuotationAdditionalCovers
                    .Where(ac => !ac.Indicator) // Exclude covers with Indicator = true
                    .GroupBy(ac => ac.EntityId)
                    .ToList();

                foreach (var group in additionalCoversByEntity)
                {
                    decimal groupPremium = 0;
                    decimal groupCoverPrice = 0;

                    foreach (var additionalCover in group)
                    {
                        var matchingAdditionalCover = await _rubyContext.ProductAdditionalCovers
                            .FirstOrDefaultAsync(ac => ac.Id == additionalCover.ProductAdditionalSubjectTypeCoverId);

                        if (matchingAdditionalCover != null)
                        {
                            decimal additionalCoverPremium = CalculatePremium(
                                matchingAdditionalCover.RateApplied,
                                matchingAdditionalCover.MaximumAmount,
                                matchingAdditionalCover.FixedPremium,
                                matchingAdditionalCover.isFixed
                            );

                            groupPremium += additionalCoverPremium;
                            groupCoverPrice += additionalCover.Price;
                        }
                    }

                    totalPremium += groupPremium;
                    totalCoverPrice += groupCoverPrice;
                }

                // Update quotation's premium, sum insured, and rate
                quotation.Premium = totalPremium;
                quotation.Rate = totalCoverPrice > 0 ? (totalPremium / totalCoverPrice * 100) : 0;

                await _rubyContext.SaveChangesAsync();
                await transaction.CommitAsync();

                response.Success = true;
                response.ResponseMessage = "Quotation updated successfully";
                response.StatusCode = HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                response.Success = false;
                response.ResponseMessage = $"Error updating quotation: {ex.Message}";
                response.StatusCode = HttpStatusCode.InternalServerError;
            }

            return response;
        }

        private async Task UpdateQuotationCoversGroupedByEntity(int quotationId, QuotationUpdateRequest request)
        {
            // Retrieve existing covers grouped by EntityId
            
             var existingBaseCovers = await _rubyContext.QuotationBaseCovers
              .Where(ac => ac.QuotationId == quotationId)
              .ToListAsync();

            var existingAdditionalCovers = await _rubyContext.QuotationAdditionalCovers
              .Where(ac => ac.QuotationId == quotationId)
              .ToListAsync();


            var newBaseCoversByEntity = request.BaseCoverRequest
              .GroupBy(ac => ac.EntityId)
              .ToDictionary(g => g.Key, g => g.Select(ac => ac.ProductBaseSubjectTypeCoverId).ToHashSet());

            var newAdditionalCoversByEntity = request.AdditionalCoverRequest
               .GroupBy(ac => ac.EntityId)
               .ToDictionary(g => g.Key, g => g.Select(ac => ac.ProductBaseSubjectTypeCoverId).ToHashSet());


            // Update existing covers
            foreach (var existingCover in existingBaseCovers)
            {
                if (!newBaseCoversByEntity.TryGetValue(existingCover.EntityId, out var newCoverIds))
                {
                    existingCover.Indicator =true;
                    existingCover.Comment = $"{existingCover.CoverName} was removed on {DateTime.UtcNow}.";

                }

            }

            foreach (var existingCover in existingAdditionalCovers)
            {
                if (newAdditionalCoversByEntity.TryGetValue(existingCover.EntityId, out var newCoverIds))
                {
                    // If the existing ProductAdditionalCoverId is missing in the new request, mark it as inactive
                    if (!newCoverIds.Contains(existingCover.ProductAdditionalSubjectTypeCoverId))
                    {
                        existingCover.Indicator = true; // Soft delete or deactivation flag
                        existingCover.Comment = $"{existingCover.CoverName} was removed on {DateTime.UtcNow}.";
                    }
                }
            }

            // Add new covers grouped by EntityId
            var existingBaseCoversLookup = existingBaseCovers
             .GroupBy(bc => bc.EntityId)
             .ToDictionary(
                 g => g.Key,
                 g => g.Select(bc => bc.ProductBaseSubjectTypeCoverId).ToHashSet()
             );

            var baseCoversToAdd = request.BaseCoverRequest
                .Where(bc => !existingBaseCoversLookup.ContainsKey(bc.EntityId) ||
                             !existingBaseCoversLookup[bc.EntityId].Contains(bc.ProductBaseSubjectTypeCoverId))
                .Select(bc => new QuotationBaseCover
                {
                    QuotationId = quotationId,
                    EntityId = bc.EntityId,
                    ProductBaseSubjectTypeCoverId = bc.ProductBaseSubjectTypeCoverId,
                    Indicator = true, // Newly added covers should be active
                    
                 }).ToList();

            await _rubyContext.QuotationBaseCovers.AddRangeAsync(baseCoversToAdd);
            await _rubyContext.SaveChangesAsync();



            var existingCoversLookup = existingAdditionalCovers
              .GroupBy(ac => ac.EntityId)
              .ToDictionary(
                  g => g.Key,
                  g => g.Select(ac => ac.ProductAdditionalSubjectTypeCoverId).ToHashSet()
              );

            var additionalCoversToAdd = request.AdditionalCoverRequest
                .Where(ac => !existingCoversLookup.ContainsKey(ac.EntityId) ||
                             !existingCoversLookup[ac.EntityId].Contains(ac.ProductBaseSubjectTypeCoverId))
                .Select(ac => new QuotationAdditionalCover
                {
                    QuotationId = quotationId,
                    EntityId = ac.EntityId,
                    ProductAdditionalSubjectTypeCoverId = ac.ProductBaseSubjectTypeCoverId,
                    Indicator = true 
                }).ToList();

            await _rubyContext.QuotationBaseCovers.AddRangeAsync(baseCoversToAdd);
            await _rubyContext.QuotationAdditionalCovers.AddRangeAsync(additionalCoversToAdd);
        }
        private decimal CalculatePremium(decimal rateApplied, decimal maximumAmount, decimal? fixedPremium, bool isFixed)
        {
            if (isFixed)
            {
                return fixedPremium ?? 0;
            }
            else
            {
                return (rateApplied / 100) * maximumAmount;
            }
        }
        public async Task<BaseResponse<QuotationDetailedResponse>> GetSingleQuotation(int QuoteId)
        {
            var response = new BaseResponse<QuotationDetailedResponse>();

            // Fetch the selected quote with related data
            var selectedQuote = await _rubyContext.Quotations
                .Include(q => q.QuotationAttributeValues)
                    .ThenInclude(attr => attr.ProductSubjectTypeAttribute)
                .Include(q => q.QuotePreferences)
                .Include(q => q.QuoteType)
                .Include(q => q.QuotationAdditionalCovers)
                    .ThenInclude(q => q.ProductAdditionalSubjectTypeCover)
                .Include(q => q.QuotationBaseCovers)
                    .ThenInclude(q => q.ProductBaseSubjectTypeCover)
                .Include(q => q.BusinessType)
                .Include(q => q.PolicyDuration)
                .Include(q => q.Product)
                //    .ThenInclude(p => p.ProductClass)
                .Include(q => q.QuoteNegotiation)
                .Include(q => q.Product)
                .ThenInclude(q => q.ProductSubjectCategories)
                .ThenInclude(q => q.ProductSubjectTypeAttributes)
                .FirstOrDefaultAsync(q => q.Id == QuoteId);

            


            if (selectedQuote == null)
            {
                response.Success = false;
                response.ResponseMessage = "Quote Not Found";
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                return response;
            }

            // Retrieve predecessors and successors
            var predecessors = await GetPredecessorsAsync(selectedQuote);
            var successors = await GetSuccessorsAsync(selectedQuote);

            // Combine predecessors, selected quote, and successors
            var allRelatedQuotes = new List<Quotation>(predecessors ?? Enumerable.Empty<Quotation>())
                .Concat(new[] { selectedQuote })
                .Concat(successors ?? Enumerable.Empty<Quotation>())
                .ToList();

            var previousVersions = allRelatedQuotes
                .Select(q => new VersionResponse
                {
                    VersionNumber = q.VersionNumber,
                    CreatedBy = q.CreateBy,
                    CreatedAt = q.CreateAt,
                    QuoteId = q.Id,
                    Premium = q.Premium,
                    Discount = q.Discount,
                    OriginalQuoteId = predecessors.Any() ? predecessors[0].Id : 0,
                })
                .OrderByDescending(v => v.VersionNumber)
                .ToList();

            // Load Base and Additional covers list

            // Get EntityId to filter covers by EntityId
            var entityIds = selectedQuote.QuotationAttributeValues
                .Select(attr => attr.EntityId)
                .Distinct()
                .ToList();

            if (entityIds == null || !entityIds.Any())
            {
                response.Success = false;
                response.ResponseMessage = "No Entity IDs found for the selected quotation.";
                response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return response;
            }

            var quotationBaseCoversList = selectedQuote.QuotationBaseCovers
                .Where(b => entityIds.Contains(b.EntityId) && b.Indicator == false)
                .ToList();

            var quotationAdditionalCoversList = selectedQuote.QuotationAdditionalCovers
                .Where(a => entityIds.Contains(a.EntityId) && a.Indicator == false)
                .ToList();

            var baseCoversList = await _rubyContext.ProductBaseCovers.ToListAsync();
            var additionalCoverList = await _rubyContext.ProductAdditionalCovers.ToListAsync();


            var quotePriceResponse = await GetQuotePriceResponsesWithCoverNames(selectedQuote);

            var attributeResponses = selectedQuote.QuotationAttributeValues
                 .Select(attr => new AttributeResponseDetails
                 {
                     Id = attr.Id,
                     AttributeName = attr.AttributeName,
                     AttributeValue = attr.AttributeValue,
                     AttributeId = attr.AttributeId,
                     EntityId = attr.EntityId,
                 }).ToList();


            // Build response
            var groupedAttributes = attributeResponses
                .GroupBy(attr => attr.EntityId)
                .Select(group =>
                {
                    var baseCovers = quotationBaseCoversList
                        .Where(b => b.EntityId == group.Key)
                        .Select(baseCover => new QuotationBaseCoverResponse
                        {
                            Id = baseCover.Id,
                            ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
                            CoverName = baseCover.CoverName,
                            Status = baseCover.CoverStatus,
                            Price = baseCover.Price,
                            MaximumAmount = baseCoversList.FirstOrDefault(b => b.Id == baseCover.ProductBaseSubjectTypeCoverId).MaximumAmount,
                            RateApplied = baseCoversList.FirstOrDefault(b => b.Id == baseCover.ProductBaseSubjectTypeCoverId).RateApplied,
                            TotalAmount = baseCover.Price * (baseCoversList.FirstOrDefault(b => b.Id == baseCover.ProductBaseSubjectTypeCoverId)?.RateApplied ?? 0) / 100,
                            Indicator = baseCover.Indicator,
                        }).ToList();

                    var additionalCovers = quotationAdditionalCoversList
                        .Where(a => a.EntityId == group.Key)
                        .Select(additionalCover => new QuotationAdditionalCoverResponse
                        {
                            Id = additionalCover.Id,
                            ProductBaseSubjectTypeCoverId = additionalCover.ProductAdditionalSubjectTypeCoverId,
                            CoverName = additionalCover.CoverName,
                            Status = additionalCover.CoverStatus,
                            Price = additionalCover.Price,
                            MaximumAmount = additionalCoverList.FirstOrDefault(b => b.Id == additionalCover.ProductAdditionalSubjectTypeCoverId).MaximumAmount,
                            RateApplied = additionalCoverList.FirstOrDefault(b => b.Id == additionalCover.ProductAdditionalSubjectTypeCoverId).RateApplied,
                            TotalAmount = additionalCover.Price * (additionalCoverList.FirstOrDefault(b => b.Id == additionalCover.ProductAdditionalSubjectTypeCoverId)?.RateApplied ?? 0) / 100,
                            Indicator = additionalCover.Indicator,
                        }).ToList();

                    return new AttributeResponse
                    {
                        EntityId = group.Key,
                        AttributeResponseDetails = group.ToList(),
                        QuotationBaseCovers = baseCovers,
                        QuotationAdditionalCovers = additionalCovers
                    };
                }).ToList();

            var productNameResponse = await _adminService.GetSingleProductClass(selectedQuote.Product.ProductClassId);
            var productResponse = productNameResponse.Success ? productNameResponse.Data : $"Unknown (ID: Product Id)";

            var quotationResponse = new QuotationDetailedResponse
            {
                Id = selectedQuote.Id,
                BusinessType = new NestedIdNameResponse
                {
                    Id = selectedQuote.BusinessType.Id,
                    Name = selectedQuote.BusinessType?.Name,
                },
                QuotePreference = new NestedIdNameResponse
                {
                    Id = selectedQuote.QuotePreferences.Id,
                    Name = selectedQuote.QuotePreferences?.Name
                },
                QuoteType = new NestedIdNameResponse
                {
                    Id = selectedQuote.QuotePreferences.Id,
                    Name = selectedQuote.QuotePreferences?.Name
                },
                PolicyDuration = new NestedIdNameResponse
                {
                    Id = selectedQuote.PolicyDuration.Id,
                    Name = selectedQuote.PolicyDuration?.Name
                },
                Product = new NestedIdNameResponse
                {
                    Id = selectedQuote.Product.Id,
                    Name = selectedQuote.Product?.Name,
                },
                ProductClass = new NestedIdNameResponse
                {
                    Id = selectedQuote.Product.ProductClassId,
                    Name = productResponse
                },
                RiskLocation = selectedQuote.RiskLocation,
                StateOfOperation = selectedQuote.StateOfOperation,
                Channel = selectedQuote.Channel,
                SLA = selectedQuote.SLA,
                SLAUsage = selectedQuote.SLAUsage,
                IsLocked = selectedQuote.IsLocked,
                CreateAt = selectedQuote.CreateAt,
                CreateBy = selectedQuote.CreateBy,
                SumInsured = selectedQuote.SumInsured,
                Premium = selectedQuote.Premium,
                Customer = selectedQuote.Customer,
                CustomerNumber = selectedQuote.CustomerNumber,
                LostRatio = selectedQuote.LostRatio,
                CustomerAddress = selectedQuote.CustomerAddress,
                RequireUnderWriting = selectedQuote.QuoteStatus,
                RateApplied = selectedQuote.Rate,
                PreviousQuoteId = selectedQuote.PreviousQuoteId,
                VersionNumber = selectedQuote.VersionNumber,
                PreviousVersions = previousVersions,
                Discount = selectedQuote.Discount,
                AttributeResponse = groupedAttributes,
                RequireUnderWritingApproval = selectedQuote.RequiresUnderwritingApproval,

                NegotiationResponse = selectedQuote.QuoteNegotiation.Select(d => new NegotiationResponse
                {
                    Comments = d.Remarks,
                    CreateBy = d.InitiatedBy,
                }).FirstOrDefault(),
                QuotePriceResponse = quotePriceResponse
            };

            response.Data = quotationResponse;
            response.Success = true;
            response.ResponseMessage = "Quotation retrieved successfully!";
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return response;
        }
        private async Task<List<Quotation>> GetPredecessorsAsync(Quotation quote)
        {
            var predecessors = new List<Quotation>();
            while (quote.PreviousQuoteId != null)
            {
                quote = await _rubyContext.Quotations.FirstOrDefaultAsync(q => q.Id == quote.PreviousQuoteId);
                if (quote != null) predecessors.Add(quote);
            }
            return predecessors;
        }
        private async Task<List<Quotation>> GetSuccessorsAsync(Quotation quote)
        {
            var successors = await _rubyContext.Quotations
                .Where(q => q.PreviousQuoteId == quote.Id)
                .ToListAsync();

            var allSuccessors = new List<Quotation>(successors);

            foreach (var successor in successors)
            {
                allSuccessors.AddRange(await GetSuccessorsAsync(successor));
            }

            return allSuccessors;
        }
        public async Task<BaseResponse<PaginatedQuotationResponses>> GetAllQuotation(QuotationFilterDto request)
        {
            var response = new BaseResponse<PaginatedQuotationResponses>();

            // Query to retrieve quotations
            var query = _rubyContext.Quotations
                 .Where(qt => !qt.IsLocked && qt.IsActive == true)
                 .Include(qt => qt.BusinessType)
                 .Include(qt => qt.QuoteType)
                 .Include(qt => qt.Product)
                     //.ThenInclude(p => p.ProductClass) // Ensure this is correct
                 .AsNoTracking().OrderByDescending(p => p.CreateAt)
                 .Select(qt => new QuotationResponses
                {
                    Id = qt.Id,
                   // ProductClass = qt.Product.ProductClass != null ? qt.Product.ProductClass.Name : null, 
                    QuoteId = qt.QuoteId,
                    CreatedBy = qt.CreateBy,
                    CreateAt = qt.CreateAt,
                    ResponseSLA = qt.SLA,
                    SLAUsage = CalculateSlaPercentage(qt.CreateAt),
                    Customer = qt.Customer,
                    BusinessType = qt.BusinessType.Name,  
                    QuoteType = qt.QuoteType.Name,
                    IsLocked = qt.IsLocked,
                    QuoteStatus = qt.QuoteStatus,
                    ProductName = qt.Product.Name
                });


            if (!string.IsNullOrEmpty(request.BusinessType))
            {
                query = query.Where(qt => qt.BusinessType == request.BusinessType);
            }

            if (!string.IsNullOrEmpty(request.CreatedBy))
            {
                query = query.Where(qt=>qt.CreatedBy == request.CreatedBy);
            }

            if (request.CreateDateFrom.HasValue)
            {
                query = query.Where(qt => qt.CreateAt >= request.CreateDateFrom.Value);
            }
            if (request.CreateDateTo.HasValue)
            {
                query = query.Where(qt => qt.CreateAt <= request.CreateDateTo.Value);
            }

            if (!string.IsNullOrEmpty(request.ProductClass))
            {
                query = query.Where(qt => qt.ProductClass == request.ProductClass); 
            }
            if (!string.IsNullOrEmpty(request.QuoteStatus))
            {
                query = query.Where(qt=>qt.QuoteStatus == request.QuoteStatus);
            }
            if(!string.IsNullOrEmpty(request.ProductName))
            {
                query = query.Where(qt=>qt.ProductName == request.ProductName);
            }

            // Apply pagination
            var pagedQuotations = await PagedList<QuotationResponses>
                .ToPagedList(query, request.PageNumber, request.PageSize); // Make sure this is async

            // Build the response with pagination details
            var paginatedQuotationResponse = new PaginatedQuotationResponses
            {
                PageNumber = pagedQuotations.PageNumber,
                PageSize = pagedQuotations.PageSize,
                TotalCount = pagedQuotations.TotalCount,
                TotalPages = pagedQuotations.TotalPages,
                HasPreviousPage = pagedQuotations.HasPreviousPage,
                HasNextPage = pagedQuotations.HasNextPage,
                QuotationResponses = pagedQuotations.ToList() // Get the list of quotations
            };

            // Set response properties
            response.Success = true;
            response.ResponseMessage = "Quotations fetched successfully";
            response.Data = paginatedQuotationResponse;
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return response;
        }
        public async Task<BaseResponse<PaginatedQuotationResponses>> GetAllUnderWritingQuotation(QuotationFilterDto request)
        {
            var response = new BaseResponse<PaginatedQuotationResponses>();

            // Query to retrieve quotations where quote is sent for review or negotiation 
            var query = _rubyContext.Quotations
                .Where(qt => !qt.IsLocked && qt.IsActive == true)
                .Where(qt => qt.QuoteStatus == QuotationStatus.Review.ToString() || qt.QuoteStatus == QuotationStatus.Negotiation.ToString())
                .Include(qt => qt.BusinessType)
                .Include(qt => qt.QuoteType)
                .Include(qt => qt.Product)
                   // .ThenInclude(p => p.ProductClass)
                .AsNoTracking()
                .OrderByDescending(p => p.CreateAt)
                .Select(qt => new QuotationResponses
                {
                    Id = qt.Id,
                   // ProductClass = qt.Product.ProductClass != null ? qt.Product.ProductClass.Name : null,
                    QuoteId = qt.QuoteId,
                    CreatedBy = qt.CreateBy,
                    CreateAt = qt.CreateAt,
                    ResponseSLA = qt.SLA,
                    Customer = qt.Customer,
                    BusinessType = qt.BusinessType.Name,
                    QuoteType = qt.QuoteType.Name,
                    IsLocked = qt.IsLocked,
                    QuoteStatus = qt.QuoteStatus,
                    ProductName = qt.Product.Name
                });

            // Apply filters
            if (!string.IsNullOrEmpty(request.BusinessType))
            {
                query = query.Where(qt => qt.BusinessType == request.BusinessType);
            }

            if (!string.IsNullOrEmpty(request.CreatedBy))
            {
                query = query.Where(qt => qt.CreatedBy == request.CreatedBy);
            }

            if (request.CreateDateFrom.HasValue)
            {
                query = query.Where(qt => qt.CreateAt >= request.CreateDateFrom.Value);
            }

            if (request.CreateDateTo.HasValue)
            {
                query = query.Where(qt => qt.CreateAt <= request.CreateDateTo.Value);
            }

            if (!string.IsNullOrEmpty(request.ProductClass))
            {
                query = query.Where(qt => qt.ProductClass == request.ProductClass);
            }

            if (!string.IsNullOrEmpty(request.QuoteStatus))
            {
                query = query.Where(qt => qt.QuoteStatus == request.QuoteStatus);
            }

            if (!string.IsNullOrEmpty(request.ProductName))
            {
                query = query.Where(qt => qt.ProductName == request.ProductName);
            }

            // Apply pagination
            var pagedQuotations = await PagedList<QuotationResponses>
                .ToPagedList(query, request.PageNumber, request.PageSize);

            // After fetching the data, calculate the SLA percentage
            foreach (var quotation in pagedQuotations)
            {
                quotation.SLAUsage = CalculateSlaPercentage(quotation.CreateAt);
            }

            // Build the response with pagination details
            var paginatedQuotationResponse = new PaginatedQuotationResponses
            {
                PageNumber = pagedQuotations.PageNumber,
                PageSize = pagedQuotations.PageSize,
                TotalCount = pagedQuotations.TotalCount,
                TotalPages = pagedQuotations.TotalPages,
                HasPreviousPage = pagedQuotations.HasPreviousPage,
                HasNextPage = pagedQuotations.HasNextPage,
                QuotationResponses = pagedQuotations.ToList() // Get the list of quotations
            };

            // Set response properties
            response.Success = true;
            response.ResponseMessage = "Quotations fetched successfully";
            response.Data = paginatedQuotationResponse;
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return response;
        }
        public async Task<BaseResponse<PaginatedQuotationResponses>> GetMyUnderWritingQuotations(QuotationFilterDto request)
        {
            var response = new BaseResponse<PaginatedQuotationResponses>();

            // Query to retrieve quotations where quote is sent for review or negotiation 
            var query = _rubyContext.Quotations
                .Where(qt => qt.IsLocked)
                .Where(qt => qt.LockedBy == UserClaims())
                .Where(qt => qt.QuoteStatus == QuotationStatus.Review.ToString() || qt.QuoteStatus == QuotationStatus.Negotiation.ToString())
                .Include(qt => qt.BusinessType)
                .Include(qt => qt.QuoteType)
                .Include(qt => qt.Product)
                   // .ThenInclude(p => p.ProductClass)
                .AsNoTracking()
                .OrderByDescending(p => p.CreateAt)
                .Select(qt => new QuotationResponses
                {
                    Id = qt.Id,
                   // ProductClass = qt.Product.ProductClass != null ? qt.Product.ProductClass.Name : null,
                    QuoteId = qt.QuoteId,
                    CreatedBy = qt.CreateBy,
                    CreateAt = qt.CreateAt,
                    ResponseSLA = qt.SLA,
                    Customer = qt.Customer,
                    BusinessType = qt.BusinessType.Name,
                    QuoteType = qt.QuoteType.Name,
                    IsLocked = qt.IsLocked,
                    QuoteStatus = qt.QuoteStatus,
                    ProductName = qt.Product.Name
                });

            // Apply filters
            if (!string.IsNullOrEmpty(request.BusinessType))
            {
                query = query.Where(qt => qt.BusinessType == request.BusinessType);
            }

            if (!string.IsNullOrEmpty(request.CreatedBy))
            {
                query = query.Where(qt => qt.CreatedBy == request.CreatedBy);
            }

            if (request.CreateDateFrom.HasValue)
            {
                query = query.Where(qt => qt.CreateAt >= request.CreateDateFrom.Value);
            }

            if (request.CreateDateTo.HasValue)
            {
                query = query.Where(qt => qt.CreateAt <= request.CreateDateTo.Value);
            }

            if (!string.IsNullOrEmpty(request.ProductClass))
            {
                query = query.Where(qt => qt.ProductClass == request.ProductClass);
            }

            if (!string.IsNullOrEmpty(request.QuoteStatus))
            {
                query = query.Where(qt => qt.QuoteStatus == request.QuoteStatus);
            }

            if (!string.IsNullOrEmpty(request.ProductName))
            {
                query = query.Where(qt => qt.ProductName == request.ProductName);
            }

            // Apply pagination
            var pagedQuotations = await PagedList<QuotationResponses>
                .ToPagedList(query, request.PageNumber, request.PageSize);

            // After fetching the data, calculate the SLA percentage
            foreach (var quotation in pagedQuotations)
            {
                quotation.SLAUsage = CalculateSlaPercentage(quotation.CreateAt);
            }

            // Build the response with pagination details
            var paginatedQuotationResponse = new PaginatedQuotationResponses
            {
                PageNumber = pagedQuotations.PageNumber,
                PageSize = pagedQuotations.PageSize,
                TotalCount = pagedQuotations.TotalCount,
                TotalPages = pagedQuotations.TotalPages,
                HasPreviousPage = pagedQuotations.HasPreviousPage,
                HasNextPage = pagedQuotations.HasNextPage,
                QuotationResponses = pagedQuotations.ToList() // Get the list of quotations
            };

            // Set response properties
            response.Success = true;
            response.ResponseMessage = "Quotations fetched successfully";
            response.Data = paginatedQuotationResponse;
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return response;
        }
        public async Task<BaseResponse<ViewQuoteDetailedResponse>> GetQuotePreviewForPicking(int QuoteId)
        {
            var response = new BaseResponse<ViewQuoteDetailedResponse>();

            var quotation = await _rubyContext.Quotations
                .Include(q => q.QuotationAttributeValues)
                .Include(q => q.QuoteNegotiation)
                .Include(q => q.QuotePreferences)
                .Include(q => q.QuoteType)
                .Include(q => q.BusinessType)
                .Include(q => q.PolicyDuration)
                .Include(q => q.QuotationBaseCovers)
                .Include(q => q.QuotationAdditionalCovers)
                .Include(q => q.Product)
                //.ThenInclude(q => q.ProductClass)
                .Include(q => q.Product)
                .ThenInclude(q => q.ProductSubjectCategories)
                .ThenInclude(q => q.ProductSubjectTypeAttributes)
                .Include(q => q.Product)
                .ThenInclude(q => q.ProductPenalties)
                .Include(q => q.QuotationAttributeValues)
                .ThenInclude(attr => attr.ProductSubjectTypeAttribute)
                
                .Where(av => av.IsLocked == true)
                .Where(qt => qt.QuoteStatus == QuotationStatus.Review.ToString() || qt.QuoteStatus == QuotationStatus.Negotiation.ToString())
                .FirstOrDefaultAsync(q => q.Id == QuoteId || q.PreviousQuoteId == QuoteId);

            if (quotation == null)
            {
                response.Success = true;
                response.ResponseMessage = "Quote Not Found";
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                return response;
            }

            // List to hold all related versions of the quote (predecessors and successors)
            var versionResponses = new List<VersionResponse>();

            // Function to get all predecessors
            async Task<List<Quotation>> GetPredecessorsAsync(Quotation quote)
            {
                var predecessors = new List<Quotation>();
                var currentQuote = quote;

                while (currentQuote.PreviousQuoteId != null)
                {
                    currentQuote = await _rubyContext.Quotations
                        .FirstOrDefaultAsync(q => q.Id == currentQuote.PreviousQuoteId);
                    if (currentQuote != null)
                    {
                        predecessors.Add(currentQuote);
                    }
                }

                return predecessors;
            }


            // Function to get all successors
            async Task<List<Quotation>> GetSuccessorsAsync(Quotation quote)
            {
                var successors = await _rubyContext.Quotations
                    .Where(q => q.PreviousQuoteId == quote.Id)
                    .ToListAsync();

                var allSuccessors = new List<Quotation>();
                foreach (var successor in successors)
                {
                    allSuccessors.Add(successor);
                    allSuccessors.AddRange(await GetSuccessorsAsync(successor)); // Recursively get successors
                }

                return allSuccessors;
            }

            // Fetch all predecessors of the selected quote
            var predecessors = await GetPredecessorsAsync(quotation);

            // Fetch all successors of the selected quote
            var successors = await GetSuccessorsAsync(quotation);

            // Combine predecessors, selected quote, and successors into one list
            var allRelatedQuotes = new List<Quotation>();
            allRelatedQuotes.AddRange(predecessors);
            allRelatedQuotes.Add(quotation);  // Include the selected quote itself
            allRelatedQuotes.AddRange(successors);

            // Populate version response for each related quote
            foreach (var relatedQuote in allRelatedQuotes)
            {
                versionResponses.Add(new VersionResponse
                {
                    VersionNumber = relatedQuote.VersionNumber,
                    CreatedBy = relatedQuote.CreateBy,
                    CreatedAt = relatedQuote.CreateAt,
                    QuoteId = relatedQuote.Id,
                });
            }

            // Order the version responses by VersionNumber in descending order
            var previousVersions = versionResponses.OrderByDescending(v => v.VersionNumber).ToList();

            // Get the category name by matching the ProductSubjectCategoryId in ProductSubjectTypeAttributes
            var categoryName = quotation.Product.ProductSubjectCategories
                .FirstOrDefault(category => category.Id ==
                    quotation.Product.ProductSubjectCategories
                    .SelectMany(c => c.ProductSubjectTypeAttributes)
                    .FirstOrDefault()?.ProductSubjectCategoryId
                )?.CategoryName;



            // Load Base and Additional covers list
            var baseCoversList = quotation.Product.ProductBaseSubjectTypeCovers.Select(x => x.BaseCoverId).Distinct().ToList();
            var additionalCoverList = quotation.Product.ProductAdditionalSubjectTypeCovers.Select(x => x.AdditionalCoverId).Distinct().ToList();

            // Fetch cover names
            var baseCoverNamesResponse = await _adminService.RiderNamesById(baseCoversList);
            var additionalCoverNamesResponse = await _adminService.RiderNamesById(additionalCoverList);

            var baseCoverName = baseCoverNamesResponse.Data ?? new List<string>();
            var additionalCoverName = additionalCoverNamesResponse.Data ?? new List<string>();

            var baseCoverDict = baseCoversList.Zip(baseCoverName, (id, name) => new { id, name })
                                        .ToDictionary(x => x.id, x => x.name);

            var addtionalCoverDict = additionalCoverList.Zip(additionalCoverName, (id, name) => new { id, name })
                                       .ToDictionary(x => x.id, x => x.name);



            // Fetch all entity IDs from the quotation's attribute values
            var entityIds = quotation.QuotationAttributeValues.Select(attr => attr.EntityId).Distinct().ToList();

            if (!entityIds.Any())
            {
                response.Success = false;
                response.ResponseMessage = "No Entity IDs found for the selected quotation.";
                response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return response;
            }

            var baseCoverDetails = await _rubyContext.ProductBaseCovers.ToListAsync();
            var additionalCoverDetails = await _rubyContext.ProductAdditionalCovers.ToListAsync();

            // Fetch the quotation attribute values and populate attribute response
            var attributeResponses = quotation.QuotationAttributeValues
                .Where(attr => attr.QuotationId == QuoteId)
                .Select(attr => new AttributeDetailedResponseList
                {
                    Id = attr.Id,
                    Category = categoryName,
                    AttributeId = attr.AttributeId,
                    AttributeName = attr.AttributeName,
                    AttributeValue = attr.AttributeValue,
                    EntityId = attr.EntityId,
                }).ToList();

            // Fetch base and additional covers for all entity IDs
            var quotationBaseCoversList = quotation.QuotationBaseCovers
                .Where(b => entityIds.Contains(b.EntityId))
                .ToList();

            var quotationAdditionalCoversList = quotation.QuotationAdditionalCovers
                .Where(a => entityIds.Contains(a.EntityId))
                .ToList();


            // Group attributes by EntityId
            var groupedAttributes = attributeResponses.GroupBy(attr => attr.EntityId)
                .Select(group => new AttributeDetailedResponse
                {
                    EntityId = group.Key,
                    AttributeDetailedResponseList = group.Select(attr => new AttributeDetailedResponseList
                    {
                        Id = attr.Id,
                        Category = categoryName,
                        AttributeId = attr.AttributeId,
                        AttributeName = attr.AttributeName,
                        AttributeValue = attr.AttributeValue,
                        EntityId = attr.EntityId,

                    }).ToList(),



                    QuotationBaseCovers = quotationBaseCoversList
                        .Where(b => b.EntityId == group.Key)
                        .Select(baseCover => new QuotationBaseCoverResponse
                        {
                            Id = baseCover.Id,
                            ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
                            CoverName = baseCover.CoverName,
                            Status = baseCover.CoverStatus,
                            Price = baseCover.Price,
                            MaximumAmount = baseCoverDetails.FirstOrDefault(b => b.Id == baseCover.ProductBaseSubjectTypeCoverId).MaximumAmount,
                            RateApplied = baseCoverDetails.FirstOrDefault(b => b.Id == baseCover.ProductBaseSubjectTypeCoverId).RateApplied,
                            Indicator = baseCover.Indicator,
                            Comment = baseCover.Comment,
                        }).ToList(),

                    QuotationAdditionalCovers = quotationAdditionalCoversList
                        .Where(a => a.EntityId == group.Key)
                        .Select(additionalCover => new QuotationAdditionalCoverResponse
                        {
                            Id = additionalCover.Id,
                            ProductBaseSubjectTypeCoverId = additionalCover.ProductAdditionalSubjectTypeCoverId,
                            CoverName = additionalCover.CoverName,
                            Status = additionalCover.CoverStatus,
                            Price = additionalCover.Price,
                            MaximumAmount = additionalCoverDetails.FirstOrDefault(b => b.Id == additionalCover.ProductAdditionalSubjectTypeCoverId).MaximumAmount,
                            RateApplied = additionalCoverDetails.FirstOrDefault(b => b.Id == additionalCover.ProductAdditionalSubjectTypeCoverId).RateApplied,
                            Indicator = additionalCover.Indicator,
                            Comment =additionalCover.Comment
                        }).ToList()
                }).ToList();

           
            var productNameResponse = await _adminService.GetSingleProductClass(quotation.Product.ProductClassId);
            var productResponse  = productNameResponse.Success ? productNameResponse.Data : $"Unknown (ID: Product Id)";


            var quotePriceResponse = await GetQuotePriceResponsesWithCoverNames(quotation);



            ViewQuoteDetailedResponse quotationResponse = new()
            {
                Id = quotation.Id,
                BusinessType = new NestedIdNameResponse
                {
                    Id = quotation.BusinessType.Id,
                    Name = quotation.BusinessType.Name,
                },
                QuotePreference = new NestedIdNameResponse
                {
                    Id = quotation.BusinessType.Id,
                    Name = quotation.QuotePreferences.Name
                },
                QuoteType = new NestedIdNameResponse
                {
                    Id = quotation.QuoteType.Id,
                    Name = quotation.QuoteType.Name,
                },

                PolicyDuration = new NestedIdNameResponse
                {
                    Id = quotation.PolicyDuration.Id,
                    Name = quotation.PolicyDuration.Name
                },

                Product = new NestedIdNameResponse
                {
                    Id = quotation.Product.Id,
                    Name = quotation.Product.Name,
                },

                ProductClass = new NestedIdNameResponse
                {
                    Id = quotation.Product.ProductClassId,
                    Name = productResponse
                },
                RiskLocation = quotation.RiskLocation,
                StateOfOperation = quotation.StateOfOperation,
                Channel = quotation.Channel,
                SLA = quotation.SLA,
                Customer = quotation.Customer,
                CreateAt = quotation.CreateAt,
                CreateBy = quotation.CreateBy,
                SLAUsage = quotation.SLAUsage,
                SumInsured = quotation.SumInsured,
                IsLocked = quotation.IsLocked,
                Premium = quotation.Premium,
                LostRatio = quotation.LostRatio,
                RateApplied = quotation.Rate,
                RequireUnderWriting = quotation.QuoteStatus,
                CustomerAddress = quotation.CustomerAddress,
                Discount = quotation.Discount,

                NegotiationResponse = quotation.QuoteNegotiation.Select(d => new NegotiationResponse
                {
                    Comments = d.Remarks,
                    CreateBy = d.InitiatedBy,
                }).FirstOrDefault(),

                AttributeResponse = groupedAttributes,

                PenaltyDetailedResponse = quotation.Product.ProductPenalties.Select(n => new PenaltyDetailedResponse
                {
                    Penalty = n.Penalty
                }).ToList(),

                PreviousVersions = previousVersions,
                QuotePriceResponse = quotePriceResponse


            };

            response.Success = true;
            response.ResponseMessage = "Quote retrieved Successfully";
            response.Data = quotationResponse;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }


        #region GetQuotePriceResponsesWithCoverNames

        //public async Task<List<QuotePriceResponse>> GetQuotePriceResponsesWithCoverNames(Quotation quotation)
        //{
        //    var priceConfig = await _rubyContext.ProductPriceConfigurations
        //                                .Where(d => d.CategoryId == quotation.Product.ProductSubjectCategories.FirstOrDefault().Id)
        //                                .ToListAsync();

        //    var subjectAttributes = await _rubyContext.ProductSubjectTypeAttributes
        //                               .Where(d => d.ProductSubjectCategoryId == quotation.Product.ProductSubjectCategories.FirstOrDefault().Id)
        //                               .ToListAsync();

        //    var quotePriceResponses = new List<QuotePriceResponse>();

        //    foreach (var pc in priceConfig)
        //    {
        //        var coverNames = new List<string>();

        //        // Fetch cover names for each CoverId
        //        foreach (var coverId in pc.CoverIds)
        //        {
        //            var coverNameResponse = await _adminService.GetCoverNameById(coverId);
        //            var coverName = coverNameResponse.Success ? coverNameResponse.Data : $"Unknown Cover (ID: {coverId})";
        //            coverNames.Add(coverName);
        //        }

        //        quotePriceResponses.Add(new QuotePriceResponse
        //        {
        //            AttributeName = subjectAttributes.FirstOrDefault(sa => sa.Id == pc.AttributeId)?.Name,
        //            AttributeId = pc.AttributeId,
        //            AttributeValue = pc.AttributeName,
        //            AffectPricing = pc.AffectPricing,
        //            AffectRate = pc.AffectRate,
        //            EffectType = pc.EffectType,
        //            Affects = pc.Affects,
        //            CoverNames = coverNames
        //        });
        //    }

        //    return quotePriceResponses;
        //}


        public async Task<List<QuotePriceResponse>> GetQuotePriceResponsesWithCoverNames(Quotation quotation)
        {
            // Get all price configurations associated with this quotation.
            var priceConfigs = await _rubyContext.QuotationPriceCalculationAudits
                                      .Where(d => d.QuoteId == quotation.Id)
                                      .ToListAsync();

            // Get subject attributes for the product category related to this quotation.
            var subjectAttributes = await _rubyContext.ProductSubjectTypeAttributes
                                         .Where(d => d.ProductSubjectCategoryId == quotation.Product.ProductSubjectCategories.FirstOrDefault().Id)
                                         .ToListAsync();

            // Build a dictionary of product price configurations keyed by AttributeId.
            var configDict = await _rubyContext.ProductPriceConfigurations
                                      .Where(d => priceConfigs.Select(pc => pc.AttributeId).Contains(d.AttributeId))
                                      .ToDictionaryAsync(d => d.AttributeId, d => d);

            var quotePriceResponses = new List<QuotePriceResponse>();

            
            var groupedConfigs = priceConfigs
                .GroupBy(pc => new { pc.AttributeId, pc.AppliedRate, pc.Affects });

            foreach (var group in groupedConfigs)
            {
                var attributeId = group.Key.AttributeId;
                var config = configDict.GetValueOrDefault(attributeId);
                var attributeName = subjectAttributes.FirstOrDefault(sa => sa.Id == attributeId)?.Name;
                var attributeValue = config?.AttributeName;
                var affectPricing = config?.AffectPricing;

                // Create a list of cover details that will hold both the CoverId and CoverName for each record in this group.
                var coverDetails = new List<CoverDetail>();

                // Process each cover within the group.
                // If any record in this group has a different applied rate (cover percentage), it will form a different group.
                foreach (var pc in group)
                {
                    var coverNameResponse = await _adminService.GetCoverNameById(pc.CoverId);
                    var coverName = coverNameResponse.Success ? coverNameResponse.Data : $"Unknown Cover (ID: {pc.CoverId})";

                    coverDetails.Add(new CoverDetail
                    {
                        CoverId = pc.CoverId,
                        CoverName = coverName
                    });
                }

                // Add one QuotePriceResponse for this group.
                quotePriceResponses.Add(new QuotePriceResponse
                {
                    AttributeId = attributeId,
                    AttributeName = attributeName,
                    AttributeValue = attributeValue,
                    AffectPricing = affectPricing ?? false,  // Provide a default value if null.
                    AffectRate = group.Key.AppliedRate,
                    EffectType = group.Key.Affects,
                    Affects = group.Key.Affects,
                    CoverDetails = coverDetails  // This list includes each cover's ID and name.
                });
            }

            return quotePriceResponses;
        }
        #endregion


        public async Task<BaseResponse<GenericNameResponse>> SubmitQuoteForReview(int quoteId, string remarks)
        {
            var response = new BaseResponse<GenericNameResponse>();
            var quotation = await _rubyContext.Quotations.FirstOrDefaultAsync(q => q.Id == quoteId);

            if (quotation == null)
            {
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                response.ResponseMessage = "Quote Not Found";
                return response;
            }

            if (quotation.QuoteStatus == QuotationStatus.Review.ToString())
            {
                response.StatusCode = System.Net.HttpStatusCode.Conflict;
                response.ResponseMessage = "Quote is already at review stage";
                return response;
            }

            if (string.IsNullOrWhiteSpace(remarks))
            {
                return ResponseFactory.CreateError<GenericNameResponse>("Remarks cannot be empty.", HttpStatusCode.BadRequest);
            }
         

            quotation.QuoteStatus = QuotationStatus.Review.ToString();


            try
            {

                var newNegotiation = new QuoteNegotiation
                {
                    QuoteId = quoteId,
                    NegotiationRound = await GetNextNegotiationRound(quoteId),
                    RequestedDiscount = 0,
                    NegotiationStatus = QuotationStatus.Review.ToString(),
                    InitiatedBy = UserClaims(),
                    Remarks = remarks,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                };

                _rubyContext.QuoteNegotiations.Add(newNegotiation);
                await _rubyContext.SaveChangesAsync(); // Save changes to database
                response.Success = true;
                response.StatusCode = HttpStatusCode.OK;
                response.ResponseMessage = "Quote successfully submitted for review";
            }
            catch (Exception ex)
            {
                // Log the exception and return an error response
                response.Success = false;
                response.StatusCode = HttpStatusCode.InternalServerError;
                response.ResponseMessage = "An error occurred while submitting the quote for review.";
            }

            return response;
        }
        public async Task<BaseResponse<GenericNameResponse>> ReviewQuote(int originalQuoteId, QuotationReviewRequest request)
        {
            var response = new BaseResponse<GenericNameResponse>();

            // Fetch the original quote
            var originalQuote = await _rubyContext.Quotations
                .Include(p => p.Product)
                .FirstOrDefaultAsync(d => d.Id == originalQuoteId);

            if (originalQuote == null)
            {
                response.Success = false;
                response.ResponseMessage = "Original quote not found";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }


            string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

            // Get all versions of the quote by QuoteId
            var quoteVersions = await _rubyContext.Quotations
                .Where(q => q.QuoteId == originalQuote.QuoteId)
                .OrderByDescending(q => q.VersionNumber)
                .ToListAsync();
            
            // Determine the new version number
            int newVersionNumber = quoteVersions.Any() ? quoteVersions.First().VersionNumber + 1 : 1;
            decimal? discountAmount = request.Premium * (request.Discount / 100);
            decimal? finalPremium = request.Premium - discountAmount;



            


            // Create the new quotation object
            var quotation = new Quotation
            {
                ProductClass = request.ProductClass,
                QuoteId = originalQuote.QuoteId, // Keep the same QuoteId for new versions
                BusinessTypeId = request.BusinessTypeId,
                QuotePreferencesId = request.QuotePreferencesId,
                QuoteTypeId = request.QuoteTypeId,
                PolicyDurationId = request.PolicyDurationId,
                ProductId = request.ProductId,
                RiskLocation = request.RiskLocation,
                StateOfOperation = request.StateOfOperation,
                Channel = request.Channel,
                CreateAt = DateTime.UtcNow,
                CreateBy = UserClaims(),
                Customer = customerName,
                SLA = CalculateSLAInMinutes(),
                Rate = request.Rate,
                LostRatio = request.LostRatio,
                SLAUsage = 0,
                QuoteStatus = "Reviewed",
                PreviousQuoteId = quoteVersions.First().Id,
                VersionNumber = newVersionNumber,
                Premium = finalPremium,
                SumInsured = request.SumInsured,
                Discount = request.Discount,
                IsActive = true,
                RequiresUnderwritingApproval=false
                
            };

          



            // Transaction to ensure atomicity
            using var transaction = await _rubyContext.Database.BeginTransactionAsync();
            try
            {
                // Add and save quotation
                _rubyContext.Quotations.Add(quotation);
                await _rubyContext.SaveChangesAsync();

               

                // Handle Attributes (Update or Add New)
                var attributesToAddOrUpdate = new List<QuotationAttributeValue>();
                var baseCoversToAdd = new List<QuotationBaseCover>();
                var additionalCoversToAdd = new List<QuotationAdditionalCover>();

                foreach (var attributeResponse in request.AttributeResponse)
                {
                    foreach (var attributeDetail in attributeResponse.AttributeDetailedResponseList)
                    {
                        // If the attribute does not exist, create a new one
                        attributesToAddOrUpdate.Add(new QuotationAttributeValue
                        {
                            QuotationId = quotation.Id,
                            AttributeName = attributeDetail.AttributeName,
                            AttributeValue = attributeDetail.AttributeValue,
                            AttributeId = attributeDetail.Id,
                            EntityId = attributeDetail.EntityId
                        });


                    }
                }

                originalQuote.IsLocked = false;
                originalQuote.LockedBy = null;
                originalQuote.QuoteStatus = "Reviewed";
                originalQuote.IsActive = false;
              

                _rubyContext.QuotationAttributeValues.AddRange(attributesToAddOrUpdate);
                await _rubyContext.SaveChangesAsync();

                decimal TotalPremium = 0;
                decimal totalCoverPrice = 0;

              
                var entityGroups = request.AttributeResponse
                  .SelectMany(ar => ar.AttributeDetailedResponseList)
                  .GroupBy(attr => attr.EntityId)
                  .ToList();

                // Loop through each entity group
                foreach (var entityGroup in entityGroups)
                {
                    var entityId = entityGroup.Key;

                    // Fetch base and additional covers for this entity
                    var baseCovers = await _rubyContext.ProductBaseCovers
                        .Where(bc => bc.ProductId == request.ProductId)
                        .ToListAsync();

                    var additionalCovers = await _rubyContext.ProductAdditionalCovers
                        .Where(ac => ac.ProductId == request.ProductId)
                        .ToListAsync();

                    // Add Base Covers
                    var quotationBaseCovers = request.BaseCoverRequest
                        .Where(bc => bc.EntityId == entityId)
                        .Select(baseCover =>
                        {
                            var matchingBaseCover = baseCovers.FirstOrDefault(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);
                            decimal baseCoverPremium = 0;

                            if (matchingBaseCover != null)
                            {
                                baseCoverPremium = (matchingBaseCover.RateApplied / 100) * matchingBaseCover.MaximumAmount;
                                TotalPremium += baseCoverPremium;
                                totalCoverPrice += baseCover.Price;
                            }

                            return new QuotationBaseCover
                            {
                                EntityId = entityId,
                                ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
                                CoverStatus = baseCover.CoverStatus,
                                CoverName = baseCover.CoverName,
                                QuotationId = quotation.Id,
                                Price = baseCover.Price,
                            };
                        }).ToList();

                    _rubyContext.QuotationBaseCovers.AddRange(quotationBaseCovers);

                    // Add Additional Covers
                    var quotationAdditionalCovers = request.AdditionalCoverRequest
                        .Where(ac => ac.EntityId == entityId) // Match EntityId
                        .Select(additionalCover =>
                        {
                            return new QuotationAdditionalCover
                            {
                                EntityId = entityId,
                                ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
                                CoverStatus = additionalCover.CoverStatus,
                                CoverName = additionalCover.CoverName,
                                QuotationId = quotation.Id,
                                Price = additionalCover.Price,
                            };
                        }).ToList();

                    _rubyContext.QuotationAdditionalCovers.AddRange(quotationAdditionalCovers);
                }

                var newNegotiation = new QuoteNegotiation
                {
                    QuoteId = originalQuoteId,
                    NegotiationRound = await GetNextNegotiationRound(originalQuoteId),
                    RequestedDiscount = 0,
                    NegotiationStatus = QuotationStatus.Review.ToString(),
                    InitiatedBy = UserClaims(),
                    Remarks = request.Reason,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
              
                _rubyContext.QuoteNegotiations.Add(newNegotiation);

                var quotationPrice = request.PriceConfigureUpdates
                        .SelectMany(update => update.CoverId.Select(coverId => new QuotationPriceCalculationAudit
                        {
                            QuoteId = quotation.Id,
                            AttributeId = update.AttributeId,
                            AppliedRate = update.EffectRate,
                            Affects = update.EffectType,
                            Comment = "CoverUpdate",
                            AdjustedPremium = update.NewPrice,
                            CoverId = coverId
                        }))
                        .ToList();
                // Save changes and commit the transaction

                _rubyContext.QuotationPriceCalculationAudits.AddRange(quotationPrice);

                await _rubyContext.SaveChangesAsync();
                await transaction.CommitAsync();

                response.Success = true;
                response.ResponseMessage = "Quotation Reviewed Successfully";
                response.StatusCode = HttpStatusCode.Created;
            }
            catch (Exception ex)
            {
                // Rollback transaction and log error
                await transaction.RollbackAsync();
                response.Success = false;
                response.ResponseMessage = $"Failed to review quotation: {ex}";
                response.StatusCode = HttpStatusCode.InternalServerError;
            }

            return response;
        }




        #region

        public async Task<BaseResponse<GenericNameResponse>> ValidatePriceConfigureUpdate(int attributeId, decimal effectRate)
        {
            // 1. Get the price configuration using the attribute ID
            var price = await _rubyContext.ProductPriceConfigurations
                .FirstOrDefaultAsync(d => d.AttributeId == attributeId);

            if (price == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Attribute not found", HttpStatusCode.NotFound);

            // 2. Get the list of approvers attached to the price configuration
            var privileges = await _rubyContext.ProductApprovingOfficePriceConfigurations
                .Where(d => d.ConfigurationId == price.Id)
                .ToListAsync();

            if (privileges == null || !privileges.Any())
                return ResponseFactory.CreateError<GenericNameResponse>("Please set permission", HttpStatusCode.NotFound);

            // 3. Get the user info from Admin API (users in the approving office)
            var workflowConfig = await _adminService.GetUserId(_configModels.UnderwritingTeamApprovingOffice);

            if (workflowConfig?.Data == null || !workflowConfig.Data.Any())
                return ResponseFactory.CreateError<GenericNameResponse>("Unable to retrieve workflow config", HttpStatusCode.BadRequest);

            var authenticatedUser = GetUserClaims();

            if (string.IsNullOrEmpty(authenticatedUser))
                return ResponseFactory.CreateError<GenericNameResponse>("Authenticated user not found", HttpStatusCode.Unauthorized);

            // 4. Find matching user in workflow config
            var matchedUser = workflowConfig.Data.FirstOrDefault(u => u.User.AdUsername == authenticatedUser);
            if (matchedUser == null)
                return ResponseFactory.CreateError<GenericNameResponse>($"User does not have the required privilege {authenticatedUser}", HttpStatusCode.Unauthorized);

            // 5. Check if this user has privilege for this config
            var userPrivilege = privileges.FirstOrDefault(p => p.FunctionId == matchedUser.FunctionId);
            if (userPrivilege == null)
                return ResponseFactory.CreateError<GenericNameResponse>("User does not have approval permission for this price config", HttpStatusCode.Unauthorized);

            // 6. Check if rate is within range
            if (effectRate < userPrivilege.MinPricePercentage)
                return ResponseFactory.CreateError<GenericNameResponse>($"Rate too low. Minimum allowed is {userPrivilege.MinPricePercentage}", HttpStatusCode.BadRequest);

            if (effectRate > userPrivilege.MaxPricePercentage)
                return ResponseFactory.CreateError<GenericNameResponse>($"Rate too high. Maximum allowed is {userPrivilege.MaxPricePercentage}", HttpStatusCode.BadRequest);

            // 7. Success
            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("User is authorized and rate is within limits", HttpStatusCode.OK);
        }

        private string GetUserClaims()
        {
            var userNameClaim = _contextAccessor.HttpContext?.User?.FindFirst("UserName")?.Value;
            return !string.IsNullOrEmpty(userNameClaim) ? userNameClaim : "Anonymous";
        }

        #endregion


        public async Task<BaseResponse<GenericNameResponse>> AcceptQuote(int quoteId)
        {
            var response = new BaseResponse<GenericNameResponse>();

            var quote = await _rubyContext.Quotations.FindAsync(quoteId);
            if (quote == null)
            {

                response.Success = false;
                response.ResponseMessage = "Quote not found";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }
            quote.QuoteStatus = "Accepted"; // or "Finalized"
            quote.AcceptedAt = DateTime.UtcNow;
            quote.IsLocked = false;
            quote.LockedBy = null;
            quote.RequiresUnderwritingApproval = false;
            await _rubyContext.SaveChangesAsync();


            response.Success = true;
            response.ResponseMessage = "Quote accepted successfully";
            response.StatusCode = HttpStatusCode.OK;
            return response;
           
        }
        public async Task<BaseResponse<GenericNameResponse>> RejectQuote(int originalQuoteId, QuotationReviewRequest request)
        {
            // Fetch the original quote
            var originalQuote = await _rubyContext.Quotations
                .Include(p => p.Product)
                .FirstOrDefaultAsync(d => d.Id == originalQuoteId);

            if (originalQuote == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>("Quote not Found", HttpStatusCode.NotFound);
            }

            string customerName = string.IsNullOrEmpty(request.Customer) ? "Anonymous" : request.Customer;

            // Get all versions of the quote by QuoteId
            var quoteVersions = await _rubyContext.Quotations
                .Where(q => q.QuoteId == originalQuote.QuoteId)
                .OrderByDescending(q => q.VersionNumber)
                .ToListAsync();

            // Determine the new version number
            int newVersionNumber = quoteVersions.Any() ? quoteVersions.First().VersionNumber + 1 : 1;

            // Create the new quotation object
            var quotation = new Quotation
            {
                ProductClass = request.ProductClass,
                QuoteId = originalQuote.QuoteId, // Keep the same QuoteId for new versions
                BusinessTypeId = request.BusinessTypeId,
                QuotePreferencesId = request.QuotePreferencesId,
                QuoteTypeId = request.QuoteTypeId,
                PolicyDurationId = request.PolicyDurationId,
                ProductId = request.ProductId,
                RiskLocation = request.RiskLocation,
                StateOfOperation = request.StateOfOperation,
                Channel = request.Channel,
                CreateAt = DateTime.UtcNow,
                CreateBy = UserClaims(),
                Customer = customerName,
                SLA = CalculateSLAInMinutes(),
                Rate = request.Rate,
                LostRatio = request.LostRatio,
                SLAUsage = 0,
                QuoteStatus = "Rejected",
                PreviousQuoteId = quoteVersions.First().Id,
                VersionNumber = newVersionNumber,
                Premium = request.Premium,
                SumInsured = request.SumInsured,
                Discount = request.Discount,
                IsActive = true,
                RequiresUnderwritingApproval = false
            };

            // Transaction to ensure atomicity
            using var transaction = await _rubyContext.Database.BeginTransactionAsync();
            try
            {
                // Add and save quotation
                _rubyContext.Quotations.Add(quotation);
                await _rubyContext.SaveChangesAsync();

                // Handle Attributes (Update or Add New)
                var attributesToAddOrUpdate = new List<QuotationAttributeValue>();

                foreach (var attributeResponse in request.AttributeResponse)
                {
                    foreach (var attributeDetail in attributeResponse.AttributeDetailedResponseList)
                    {
                        attributesToAddOrUpdate.Add(new QuotationAttributeValue
                        {
                            QuotationId = quotation.Id,
                            AttributeName = attributeDetail.AttributeName,
                            AttributeValue = attributeDetail.AttributeValue,
                            AttributeId = attributeDetail.Id,
                            EntityId = attributeDetail.EntityId
                        });
                    }
                }

                // Update original quote status
                originalQuote.IsLocked = false;
                originalQuote.LockedBy = null;
                originalQuote.QuoteStatus = "Rejected";
                originalQuote.IsActive = false;
                originalQuote.RejectedAt = DateTime.UtcNow;
                originalQuote.RejectionReason = request.Reason;

                _rubyContext.QuotationAttributeValues.AddRange(attributesToAddOrUpdate);
                await _rubyContext.SaveChangesAsync();

                decimal TotalPremium = 0;
                decimal totalCoverPrice = 0;

                // Group attributes by EntityId
                var entityGroups = request.AttributeResponse
                    .SelectMany(ar => ar.AttributeDetailedResponseList)
                    .GroupBy(attr => attr.EntityId)
                    .ToList();

                // Loop through each entity group
                foreach (var entityGroup in entityGroups)
                {
                    var entityId = entityGroup.Key;

                    // Fetch base and additional covers for this entity
                    var baseCovers = await _rubyContext.ProductBaseCovers
                        .Where(bc => bc.ProductId == request.ProductId)
                        .ToListAsync();

                    var additionalCovers = await _rubyContext.ProductAdditionalCovers
                        .Where(ac => ac.ProductId == request.ProductId)
                        .ToListAsync();

                    // Add Base Covers
                    var quotationBaseCovers = request.BaseCoverRequest
                        .Where(bc => bc.EntityId == entityId) 
                        .Select(baseCover =>
                        {
                            var matchingBaseCover = baseCovers.FirstOrDefault(bc => bc.Id == baseCover.ProductBaseSubjectTypeCoverId);
                            decimal baseCoverPremium = 0;

                            if (matchingBaseCover != null)
                            {
                                baseCoverPremium = (matchingBaseCover.RateApplied / 100) * matchingBaseCover.MaximumAmount;
                                TotalPremium += baseCoverPremium;
                                totalCoverPrice += baseCover.Price;
                            }

                            return new QuotationBaseCover
                            {
                                EntityId = entityId,
                                ProductBaseSubjectTypeCoverId = baseCover.ProductBaseSubjectTypeCoverId,
                                CoverStatus = baseCover.CoverStatus,
                                CoverName = baseCover.CoverName,
                                QuotationId = quotation.Id,
                                Price = baseCover.Price,
                            };
                        }).ToList();

                    _rubyContext.QuotationBaseCovers.AddRange(quotationBaseCovers);

                    // Add Additional Covers
                    var quotationAdditionalCovers = request.AdditionalCoverRequest
                        .Where(ac => ac.EntityId == entityId) // Match EntityId
                        .Select(additionalCover =>
                        {
                            return new QuotationAdditionalCover
                            {
                                EntityId = entityId,
                                ProductAdditionalSubjectTypeCoverId = additionalCover.ProductBaseSubjectTypeCoverId,
                                CoverStatus = additionalCover.CoverStatus,
                                CoverName = additionalCover.CoverName,
                                QuotationId = quotation.Id,
                                Price = additionalCover.Price,
                            };
                        }).ToList();

                    _rubyContext.QuotationAdditionalCovers.AddRange(quotationAdditionalCovers);
                }

                // Create new negotiation entry
                var newNegotiation = new QuoteNegotiation
                {
                    QuoteId = originalQuoteId,
                    NegotiationRound = await GetNextNegotiationRound(originalQuoteId),
                    RequestedDiscount = 0,
                    NegotiationStatus = QuotationStatus.Review.ToString(),
                    InitiatedBy = UserClaims(),
                    Remarks = request.Reason,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                _rubyContext.QuoteNegotiations.Add(newNegotiation);

                // Save changes and commit the transaction
                await _rubyContext.SaveChangesAsync();
                await transaction.CommitAsync();

                return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Quotation Successfully Rejected", HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                // Rollback transaction and log error
                await transaction.RollbackAsync();
                return ResponseFactory.CreateError<GenericNameResponse>($"Failed to review quotation: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
        public async Task<BaseResponse<GenericNameResponse>> AssignQuoteToPersonalWorkbench(int quoteId)
        {
            var response = new BaseResponse<GenericNameResponse>();
            var checkQuoteExist = await _rubyContext.Quotations.FirstOrDefaultAsync(qd => qd.Id == quoteId);
            if (checkQuoteExist == null)
            {
                response.Success = false;
                response.ResponseMessage = $"Quote with ID {quoteId} does not exist";
                response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return response;
            }
            if(checkQuoteExist.IsLocked == true)
            {
                response.Success = false;
                response.ResponseMessage = $"This Quote is no longer available";
                response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return response;
            }
            checkQuoteExist.IsLocked = true;
            checkQuoteExist.LockedBy = UserClaims();
            await _rubyContext.SaveChangesAsync();

            response.Success = true;
            response.ResponseMessage = "Quote was picked by you for review ";
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }
        public async Task<BaseResponse<PaginatedQuotationResponses>> GetPickedQuotesByUnderwriter(QuotationFilterDto request) {
           
            var response = new BaseResponse<PaginatedQuotationResponses>();
            var user = _contextAccessor.HttpContext?.User?.FindFirst("UserName")?.Value;
            // Query to retrieve quotations where quote is sent for review or negotiation 
            var query = _rubyContext.Quotations
                .Where(qt=> qt.LockedBy == user)
                .Include(qt => qt.BusinessType)
                .Include(qt => qt.QuoteType)
                .Include(qt => qt.Product)
                    //.ThenInclude(p => p.ProductClass)
                .AsNoTracking()
                .OrderByDescending(p => p.CreateAt)
                .Select(qt => new QuotationResponses
                {
                    Id = qt.Id,
                 //   ProductClass = qt.Product.ProductClass != null ? qt.Product.ProductClass.Name : null,
                    QuoteId = qt.QuoteId,
                    CreatedBy = qt.CreateBy,
                    CreateAt = qt.CreateAt,
                    ResponseSLA = qt.SLA,
                    Customer = qt.Customer,
                    BusinessType = qt.BusinessType.Name,
                    QuoteType = qt.QuoteType.Name,
                    IsLocked = qt.IsLocked,
                    QuoteStatus = qt.QuoteStatus,
                    ProductName = qt.Product.Name
                });

            // Apply filters
            if (!string.IsNullOrEmpty(request.BusinessType))
            {
                query = query.Where(qt => qt.BusinessType == request.BusinessType);
            }

            if (!string.IsNullOrEmpty(request.CreatedBy))
            {
                query = query.Where(qt => qt.CreatedBy == request.CreatedBy);
            }

            if (request.CreateDateFrom.HasValue)
            {
                query = query.Where(qt => qt.CreateAt >= request.CreateDateFrom.Value);
            }

            if (request.CreateDateTo.HasValue)
            {
                query = query.Where(qt => qt.CreateAt <= request.CreateDateTo.Value);
            }

            if (!string.IsNullOrEmpty(request.ProductClass))
            {
                query = query.Where(qt => qt.ProductClass == request.ProductClass);
            }

            if (!string.IsNullOrEmpty(request.QuoteStatus))
            {
                query = query.Where(qt => qt.QuoteStatus == request.QuoteStatus);
            }

            if (!string.IsNullOrEmpty(request.ProductName))
            {
                query = query.Where(qt => qt.ProductName == request.ProductName);
            }

            // Apply pagination
            var pagedQuotations = await PagedList<QuotationResponses>
                .ToPagedList(query, request.PageNumber, request.PageSize);

            // After fetching the data, calculate the SLA percentage
            foreach (var quotation in pagedQuotations)
            {
                quotation.SLAUsage = CalculateSlaPercentage(quotation.CreateAt);
            }

            // Build the response with pagination details
            var paginatedQuotationResponse = new PaginatedQuotationResponses
            {
                PageNumber = pagedQuotations.PageNumber,
                PageSize = pagedQuotations.PageSize,
                TotalCount = pagedQuotations.TotalCount,
                TotalPages = pagedQuotations.TotalPages,
                HasPreviousPage = pagedQuotations.HasPreviousPage,
                HasNextPage = pagedQuotations.HasNextPage,
                QuotationResponses = pagedQuotations.ToList() // Get the list of quotations
            };

            // Set response properties
            response.Success = true;
            response.ResponseMessage = "Quotations fetched successfully";
            response.Data = paginatedQuotationResponse;
            response.StatusCode = System.Net.HttpStatusCode.OK;

            return response;

        }
        public async Task<BaseResponse<GenericNameResponse>> PrintQuote(int quoteId)
        {
            var response = new BaseResponse<GenericNameResponse>();

            var quote = await _rubyContext.Quotations.
                          FirstOrDefaultAsync(P=>P.Id  == quoteId);

            if (quote.QuoteStatus == QuotationStatus.Pending.ToString())
            {
                quote.QuoteStatus = QuotationStatus.Accepted.ToString();
                await _rubyContext.SaveChangesAsync();

                response.Success = true;
                response.ResponseMessage = "Quote printed Successfully"; 
                response.StatusCode= System.Net.HttpStatusCode.OK;
                return response;
            }

            response.Success = true;
            response.ResponseMessage = "Quote Requires UnderWriter";
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;

        }
        public async Task<BaseResponse<string>> InitiateRMQuoteNegotiation(QuoteNegotiationRequest request)
        {
            var response = new BaseResponse<string>();
            var quote = await _rubyContext.Quotations.FirstOrDefaultAsync(q => q.Id == request.quotationId);

            if (quote == null)
            {
                response.Success = false;
                response.ResponseMessage = "Quote not found";
                response.StatusCode = HttpStatusCode.NotFound; 
                return response;
            }
            var product  = await _rubyContext.Products.FirstOrDefaultAsync(p=>p.Id == quote.ProductId);

         
             var newNegotiation = new QuoteNegotiation{
                 QuoteId = request.quotationId,
                 NegotiationRound = await GetNextNegotiationRound(request.quotationId),
                 RequestedDiscount = request.requestedDiscount,
                 NegotiationStatus = QuotationStatus.Review.ToString(),
                 InitiatedBy = UserClaims(),
                 Remarks = request.remarks,
                 CreatedAt = DateTime.Now,
                 UpdatedAt = DateTime.Now

             };
           
             await _rubyContext.QuoteNegotiations.AddAsync(newNegotiation);

            quote.QuoteStatus = QuotationStatus.Review.ToString();
            await _rubyContext.SaveChangesAsync();


            response.Success = true;
            response.ResponseMessage = "Negotiation request has been submitted successfully.";
            return response;

        }
        public async Task<BaseResponse<string>> RespondToQuoteNegotiation(UnderwriterReplyRequest request)
        {
            var response = new BaseResponse<string>();

            // Find negotiation entry by quote ID
            var negotiation = await _rubyContext.QuoteNegotiations.FirstOrDefaultAsync(n => n.QuoteId == request.QuoteId);

            if (negotiation == null)
            {
                response.Success = false;
                response.ResponseMessage = "Negotiation not found";
                return response;
            }

                negotiation.ResponseDiscount = request.responseDiscount;
                negotiation.NegotiationStatus = request.Status; 
                negotiation.UpdatedAt = DateTime.Now;

                _rubyContext.QuoteNegotiations.Update(negotiation);
                await _rubyContext.SaveChangesAsync();
            

            await _rubyContext.SaveChangesAsync();

            response.Success = true;
            response.ResponseMessage = "Underwriter response recorded successfully.";
            return response;
        }
        public async Task<BaseResponse<List<PendingNegotiationDto>>> GetPendingNegotiations()
        {
            var response = new BaseResponse<List<PendingNegotiationDto>>();

            var pendingNegotiations = await _rubyContext.QuoteNegotiations
                 .Include(q => q.Quotation)
                .Where(n => n.QuoteId == 1)
                .Select(n => new PendingNegotiationDto
                {
                    Id = n.Id,
                    QuoteId = n.Quotation.Id,
                    QuoteCodeId = n.Quotation.QuoteId,
                    RequestedBy = n.InitiatedBy,
                    RequestedAt = n.CreatedAt,
                    Status = n.NegotiationStatus,
                              
                })
                .ToListAsync();

            if (pendingNegotiations == null || !pendingNegotiations.Any())
            {
                response.Success = false;
                response.ResponseMessage = "No pending negotiations found";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }
           
            response.Success = true;
            response.Data = pendingNegotiations;
            response.ResponseMessage = "Pending negotiations retrieved successfully.";
            return response;
        }  
        public async Task<BaseResponse<QuoteNegotiation>> GetSingleNegotiation(int Negotiation)
        {
            var response = new BaseResponse<QuoteNegotiation>();

            var negotiation = await _rubyContext.QuoteNegotiations.FirstOrDefaultAsync(n => n.Id == Negotiation);

            if (negotiation == null)
            {
                response.Success = false;
                response.ResponseMessage = "Negotiation not found for the given Quote ID";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            response.Success = true;
            response.Data = negotiation;
            response.ResponseMessage = "Negotiation details retrieved successfully.";
            return response;
        }


        
        public async Task<BaseResponse<string>> DownloadFile(int productId, string quotationPreference)
        {
            var response = new BaseResponse<string>();

            // Get product details
            var product = await _rubyContext.Products.Where(x => x.Id == productId)
                .Include(x => x.ProductSubjectTypes)
                    .ThenInclude(x => x.ProductSubjectTypeAttributes)
                .SingleOrDefaultAsync();

            if (product == null)
            {
                response.Success = false;
                response.ResponseMessage = "Product does not exist";
                response.StatusCode = HttpStatusCode.InternalServerError;
                return response;
            }

            if (string.IsNullOrEmpty(quotationPreference))
            {
                response.Success = false;
                response.ResponseMessage = "Please add QuotationPreference either Simulation or CustomerBase";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            // Fetch the category and generic category data
            var (categorySelections, genericCategory) = await GetCategoryData(productId);

            // Setup Excel package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var excel = new ExcelPackage())
            {
                int index = 1; // Unique sheet index

                foreach (var productSubjectType in product.ProductSubjectTypes)
                {
                    AddWorksheetWithAttributes(excel, productSubjectType, quotationPreference, categorySelections, genericCategory, index);
                    index++;
                }

                try
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        excel.SaveAs(memoryStream);
                        memoryStream.Position = 0;
                        response.Success = true;
                        response.ResponseMessage = Convert.ToBase64String(memoryStream.ToArray());
                        response.StatusCode = HttpStatusCode.OK;
                    }
                }
                catch (Exception ex)
                {
                    response.Success = false;
                    response.ResponseMessage = $"Error generating file: {ex.Message}";
                    response.StatusCode = HttpStatusCode.InternalServerError;
                }
            }

            return response;
        }

        private async Task<(List<ProductCategorySelection> categorySelections, List<LineOfBusinessAttributeItem> genericCategory)> GetCategoryData(int productId)
        {
            var categorySelections = await _rubyContext.ProductCategorySelections
                .Where(d => d.ProductId == productId)
                .ToListAsync();

            List<LineOfBusinessAttributeItem> genericCategory = new List<LineOfBusinessAttributeItem>();

            if (categorySelections.Any())
            {
                var categoryIds = categorySelections.Select(c => c.CategoryId).Distinct().ToList();
                genericCategory = await _rubyContext.LineOfBusinessAttributeItems
                    .Include(d => d.BusinessAttributeItemDropdownValues)
                    .Where(d => categoryIds.Contains(d.CategoryId) && d.RequiredAtQuoting == true)
                    .ToListAsync();
            }

            return (categorySelections, genericCategory);
        }

        private void AddWorksheetWithAttributes(ExcelPackage excel, ProductSubjectType productSubjectType, string quotationPreference,
            List<ProductCategorySelection> categorySelections, List<LineOfBusinessAttributeItem> genericCategory, int index)
        {
            //string sheetName = $"QuotationSchedule_{index}";
            string sheetName = "QuotationSchedule";
            var workSheet = excel.Workbook.Worksheets.Add(sheetName);

            int attributeRow = 1;
            int column = 1;
            int fixedColumnWidth = 20;

            if (!quotationPreference.Equals(QuotePreferencesStatus.Simulation.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                workSheet.Cells[attributeRow, column].Value = "CustomerId";
                FormatHeader(workSheet.Cells[attributeRow, column]);
                workSheet.Column(column).Width = fixedColumnWidth;
                column++;
            }

            // Ensure "DropdownValues" sheet exists
            var dropdownSheet = excel.Workbook.Worksheets.FirstOrDefault(ws => ws.Name == "DropdownValues") ?? excel.Workbook.Worksheets.Add("DropdownValues");
            int dropdownSheetRow = dropdownSheet.Dimension?.End.Row + 1 ?? 1;

            // Collect attributes from both ProductSubjectType and genericCategory
            var attributes = new List<ProductSubjectTypeAttribute>();

            if (productSubjectType?.ProductSubjectTypeAttributes != null && productSubjectType.ProductSubjectTypeAttributes.Any())
            {
                attributes.AddRange(productSubjectType.ProductSubjectTypeAttributes);
            }

            if (genericCategory != null && genericCategory.Any())
            {
                attributes.AddRange(genericCategory.Select(gc => new ProductSubjectTypeAttribute
                {
                    Name = gc.Name,
                    AvailableAtQuotation = true,
                    FieldType = gc.DataType,
                    DropdownValues = gc.BusinessAttributeItemDropdownValues?.Select(d => new DropdownValues { Value = d.Value }).ToList()
                }));
            }

            // Remove duplicates based on Name
            attributes = attributes.GroupBy(a => a.Name).Select(g => g.First()).ToList();

            foreach (var attribute in attributes)
            {
                if (attribute.AvailableAtQuotation &&
                    (quotationPreference.Equals(QuotePreferencesStatus.Simulation.ToString(), StringComparison.OrdinalIgnoreCase) ||
                     attribute.Name != "CustomerId"))
                {
                    workSheet.Cells[attributeRow, column].Value = attribute.Name;
                    FormatHeader(workSheet.Cells[attributeRow, column]);
                    workSheet.Column(column).Width = fixedColumnWidth;

                    if (attribute.FieldType.Equals("Dropdown", StringComparison.OrdinalIgnoreCase) &&
                        attribute.DropdownValues != null && attribute.DropdownValues.Any())
                    {
                        var dropdownValues = attribute.DropdownValues.Select(d => d.Value).Distinct().ToList();
                        int startRow = dropdownSheetRow;

                        foreach (var value in dropdownValues)
                        {
                            dropdownSheet.Cells[dropdownSheetRow, column].Value = value;
                            dropdownSheetRow++;
                        }

                        int endRow = dropdownSheetRow - 1;
                        string dropdownRange = $"DropdownValues!${ExcelCellAddress.GetColumnLetter(column)}${startRow}:${ExcelCellAddress.GetColumnLetter(column)}${endRow}";

                        var validation = workSheet.DataValidations.AddListValidation(workSheet.Cells[attributeRow + 1, column, 100, column].Address);
                        validation.Formula.ExcelFormula = dropdownRange;
                        validation.ShowErrorMessage = true;
                        validation.ErrorTitle = "Invalid Selection";
                        validation.Error = $"Please select a value from the dropdown list for {attribute.Name}.";
                    }

                    column++;
                }
            }

            workSheet.View.FreezePanes(2, 1);
        }


        private void FormatHeader(ExcelRange cell)
        {
            cell.Style.Font.Bold = true;
            cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            cell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
        }
        private string SaveExcelAsBase64(ExcelPackage excel, string path)
        {
            var fileInfo = new FileInfo(path);
            excel.SaveAs(fileInfo);

            using (var stream = File.OpenRead(path))
            {
                using var ms = new MemoryStream();
                stream.CopyTo(ms);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
        public async Task<BaseResponse<Dictionary<string, List<Dictionary<string, object>>>>> ExtractExcelDataFromStream(IFormFile file, int ProductId)
        {
            var response = new BaseResponse<Dictionary<string, List<Dictionary<string, object>>>>();

            if (file == null || file.Length == 0)
            {
                response.Success = false;
                response.ResponseMessage = "No File Uploaded";
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            var result = new Dictionary<string, List<Dictionary<string, object>>>();

            var product = await _rubyContext.ProductSubjectTypes.
                FirstOrDefaultAsync(d => d.ProductId == ProductId);
            // Fetch subject types and create a lookup dictionary
            var subjectTypeDictionary = await _rubyContext.ProductSubjectTypeAttributes
                .Distinct().Where(d => d.ProductSubjectTypeId == product.Id)
                .ToDictionaryAsync(d => d.Name, d => d.Id);


            // Set the license context for EPPlus (for non-commercial use)
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Dictionary to store generated GUIDs for each unique row hash
            var rowHashEntityIdMap = new Dictionary<string, Guid>();

            // Use EPPlus to load the Excel file
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);

                using (var excelPackage = new ExcelPackage(stream))
                {
                    // Loop through each worksheet (each sheet represents a SubjectType.Name)
                    foreach (var worksheet in excelPackage.Workbook.Worksheets)
                    {
                        // Store the worksheet name as the key
                        var subjectTypeName = worksheet.Name;

                        // List to hold the data rows for this worksheet
                        var dataRows = new List<Dictionary<string, object>>();

                        // Read the headers from the first row (1-based indexing in Excel)
                        var headers = new List<string>();
                        for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                        {
                            headers.Add(worksheet.Cells[1, col].Text);  // Reading header names
                        }

                        // Read the data for each row (starting from row 2)
                        for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                        {
                            var rowDataList = new List<Dictionary<string, object>>();
                            var rowStringBuilder = new StringBuilder(); // String builder to concatenate row values

                            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                            {
                                var attributeName = headers[col - 1]; // Match the header with the value
                                var attributeValue = worksheet.Cells[row, col].Text;

                                rowStringBuilder.Append(attributeValue ?? string.Empty); // Handle null values

                                // Check if attributeName exists in the dictionary
                                subjectTypeDictionary.TryGetValue(attributeName, out var attributeId);

                                // Structure the data correctly
                                var attributeData = new Dictionary<string, object>
                                {
                                    { "attributeId", attributeId },
                                    { "attributeName", attributeName },
                                    { "attributeValue", attributeValue }
                                };
                                rowDataList.Add(attributeData);
                            }

                            // Generate a hash for the current row
                            var rowHash = ComputeHash(rowStringBuilder.ToString());

                            // Check if this row's hash has already been encountered
                            if (!rowHashEntityIdMap.ContainsKey(rowHash))
                            {
                                // If not, generate a new GUID and store it
                                rowHashEntityIdMap[rowHash] = Guid.NewGuid();
                            }

                            // Add EntityId to the row data
                            var entityData = new Dictionary<string, object>
                        {
                            { "entityId", rowHashEntityIdMap[rowHash] },
                            { "attributes", rowDataList } // Store the attributes as a list
                        };

                            // Add the row data to the list
                            dataRows.Add(entityData);
                        }

                        // Add the key (worksheet name) and the data rows to the result dictionary
                        result[subjectTypeName] = dataRows;
                    }
                }
            }

            // Set success response with the extracted key-value pairs
            response.Success = true;
            response.StatusCode = HttpStatusCode.OK;
            response.Data = result;
            response.ResponseMessage = "Data extracted successfully";
            return response;
        }

        private static string ComputeHash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes); // You can also return a hex string if preferred
            }
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> QuotationSearch()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();

            // Get all QuotationStatus enum values and map them to GenericNameResponse
            var enumValues = ((QuotationStatus[])System.Enum.GetValues(typeof(QuotationStatus)))
                .Select(e => new GenericNameResponse
                {
                    Id = (int)e,
                    Name = e.ToString()
                })
                .ToList();

            response.Data = enumValues;
            response.Success = true;
            response.ResponseMessage = "Quote Status Successfully Retrieved";
            response.StatusCode = HttpStatusCode.OK;

            return response;
        }
        #region
        private static int GetNextQuotationCode(RubyDbContext RubyContext)
        {

            int seqQuence;
            var connection = RubyContext.Database.GetDbConnection();
            connection.Open();
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = TableSequenceQueries.QUOTATION_CODE;
                var obj = cmd.ExecuteScalar();
                seqQuence = Convert.ToInt32(obj);
            }
            connection.Close();
            return seqQuence;

        }
        private string UserClaims()
        {
            // Retrieve UserName from claims
            var userNameClaim = _contextAccessor.HttpContext?.User?.FindFirst("UserName")?.Value;

            // If the claim is not present or the user is not authenticated, return a default value
            return !string.IsNullOrEmpty(userNameClaim) ? userNameClaim : "Anonymous";
        }
        private static int CalculateSLAInMinutes()
        {
            int slaMinutes = 120; // Default SLA value; adjust as needed
            return slaMinutes;
        }
        public static double CalculateSlaPercentage(DateTime createdAt)
        {
            var timeDifference = DateTime.Now - createdAt;

            // Get the total minutes that have passed since CreatedAt
            double elapsedMinutes = timeDifference.TotalMinutes;

            // Calculate the percentage of SLA time used (capping it at 100%)
            double slaPercentage = (elapsedMinutes / CalculateSLAInMinutes()) * 100;

            // Ensure the percentage doesn't exceed 100%
            return Math.Min(slaPercentage, 100);
        }

        private async Task<int> GetNextNegotiationRound(int quotationId)
        {
            var lastRound = await _rubyContext.QuoteNegotiations
                .Where(n => n.QuoteId == quotationId)
                .OrderByDescending(n => n.NegotiationRound)
                .FirstOrDefaultAsync();

            return lastRound != null ? lastRound.NegotiationRound + 1 : 1;
        }

        public async Task<BaseResponse<List<object>>> GetProductSubjectAttributeMappings(int productId)
        {
            var response = new BaseResponse<List<object>>(); // Generic list to handle both mapping types.

            // 🔹 Fetch SubjectType IDs linked to the ProductId
            var subjectTypeIds = await _rubyContext.ProductSubjectTypes
                .Where(st => st.ProductId == productId)
                .Select(st => st.Id)
                .ToListAsync();

            // 🔹 Fetch ProductSubjectAttributes linked to those SubjectTypeIds
            var productSubjectAttributes = await _rubyContext.ProductSubjectTypeAttributes
                .Where(attr => subjectTypeIds.Contains(attr.ProductSubjectTypeId))
                .ToListAsync();

            var attributeDictionary = productSubjectAttributes.ToDictionary(attr => attr.Id, attr => attr.Name);

            // 🔹 Get dropdown mappings for ProductSubjectAttributes
            var parentAttributeIds = productSubjectAttributes.Select(attr => attr.Id).ToList();
            var dropdownMappings = await _rubyContext.ProductSubjectAttributeDropdownMappings
                .Where(mapping => parentAttributeIds.Contains(mapping.ParentAttributeId))
                .ToListAsync();

            // 🔹 Convert ProductSubject mappings to response format
            var productMappedData = dropdownMappings.Select(mapping => new ProductSubjectAttributeDropdownMappingResponse
            {
                ParentAttributeId = mapping.ParentAttributeId,
                ParentAttributeName = attributeDictionary.ContainsKey(mapping.ParentAttributeId) ? attributeDictionary[mapping.ParentAttributeId] : "Unknown",
                ParentValue = mapping.ParentValue,
                ChildAttributeId = mapping.ChildAttributeId,
                ChildAttributeName = attributeDictionary.ContainsKey(mapping.ChildAttributeId) ? attributeDictionary[mapping.ChildAttributeId] : "Unknown",
                ChildValues = mapping.ChildValues.Split(',').Select(value => new ChildValueDto { Value = value }).ToList()
            }).ToList();

            // 🔹 Fetch CategoryIds linked to the Product
            var categoryIds = await _rubyContext.ProductCategorySelections
                .Where(d => d.ProductId == productId)
                .Select(d => d.CategoryId)
                .Distinct()
                .ToListAsync();

            List<LineOfBusinessAttributeDropdownMappingResponse> lineOfBusinessMappings = new List<LineOfBusinessAttributeDropdownMappingResponse>();

            foreach (var categoryId in categoryIds)
            {
                // 🔹 Fetch LineOfBusinessAttributeCategory
                var category = await _rubyContext.LineOfBusinessAttributeCategories
                    .FirstOrDefaultAsync(d => d.Id == categoryId);

                if (category != null)
                {
                    // 🔹 Fetch Attributes for the category
                    var businessAttributes = await _rubyContext.LineOfBusinessAttributeItems
                        .Where(attr => attr.CategoryId == categoryId)
                        .ToListAsync();

                    if (!businessAttributes.Any()) continue;

                    var businessAttributeDict = businessAttributes.ToDictionary(attr => attr.Id, attr => attr.Name);

                    // 🔹 Fetch Dropdown Mappings for the category attributes
                    var parentBusinessAttributeIds = businessAttributes.Select(attr => attr.Id).ToList();
                    var businessDropdownMappings = await _rubyContext.LineOfBusinessAttributeDropdownMappings
                        .Where(mapping => parentBusinessAttributeIds.Contains(mapping.ParentAttributeId))
                        .ToListAsync();

                    if (businessDropdownMappings.Any())
                    {
                        lineOfBusinessMappings.AddRange(businessDropdownMappings.Select(mapping => new LineOfBusinessAttributeDropdownMappingResponse
                        {
                            ParentAttributeId = mapping.ParentAttributeId,
                            ParentAttributeName = businessAttributeDict.ContainsKey(mapping.ParentAttributeId) ? businessAttributeDict[mapping.ParentAttributeId] : "Unknown",
                            ParentValue = mapping.ParentValue,
                            ChildAttributeId = mapping.ChildAttributeId,
                            ChildAttributeName = businessAttributeDict.ContainsKey(mapping.ChildAttributeId) ? businessAttributeDict[mapping.ChildAttributeId] : "Unknown",
                            ChildValues = mapping.ChildValues.Split(',').Select(value => new ChildValueDto { Value = value }).ToList()
                        }));
                    }
                }
            }

            // 🔹 Merge both mappings
            var mergedData = new List<object>();
            mergedData.AddRange(productMappedData);
            mergedData.AddRange(lineOfBusinessMappings);

            if (!mergedData.Any())
            {
                response.Success = false;
                response.ResponseMessage = "No mappings found.";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            response.Success = true;
            response.ResponseMessage = "Mappings fetched successfully.";
            response.StatusCode = HttpStatusCode.OK;
            response.Data = mergedData;

            return response;
        }




        #endregion

    }
}






