using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using RubyNonlife.Domain.Models.ProductEntities;
using RubyNonlife.Infrastructure.Contract;
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Net.Http.Json;
using static RubyNonlife.Application.Dtos.Responses.GenericLocationAttributeResponse;
using RubyNonlife.Infrastructure.Persistence;
using RubyNonlife.Application.Helper.GeneralHelper;

namespace RubyNonlife.Infrastructure.Implementations
{
    public class ProductDocumentService : IProductDocumentService
    {
        private readonly RubyDbContext _rubyDbContext;
        private readonly AdminUrlConfig _apiSettings;
        private readonly AdminAuthenticationHelper _adminHelper;
        private readonly IMemoryCache _memoryCache;
        private readonly HttpClient _httpClient;
        public ProductDocumentService(RubyDbContext rubyDbContext, IOptions<ApiSettings> apiSettings,
            AdminAuthenticationHelper admin, IMemoryCache memoryCache, HttpClient httpClient)
        {
            _rubyDbContext = rubyDbContext;
            _apiSettings = apiSettings.Value.AdminUrl;
            _adminHelper = admin;
            _memoryCache = memoryCache;
            _httpClient = httpClient;


        }





        public async Task<BaseResponse<ProductCategoryDocumentResponse>> CreateCategoryAsync(ProductCategoryDocumentResponseRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Category))
                return ResponseFactory.CreateError<ProductCategoryDocumentResponse>("Invalid request data.", System.Net.HttpStatusCode.BadRequest);

            // ✅ Check for duplicate document names
            var duplicateNames = request.ProductDocuments
                .GroupBy(d => d.Name?.Trim(), StringComparer.OrdinalIgnoreCase)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();

            if (duplicateNames.Any())
            {
                string duplicates = string.Join(", ", duplicateNames);
                return ResponseFactory.CreateError<ProductCategoryDocumentResponse>(
                    $"Duplicate document name(s) not allowed: {duplicates}",
                    System.Net.HttpStatusCode.BadRequest);
            }

            var category = new ProductDocumentCategory
            {
                CategoryName = request.Category,
                SubCategory = request.SubCategory,
                ProductId = request.ProductId,
                ProductDocuments = request.ProductDocuments.Select(doc => new ProductDocument
                {
                    Name = doc.Name?.Trim(),
                    Size = doc.Size,
                    Format = doc.Format?.Trim(),
                    IsRequired = doc.IsRequired
                }).ToList()
            };

            _rubyDbContext.ProductDocumentCategories.Add(category);
            await _rubyDbContext.SaveChangesAsync();

            ProductCategoryDocumentResponse data = new()
            {
                Id = category.Id,
                Category = category.CategoryName,
                SubCategory = category.SubCategory,
                ProductDocuments = category.ProductDocuments.Select(doc => new ProductDocumentResponse
                {
                    Name = doc.Name,
                    Size = doc.Size,
                    Format = doc.Format,
                    IsRequired = doc.IsRequired
                }).ToList()
            };

            return ResponseFactory.CreateSuccessWithOutData<ProductCategoryDocumentResponse>(
                "Document Category Created",
                System.Net.HttpStatusCode.Created);
        }


        public async Task<BaseResponse<List<ProductCategoryDocumentResponse>>> GetCategoryAsync(int productId)
        {
            // Validate productId
            if (productId <= 0)
                return ResponseFactory.CreateError<List<ProductCategoryDocumentResponse>>("Invalid product ID.", System.Net.HttpStatusCode.BadRequest);

            // Fetch categories and associated documents from the database
            var categories = await _rubyDbContext.ProductDocumentCategories
                .Where(c => c.ProductId == productId)
                .Include(c => c.ProductDocuments)  // Including related documents
                .ToListAsync();

            // If no categories found, return an error
            if (categories == null || !categories.Any())
                return ResponseFactory.CreateError<List<ProductCategoryDocumentResponse>>("No categories found for the given product ID.", System.Net.HttpStatusCode.NotFound);

            // Map categories data to response
            var response = categories.Select(category => new ProductCategoryDocumentResponse
            {
                Id = category.Id,
                Category = category.CategoryName,
                SubCategory = category.SubCategory,
                ProductDocuments = category.ProductDocuments.Select(doc => new ProductDocumentResponse
                {
                    Id = doc.Id,
                    Name = doc.Name,
                    Size = doc.Size,
                    Format = doc.Format,
                    IsRequired = doc.IsRequired
                }).ToList()
            }).ToList();

            // Return success response with categories data
            return ResponseFactory.CreateSuccess(response, "Category details retrieved successfully.");
        }

        public async Task<BaseResponse<GenericNameResponse>> DeleteCategoryAsync(int categoryId)
        {
            var category = await _rubyDbContext.ProductDocumentCategories.Include(c => c.ProductDocuments)
                        .FirstOrDefaultAsync(c => c.Id == categoryId);

            if (category == null)
                return ResponseFactory.CreateError<GenericNameResponse>("There is no Category", System.Net.HttpStatusCode.NotFound);

            _rubyDbContext.ProductDocumentCategories.Remove(category);
            await _rubyDbContext.SaveChangesAsync();

            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Category deleted", System.Net.HttpStatusCode.OK);
        }
        public async Task<BaseResponse<GenericNameResponse>> DeleteDocumentAsync(int documentId)
        {
            var document = await _rubyDbContext.ProductDocuments.FindAsync(documentId);
            if (document == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Document not Found", System.Net.HttpStatusCode.NotFound);

            _rubyDbContext.ProductDocuments.Remove(document);
            await _rubyDbContext.SaveChangesAsync();
            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Document Deleted Successfully", System.Net.HttpStatusCode.OK);
        }
        public async Task<BaseResponse<ProductCategoryDocumentResponse>> UpdateCategoryAsync(int categoryId, ProductCategoryDocumentResponse request)
        {
            var category = await _rubyDbContext.ProductDocumentCategories
              .Include(c => c.ProductDocuments)
              .FirstOrDefaultAsync(c => c.Id == categoryId);

            if (category == null)
                throw new KeyNotFoundException("Category not found.");

            category.CategoryName = request.Category ?? category.CategoryName;
            category.SubCategory = request.SubCategory ?? category.SubCategory;
            
            // Remove old documents and add new ones
            category.ProductDocuments.Clear();
            if (request.ProductDocuments != null)
            {
                category.ProductDocuments = request.ProductDocuments.Select(doc => new ProductDocument
                {
                    Name = doc.Name,
                    Size = doc.Size,
                    Format = doc.Format,
                    IsRequired = doc.IsRequired
                }).ToList();
            }

            await _rubyDbContext.SaveChangesAsync();

            ProductCategoryDocumentResponse data = new()
            {
                Id = category.Id,
                Category = category.CategoryName,
                ProductDocuments = category.ProductDocuments.Select(doc => new ProductDocumentResponse
                {
                    Id = doc.Id,
                    Name = doc.Name,
                    Size = doc.Size,
                    Format = doc.Format,
                    IsRequired = doc.IsRequired
                }).ToList()
            };

            return ResponseFactory.CreateSuccess<ProductCategoryDocumentResponse>(data, "Product Updated Successfully");
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
                    $"{baseUrl}/Document/GetAll", jsonOptions);

                if (result == null || result.Payload == null || !result.Payload.Any())
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("No data found for the requested documents.", HttpStatusCode.BadRequest);
                }

                var data = result.Payload.Select(
                    p => new GenericNameResponse { Id = p.Id, Name = p.Alias }).ToList();


                // Store data in cache for 10 minutes
                _memoryCache.Set(cacheKey, data, TimeSpan.FromMinutes(25));

                return ResponseFactory.GetSuccessResponse(data, "Document retrieved successfully");
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
       
        public async Task<BaseResponse<List<GenericNameResponse>>> DocumentFormat()
        {

            var documentFormat = await _rubyDbContext.PolicyDocumentFormats.ToListAsync();
            var response = documentFormat.Select(p => new GenericNameResponse()
            {
                Id = p.Id,
                Name = p.Name,
            }).ToList();

            return ResponseFactory.GetSuccessResponse<List<GenericNameResponse>>(response, "Document Format successfully retrieved");


        }
        public async Task<BaseResponse<List<GenericNameResponse>>> DocumentSize()
        {

            var docs = await _rubyDbContext.PolicyDocumentSizes.ToListAsync();
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
        public async Task<BaseResponse<List<GenericNameResponse>>> EndorsementType()
        {
            
             var cacheKey = "EndorsementType";
            if (_memoryCache.TryGetValue(cacheKey, out List<GenericNameResponse> cachedData))
            {
                return ResponseFactory.GetSuccessResponse(cachedData, "EndorsementType retrieved");
            }


            var token = await _adminHelper.GetAccessToken();

            try
            {
                var baseUrl = _apiSettings.BaseUrl;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                // Fetch fresh data from API
                var result = await _httpClient.GetFromJsonAsync<AdminBaseResponse<List<AdminGenericResponse>>>(
                    $"{baseUrl}/EndorsementType/GetAll", jsonOptions);

                if (result == null || result.Payload == null)
                {
                    return ResponseFactory.CreateError<List<GenericNameResponse>>("No data found for the requested EndorsementType.", HttpStatusCode.BadRequest);
                }

                var data = result.Payload.Select(p => new GenericNameResponse { Id = p.Id, Name = p.Caption }).ToList();


                // Store data in cache for 10 minutes
                _memoryCache.Set(cacheKey, data, TimeSpan.FromMinutes(25));

                return ResponseFactory.GetSuccessResponse(data, "EndorsementType retrieved successfully");
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateError<List<GenericNameResponse>>($"An error occurred: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }

    }
}



