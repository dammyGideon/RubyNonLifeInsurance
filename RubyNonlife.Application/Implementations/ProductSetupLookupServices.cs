using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Infrastructure.Contract;
using System.Net;
using static RubyNonlife.Application.Dtos.Responses.SingleProductClassResponse;
using System.Net.Http.Headers;
using System.Text.Json;
using RubyNonlife.Application.Dtos.Responses.Booking;
using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Caching.Memory;
using RubyNonlife.Infrastructure.Persistence;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Application.Helper.UtitlityModel;
using RubyNonlife.Application.Contract;

namespace RubyNonlife.Infrastructure.Implementations
{
    public class ProductSetupLookupServices : IProductServiceLookSetup
    {
        private readonly RubyDbContext _rubyContext;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly AdminUrlConfig _apiSettings;
        private readonly AdminAuthenticationHelper _adminHelper;
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _memoryCache;
        private List<GenericNameResponse> _cachedData;
        private DateTime _cacheExpiry;
        private readonly ConfigModels _configModels;
        private readonly IAdminServiceIntegration _adminService;
        public ProductSetupLookupServices(RubyDbContext rubyContext, IConfiguration configuration,
            IHttpContextAccessor contextAccessor, IOptions<ApiSettings> apiSettings, AdminAuthenticationHelper admin
            , HttpClient httpClient, IMemoryCache memoryCache, IOptions<ConfigModels> configOptions,
            IAdminServiceIntegration adminService
            )
        {
            _rubyContext = rubyContext;
            _configuration = configuration;
            _contextAccessor = contextAccessor;
            _apiSettings = apiSettings.Value.AdminUrl;
            _adminHelper = admin;
            _httpClient = httpClient;
            _memoryCache = memoryCache;
            _configModels = configOptions.Value;
            _adminService = adminService;
        }




        public async Task<BaseResponse<List<ProductClassResponse>>> GetClasses()
        {
            var lineOfBusiness = _apiSettings.LineOfBusinessId;

            var nonLifeProducts = await _adminService.GetProductClass(lineOfBusiness);
            var productResponse = nonLifeProducts.Data.Select(x => new ProductClassResponse()
            {
                Id =x.Id,
                Name = x.Caption,
                ImageUrl = x.Url
            }).ToList();

            return ResponseFactory.CreateSuccess<List<ProductClassResponse>>(productResponse,"Product Class retrieved successfully");
          

        }
        public async Task<BaseResponse<SingleProductClassResponse>> GetSingleClass(int productClassId)
        {
            var lineOfBusiness = _apiSettings.LineOfBusinessId;

            var result = await _adminService.GetProductWithRiders(productClassId, lineOfBusiness);
            var productNameResponse = await _adminService.GetSingleProductClass(productClassId);
            var productClassName = productNameResponse.Success ? productNameResponse.Data : $"Unknown (ID: {productClassId})";

            var safeData = result.Data;

            var baseCover = safeData.Select(c => new NonLifeProductCoverResponse
            {
                CoverId = c.Id,
                CoverName = c.Caption,
            }).ToList();

            var additionalCovers = safeData.Select(c => new NonLifeProductAdditionalCoversResponse
            {
                CoverId = c.Id,
                CoverName = c.Caption,
            }).ToList();

            var response = new SingleProductClassResponse
            {
                ClassId = productClassId,
                ClassName = productClassName,
                BaseCovers = baseCover,
                AdditionalCovers = additionalCovers
            };

            return ResponseFactory.GetSuccessResponse<SingleProductClassResponse>(response, "Product retrieved");
        }


        public async Task<BaseResponse<List<GenericNameResponse>>> GetCoverStatus()
        {

            var response = Enum.GetValues(typeof(CoverStatusType))
                    .Cast<CoverStatusType>()
                    .Select(c => new GenericNameResponse()
                    {
                        Name = c.ToString(),
                    }).ToList();


            return new BaseResponse<List<GenericNameResponse>>()
            {
                Success = true,
                ResponseMessage = "Cover Statuses retrieved successfully",
                Data = response,
                StatusCode = HttpStatusCode.OK,

            };


        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetProductVariant()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var token = await _adminHelper.GetAccessToken();

            try
            {
                var cacheKey = "ProductVariants";  // Unique cache key for the variants
                if (_memoryCache.TryGetValue(cacheKey, out List<GenericNameResponse> cachedData))
                {
                    // If data is found in cache, return it
                    response.Success = true;
                    response.ResponseMessage = "Product variants retrieved from cache.";
                    response.StatusCode = HttpStatusCode.OK;
                    response.Data = cachedData;
                    return response;
                }

                var baseUrl = _apiSettings.BaseUrl;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Use full URL instead of modifying BaseAddress
                var result = await _httpClient.GetFromJsonAsync<SubAdminApiResponse<VariantResponse>>(
                    $"{baseUrl}/ProductVariance/GetAll", jsonOptions);

                if (result == null || result.Payload == null || !result.Payload.Any())
                {
                    response.Success = false;
                    response.ResponseMessage = "No product variants found.";
                    response.StatusCode = HttpStatusCode.NotFound;
                    return response;
                }

                response.Success = true;
                response.ResponseMessage = "Product variants retrieved successfully.";
                response.StatusCode = HttpStatusCode.OK;
                response.Data = result.Payload.Select(p => new GenericNameResponse
                {
                    Id = p.Id,
                    Name = p.Caption
                }).ToList();

                // Cache the result for 10 minutes
                _memoryCache.Set(cacheKey, response.Data, TimeSpan.FromMinutes(10));
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ResponseMessage = $"An error occurred: {ex.Message}";
                response.StatusCode = HttpStatusCode.InternalServerError;
            }

            return response;
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> GetParameter()
        {
            var parameters = await _rubyContext.CalculationsParameters.ToListAsync();
            var response = parameters.Select(d => new GenericNameResponse()
            {
                Id = d.Id,
                Name = d.Name,
            }).ToList();



            return new BaseResponse<List<GenericNameResponse>>()
            {
                Success = true,
                ResponseMessage = "Parameters retrieved successfully",
                Data = response,
                StatusCode = HttpStatusCode.OK,
            };

        }
        public async Task<BaseResponse<List<OperatorResponse>>> GetOperator()
        {
            var response = Enum.GetValues(typeof(CalculationOperator))
                .Cast<CalculationOperator>()
                .Select(x => new OperatorResponse()
                {
                    Sign = ((char)x).ToString()
                }).ToList();

            return new BaseResponse<List<OperatorResponse>>()
            {
                Success = true,
                ResponseMessage = "Operators retrieved successfully",
                Data = response,
                StatusCode = HttpStatusCode.OK,
            };


        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetCostType()
        {
            var cacheKey = "CostTypes";
            if (_memoryCache.TryGetValue(cacheKey, out List<GenericNameResponse> cachedData))
            {
                return ResponseFactory.GetSuccessResponse(cachedData, "Cost Types retrieved from cache");
            }

            var token = await _adminHelper.GetAccessToken();
            try
            {
                var baseUrl = _apiSettings.BaseUrl;
                var lineOfBusinessId = _apiSettings.LineOfBusinessId;

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var result = await _httpClient.GetFromJsonAsync<AdminCentralApiResponse<AdminGenericResponse>>(
                    $"{baseUrl}/CostType/Search?Filters.LineOfBusinessId={lineOfBusinessId}",
                    jsonOptions
                );

                if (result == null || result.Payload == null)
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("No cost type found.", HttpStatusCode.NotFound);
                }

                var data = result.Payload.Select(p => new GenericNameResponse
                {
                    Id = p.Id,
                    Name = p.Caption
                }).ToList();

                // Store data in cache for 10 minutes
                _memoryCache.Set(cacheKey, data, TimeSpan.FromMinutes(10));

                return ResponseFactory.GetSuccessResponse(data, "Cost Types successfully retrieved");
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<FrequencyResponse>>> GetFrequency()
        {
            var cacheKey = "PaymentFrequencies";
            if (_memoryCache.TryGetValue(cacheKey, out List<FrequencyResponse> cachedData))
            {
                return ResponseFactory.GetSuccessResponse(cachedData, "Payment frequencies retrieved from cache");
            }

            var token = await _adminHelper.GetAccessToken();
            try
            {
                var baseUrl = _apiSettings.BaseUrl;
                var lineOfBusiness = _apiSettings.LineOfBusinessId;

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminGenericResponse>>>(
                    $"{baseUrl}/PaymentFrequency/Search?Filters.LineOfBusinessId={lineOfBusiness}",
                    jsonOptions
                );

                if (result == null || result.Payload == null)
                {
                    return ResponseFactory.CreateError<List<FrequencyResponse>>("No data found for the requested frequency.", HttpStatusCode.BadRequest);
                }

                var data = result.Payload.Select(p => new FrequencyResponse
                {
                    Id = p.Id,
                    Name = p.Caption
                }).ToList();

                // Store data in cache for 10 minutes
                _memoryCache.Set(cacheKey, data, TimeSpan.FromMinutes(25));

                return ResponseFactory.GetSuccessResponse(data, "Payment frequencies successfully retrieved");
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<FrequencyResponse>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> GetRating()
        {

            var ratings = await _rubyContext.PriceRatings.ToListAsync();
            var response = ratings.Select(r => new GenericNameResponse()
            {
                Id = r.Id,
                Name = r.Name,
            }).ToList();
            return new BaseResponse<List<GenericNameResponse>>()
            {
                Success = true,
                ResponseMessage = "Ratings retrieved successfully",
                Data = response,
                StatusCode = HttpStatusCode.OK,
            };

        }
        public async Task<BaseResponse<List<CharacterResponse>>> GetCharacterLength()
        {
            var characters = await _rubyContext.DatatypeLengths.ToListAsync();
            var response = characters.Select(c => new CharacterResponse()
            {
                Id = c.Id,
                Name = c.Name,
                value = c.Length
            }).ToList();
            return new BaseResponse<List<CharacterResponse>>()
            {
                Success = true,
                ResponseMessage = "Character length retrieved successfully",
                Data = response,
                StatusCode = HttpStatusCode.OK,
            };
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetCostBearer()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var cacheKey = "CostBearers"; // Unique cache key for cost bearers

            if (_memoryCache.TryGetValue(cacheKey, out List<GenericNameResponse> cachedData))
            {
                response.Success = true;
                response.ResponseMessage = "Cost Bearers retrieved from cache.";
                response.StatusCode = HttpStatusCode.OK;
                response.Data = cachedData;
                return response;
            }

            var token = await _adminHelper.GetAccessToken();

            try
            {
                var baseUrl = _apiSettings.BaseUrl;
                var lineOfBusiness = _apiSettings.LineOfBusinessId;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminGenericResponse>>>(
                    $"{baseUrl}/CostBearer/Search?Filters.LineOfBusinessId={lineOfBusiness}", jsonOptions);

                if (result == null || result.Payload == null)
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("No cost bearers found.", HttpStatusCode.NotFound);
                }

                var data = result.Payload.Select(p => new GenericNameResponse { Id = p.Id, Name = p.Caption }).ToList();

                // Cache the result for 10 minutes
                _memoryCache.Set(cacheKey, data, TimeSpan.FromMinutes(10));

                return ResponseFactory.GetSuccessResponse(data, "Cost Bearers retrieved successfully");
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> GetSubjectType()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var cacheKey = "SubjectTypes"; // Unique cache key for subject types

            if (_memoryCache.TryGetValue(cacheKey, out List<GenericNameResponse> cachedData))
            {
                response.Success = true;
                response.ResponseMessage = "Subject Types retrieved from cache.";
                response.StatusCode = HttpStatusCode.OK;
                response.Data = cachedData;
                return response;
            }

            var token = await _adminHelper.GetAccessToken();

            try
            {
                var baseUrl = _apiSettings.BaseUrl;
                var lineOfBusiness = _apiSettings.LineOfBusinessId;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminGenericResponse>>>(
                    $"{baseUrl}/SubjectOfInsurance/Search?Filters.LineOfBusinessId={lineOfBusiness}", jsonOptions);

                if (result == null || result.Payload == null)
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("No subject types found.", HttpStatusCode.NotFound);
                }

                var data = result.Payload.Select(p => new GenericNameResponse { Id = p.Id, Name = p.Caption }).ToList();

                // Cache the result for 10 minutes
                _memoryCache.Set(cacheKey, data, TimeSpan.FromMinutes(10));

                return ResponseFactory.GetSuccessResponse(data, "Subject Types retrieved successfully");
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> GetPolicyDocumentSetup()
        {

            var cacheKey = "PolicyDocument";
            if (_memoryCache.TryGetValue(cacheKey, out List<GenericNameResponse> cachedData))
            {
                return ResponseFactory.GetSuccessResponse(cachedData, "Policy Document retrieved");
            }


            var token = await _adminHelper.GetAccessToken();

            try
            {
                var baseUrl = _apiSettings.BaseUrl;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                // Fetch fresh data from API
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminGenericResponse>>>(
                    $"{baseUrl}/ProductSetupLookup/get-documents", jsonOptions);

                if (result == null || result.Payload == null)
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("No data found for the requested Documents.", HttpStatusCode.BadRequest);
                }

                var data = result.Payload.Select(p => new GenericNameResponse { Id = p.Id, Name = p.Caption }).ToList();


                // Store data in cache for 10 minutes
                _memoryCache.Set(cacheKey, data, TimeSpan.FromMinutes(25));

                return ResponseFactory.GetSuccessResponse(data, "Document retrieved successfully");
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> GetSourceOfCollection()
        {

            var cacheKey = "SourceOfCollection";

            if (_memoryCache.TryGetValue(cacheKey, out List<GenericNameResponse> cacheData))
            {
                return ResponseFactory.GetSuccessResponse(cacheData, "Collection Source retrieved successfully");
            }


            var token = await _adminHelper.GetAccessToken();

            try
            {
                var baseUrl = _apiSettings.BaseUrl;
                var lineOfBusiness = _apiSettings.LineOfBusinessId;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                // Fetch fresh data from API
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminGenericResponse>>>(
                    $"{baseUrl}/SourceOfCollection/Search?Filters.LineOfBusinessId={lineOfBusiness}", jsonOptions);

                if (result == null || result.Payload == null)
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("No data found for the requested source of collection.", HttpStatusCode.BadRequest);
                }

                var data = result.Payload.Select(p => new GenericNameResponse { Id = p.Id, Name = p.Caption }).ToList();

                _memoryCache.Set(cacheKey, data, TimeSpan.FromMinutes(25));

                return ResponseFactory.GetSuccessResponse(data, "Collection Source retrieved successfully");
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

        public async Task<BaseResponse<List<GenericNameResponse>>> GetDataType()
        {

            var datatype = await _rubyContext.Datatypes.ToListAsync();
            var response = datatype.Select(c => new GenericNameResponse()
            {
                Id = (int)c.Id,
                Name = c.Name,
            }).ToList();

            return new BaseResponse<List<GenericNameResponse>>()
            {
                Success = true,
                ResponseMessage = "Data Type successfully retrieved",
                Data = response,
                StatusCode = HttpStatusCode.OK,
            };
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> DocumentFormat()
        {

            var documentFormat = await _rubyContext.PolicyDocumentFormats.ToListAsync();
            var response = documentFormat.Select(p => new GenericNameResponse()
            {
                Id = p.Id,
                Name = p.Name,
            }).ToList();

            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(response, "Document Format successfully retrieved");


        }
        public async Task<BaseResponse<List<GenericNameResponse>>> DocumentSize()
        {

            var docs = await _rubyContext.PolicyDocumentSizes.ToListAsync();
            var response = docs.Select(c => new GenericNameResponse()
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();

            return new BaseResponse<List<GenericNameResponse>>()
            {
                Success = true,
                ResponseMessage = "Document Type successfully retrieved.",
                Data = response,
                StatusCode = HttpStatusCode.OK,

            };
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetCarMake()
        {
            var responses = new BaseResponse<List<GenericNameResponse>>();

            var getCarMakes = await _rubyContext.CarMakes.ToListAsync();
            var makes = getCarMakes.Select(m => new GenericNameResponse()
            {
                Id = m.Id,
                Name = m.Name,
            }).ToList();

            responses.Success = true;
            responses.ResponseMessage = "car make successfully retrieved.";
            responses.Data = makes;
            responses.StatusCode = HttpStatusCode.OK;
            return responses;
        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetCarModel(int carMake)
        {
            var response = new BaseResponse<List<GenericNameResponse>>();

            var getCarModel = await _rubyContext.CarModels.Where(d => d.CarMakeId == carMake).ToListAsync();
            if (getCarModel == null)
            {
                response.Success = false;
                response.ResponseMessage = $"car make with this id {carMake} does not exist";
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            var carModel = getCarModel.Select(m => new GenericNameResponse()
            {
                Id = m.Id,
                Name = m.Name,
            }).ToList();
            response.Success = true;
            response.ResponseMessage = "car model successfully retrieved.";
            response.Data = carModel;
            response.StatusCode = HttpStatusCode.OK;
            return response;


        }
        public async Task<BaseResponse<List<GenericNameResponse>>> GetFeeType()
        {
            var response = new BaseResponse<List<GenericNameResponse>>();
            var token = await _adminHelper.GetAccessToken();

            try
            {
                var cacheKey = "FeeType";  
                if (_memoryCache.TryGetValue(cacheKey, out List<GenericNameResponse> cachedData))
                {
                    // If data is found in cache, return it
                    response.Success = true;
                    response.ResponseMessage = "Fee Type retrieved from cache.";
                    response.StatusCode = HttpStatusCode.OK;
                    response.Data = cachedData;
                    return response;
                }

                var baseUrl = _apiSettings.BaseUrl;
                var businessId = _apiSettings.LineOfBusinessId;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                // Use full URL instead of modifying BaseAddress
                var result = await _httpClient.GetFromJsonAsync<SubAdminApiResponse<VariantResponse>>(
                    $"{baseUrl}/OtherFee/Search?Filters.LineOfBusinessId={businessId}", jsonOptions);

                if (result == null || result.Payload == null || !result.Payload.Any())
                {
                    response.Success = false;
                    response.ResponseMessage = "Fee Type Not found.";
                    response.StatusCode = HttpStatusCode.NotFound;
                    return response;
                }

                response.Success = true;
                response.ResponseMessage = "Fee Type retrieved successfully.";
                response.StatusCode = HttpStatusCode.OK;
                response.Data = result.Payload.Select(p => new GenericNameResponse
                {
                    Id = p.Id,
                    Name = p.Caption
                }).ToList();

                // Cache the result for 10 minutes
                _memoryCache.Set(cacheKey, response.Data, TimeSpan.FromMinutes(10));
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ResponseMessage = $"An error occurred: {ex.Message}";
                response.StatusCode = HttpStatusCode.InternalServerError;
            }

            return response;
           
        }



    }
}
