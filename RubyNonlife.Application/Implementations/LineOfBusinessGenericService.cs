using Azure.Core;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Asn1.Ocsp;
using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Dtos.Requests.LineOfBusines;
using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.LineOfBuisnessGenericResponse;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using RubyNonlife.Application.Dtos.Responses.Quotation;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Application.Validators.LineOfBusinessAttributeValidation;
using RubyNonlife.Domain.Models.GenericEntities;
using RubyNonlife.Domain.Models.ProductEntities;
using RubyNonlife.Infrastructure.Persistence;
using System;
using System.Net;
using System.Text.Json;


namespace RubyNonlife.Application.Implementations
{
    public class LineOfBusinessGenericService : ILineOfBusinessGenericService
    {
        private readonly RubyDbContext _rubyDbContext;
        private readonly AdminUrlConfig _apiSettings;
        private readonly AdminAuthenticationHelper _adminHelper;
        private readonly IAdminServiceIntegration _adminService;
        public LineOfBusinessGenericService(RubyDbContext context, IOptions<ApiSettings> apiSettings, AdminAuthenticationHelper admin, IAdminServiceIntegration adminService)
        {
            _rubyDbContext = context;
            _apiSettings = apiSettings.Value.AdminUrl;
            _adminHelper = admin;
            _adminService = adminService;
        }
        public async Task<BaseResponse<PaginatedLineOfBusinessAttributeCategoryResponse>> GetAllGenericCategory(int businessId, int pageNumber = 1, int pageSize = 10)
        {
            // Query LineOfBusinessAttributeCategories and keep it as IQueryable
            var businessQuery = _rubyDbContext
                                 .LineOfBusinessAttributeCategories
                                 .Include(l => l.LineOfBusinessInsuredObjects)
                                 .Where(d => d.BusinesslineId == businessId);

            // If no categories found, return an error
            if (!await businessQuery.AnyAsync())
            {
                return ResponseFactory.CreateError<PaginatedLineOfBusinessAttributeCategoryResponse>("Category Attribute not found", HttpStatusCode.NotFound);
            }


            var subjectOfInsurancIds = await  _rubyDbContext.LineOfBusinessInsuredObjects
                                        .Where(d => d.CategoryId == businessQuery.FirstOrDefault().Id)
                                        .Select(c => c.ObjectId).Distinct()
                                        .ToListAsync();

            var subjectOfInsurancNameResponse = await _adminService.GetSubjectOfInsuranceNamesById(subjectOfInsurancIds);
            var subjectOfInsurancNames = subjectOfInsurancNameResponse.Data ?? new List<string>();

            var subjectOfInsurancNameDict = subjectOfInsurancIds.Zip(subjectOfInsurancNames, (id, name) => new { id, name })
                                                            .ToDictionary(x => x.id, x => x.name);
            // Apply the pagination logic directly on IQueryable before fetching the data
            var lineOfBusinessList = businessQuery.Select(b => new LineOfBusinessAttributeCategoryResponseDto
            {
                Id = b.Id,
                CategoryName = b.CategoryName,
                Alias = b.Alias,
                Description = b.Description,
                ApplicableObjects = b.LineOfBusinessInsuredObjects.Select(o => new LineOfBusinessApplicableObjectResponseDto
                {
                    ApplicableObjectId = o.ObjectId,
                    ObjecName = subjectOfInsurancNameDict.ContainsKey(o.ObjectId) ? subjectOfInsurancNameDict[o.ObjectId] : "Unknown",
                    CategoryId = o.CategoryId,
                    CategoryName = b.CategoryName
                }).ToList(),
            });

            // Paginate the IQueryable
            var pagedLineOfBusiness = await PagedList<LineOfBusinessAttributeCategoryResponseDto>.ToPagedList(lineOfBusinessList, pageNumber, pageSize);

            // Create the paginated response DTO
            var paginatedAttributesCategory = new PaginatedLineOfBusinessAttributeCategoryResponse
            {
                PageNumber = pagedLineOfBusiness.PageNumber,
                PageSize = pagedLineOfBusiness.PageSize,
                TotalCount = pagedLineOfBusiness.TotalCount,
                TotalPages = pagedLineOfBusiness.TotalPages,
                HasPreviousPage = pagedLineOfBusiness.HasPreviousPage,
                HasNextPage = pagedLineOfBusiness.HasNextPage,
                AttributeCategoryResponse = pagedLineOfBusiness.ToList() 
            };

            return ResponseFactory.GetSuccessResponse<PaginatedLineOfBusinessAttributeCategoryResponse>(paginatedAttributesCategory, "Category retrieved Successfully");
        }

        public async Task<BaseResponse<LineOfBusinessAttributeCategoryResponseDto>> GetSingleGenericCategory(int categoryId)
        {
            var businessQuery = await _rubyDbContext
                        .LineOfBusinessAttributeCategories.
                        Include(d => d.LineOfBusinessInsuredObjects).
                FirstOrDefaultAsync(d => d.Id == categoryId);

            if (businessQuery == null)
                return ResponseFactory.CreateError<LineOfBusinessAttributeCategoryResponseDto>("Category not found", HttpStatusCode.NotFound);


         


            var subjectOfInsuranceIds = businessQuery.LineOfBusinessInsuredObjects
                .Select(o => o.ObjectId)
                .Distinct()
                .ToList();

            var subjectOfInsuranceNameResponse = await _adminService.GetSubjectOfInsuranceNamesById(subjectOfInsuranceIds);
            var subjectOfInsuranceNames = subjectOfInsuranceNameResponse.Data ?? new List<string>();

            var subjectOfInsuranceNameDict = subjectOfInsuranceIds.Zip(subjectOfInsuranceNames, (id, name) => new { id, name })
                .ToDictionary(x => x.id, x => x.name);


            var lineOfBusinessList = new LineOfBusinessAttributeCategoryResponseDto
            {
                Id = businessQuery.Id,
                CategoryName = businessQuery.CategoryName,
                Alias = businessQuery.Alias,
                Description = businessQuery.Description,
                ApplicableObjects = businessQuery.LineOfBusinessInsuredObjects.Select(o => new LineOfBusinessApplicableObjectResponseDto
                {
                    ApplicableObjectId = o.ObjectId,
                    ObjecName = subjectOfInsuranceNameDict.ContainsKey(o.ObjectId) ? subjectOfInsuranceNameDict[o.ObjectId] : "Unknown",
                    CategoryId = o.CategoryId,
                    CategoryName = businessQuery.CategoryName
                }).ToList(),
            };

            return ResponseFactory.CreateSuccess<LineOfBusinessAttributeCategoryResponseDto>(lineOfBusinessList, "Category retrieved Successfully");
        }

        public async Task<BaseResponse<GenericNameResponse>> CreateGenericCategory(CreateLineOfBusinessAttributeCategoryDto request)
        {
            // Initialize the validator
            var validator = new CreateLineOfBusinessAttributeCategoryDtoValidator();
            var validationResult = await validator.ValidateAsync(request);

            // Check if validation failed
            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return ResponseFactory.CreateError<GenericNameResponse>(
                    string.Join(", ", errorMessages),
                    HttpStatusCode.BadRequest
                );
            }

            var checkifCategoryExist = await _rubyDbContext.LineOfBusinessAttributeCategories.FirstOrDefaultAsync(d => d.CategoryName == request.Name);
            if (checkifCategoryExist != null) 
                return ResponseFactory.CreateError<GenericNameResponse>("Category Name exist",HttpStatusCode.BadRequest);

            using var transaction = await _rubyDbContext.Database.BeginTransactionAsync();


            LineOfBusinessAttributeCategory attributeCategory = new()
            {
                BusinesslineId = request.BusinessLineId,
                CategoryName = request.Name,
                Description = request.Description,
                Alias = request.Alias,
            };

            _rubyDbContext.LineOfBusinessAttributeCategories.Add(attributeCategory);
            await _rubyDbContext.SaveChangesAsync();


            var insuredObjects = request.ApplicableObjects.Select(obj => new LineOfBusinessInsuredObject()
            {
                CategoryId = attributeCategory.Id,
                ObjectId = obj.ApplicableObjectId
            }).ToList();

            _rubyDbContext.LineOfBusinessInsuredObjects.AddRange(insuredObjects);
            await _rubyDbContext.SaveChangesAsync();


            await transaction.CommitAsync();

            // Return success response
            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>(
                "Generic Attribute Created Successfully",
                HttpStatusCode.Created
            );
        }
      
        public async Task<BaseResponse<GenericNameResponse>> DeleteGenericCategoryAsync(int id)
        {
            var category = await _rubyDbContext.LineOfBusinessAttributeCategories
                .Include(c => c.LineOfBusinessInsuredObjects)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>(
                    "Category not found",
                    HttpStatusCode.NotFound
                );
            }

            using var transaction = await _rubyDbContext.Database.BeginTransactionAsync();
            try
            {
                // Delete related insured objects
                _rubyDbContext.LineOfBusinessInsuredObjects.RemoveRange(category.LineOfBusinessInsuredObjects);

                // Delete related attributes
                var categoryAttributes = await _rubyDbContext.LineOfBusinessAttributeItems
                    .Where(a => a.CategoryId == id)
                    .ToListAsync();
                _rubyDbContext.LineOfBusinessAttributeItems.RemoveRange(categoryAttributes);

                // Delete the category
                _rubyDbContext.LineOfBusinessAttributeCategories.Remove(category);

                await _rubyDbContext.SaveChangesAsync();
                await transaction.CommitAsync();

                return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>(
                    "Generic Attribute Deleted Successfully",
                    HttpStatusCode.OK
                );
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return ResponseFactory.CreateError<GenericNameResponse>(
                    $"Error deleting category: {ex.Message}",
                    HttpStatusCode.InternalServerError
                );
            }
        }


        public async Task<BaseResponse<GenericNameResponse>> UpdateGenericCategory(int id, UpdateLineOfBusinessAttributeCategoryDto request)
        {

            using var transaction = await _rubyDbContext.Database.BeginTransactionAsync();

            // Retrieve the existing category from the database
            var existingCategory = await _rubyDbContext.LineOfBusinessAttributeCategories
                .Include(l => l.LineOfBusinessInsuredObjects) 
                .FirstOrDefaultAsync(l => l.Id == id);

            if (existingCategory == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>(
                    "Category not found.",
                    HttpStatusCode.NotFound
                );
            }

            // Update the fields of the existing entity
            existingCategory.CategoryName = request.Name;
            existingCategory.Description = request.Description;
            existingCategory.Alias = request.Alias;

            // Update the associated insured objects if applicable
            if (request.ApplicableObjects != null && request.ApplicableObjects.Any())
            {
                // Remove the existing objects that need to be updated
                var existingObjects = existingCategory.LineOfBusinessInsuredObjects.ToList();
                _rubyDbContext.LineOfBusinessInsuredObjects.RemoveRange(existingObjects);

                // Add the updated set of applicable objects
                var insuredObjects = request.ApplicableObjects.Select(obj => new LineOfBusinessInsuredObject
                {
                    CategoryId = existingCategory.Id,
                    ObjectId = obj.ApplicableObjectId
                }).ToList();

                _rubyDbContext.LineOfBusinessInsuredObjects.AddRange(insuredObjects);
            }

            // Save changes to the database
            await _rubyDbContext.SaveChangesAsync();

            // Commit the transaction
            await transaction.CommitAsync();

            // Return success response
            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>(
                "Generic Attribute Updated Successfully",
                HttpStatusCode.OK
            );
        }
        public async Task<BaseResponse<GenericNameResponse>> CreateAttributeForGenericCategory(List<CreateLineOfBusinessAttributeItemDto> request)
        {
            foreach (var attribute in request)
            {

                var existingItem = await _rubyDbContext.LineOfBusinessAttributeItems
                        .FirstOrDefaultAsync(item => item.Name == attribute.Name && item.CategoryId == attribute.CategoryId);
                if (existingItem != null)
                {
                    return ResponseFactory.CreateError<GenericNameResponse>($"An item with the name '{attribute.Name}' already exists for this category.", HttpStatusCode.BadRequest);
                }
            }

            // Validation checks for name and field type
            foreach (var attribute in request)
            {
                if (string.IsNullOrEmpty(attribute.Name))
                    return ResponseFactory.CreateError<GenericNameResponse>("Attribute Name is required", HttpStatusCode.BadRequest);

                if (string.IsNullOrEmpty(attribute.FieldType))
                    return ResponseFactory.CreateError<GenericNameResponse>("Data type is required", HttpStatusCode.BadRequest);
            }
            var businessItems = request.Select(attribute => new LineOfBusinessAttributeItem()
            {
                Name = attribute.Name,
                DataType = attribute.FieldType,
                IsSumAssured = attribute.IsSumAssured,
                RequiredAtQuoting = attribute.RequiredAtQuoting,
                ViolationSpecification = attribute.ViolationSpecification,
                CategoryId = attribute.CategoryId,
                BusinessAttributeItemDropdownValues = attribute.BusinessAttributeDropdownValues?.Select(dv => new BusinessAttributeItemDropdownValues
                {
                    Value = dv.Value
                }).ToList(),
            }).ToList();

      
            _rubyDbContext.LineOfBusinessAttributeItems.AddRange(businessItems);
            await _rubyDbContext.SaveChangesAsync();

            // Return success response
            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Attributes created successfully.", HttpStatusCode.Created);
        }

        public async Task<BaseResponse<GenericNameResponse>> DeleteAttributeForGenericCategoryAsync(int id)
        {
            var attributeItem = await _rubyDbContext.LineOfBusinessAttributeItems
                .Include(a => a.LineOfBusinessAttributeDropdownMapping)  
                .FirstOrDefaultAsync(a => a.Id == id);

            if (attributeItem == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>(
                    "Attribute not found",
                    HttpStatusCode.NotFound
                );
            }

            using var transaction = await _rubyDbContext.Database.BeginTransactionAsync();
            try
            {
                // Remove dropdown mappings
                _rubyDbContext.LineOfBusinessAttributeDropdownMappings.RemoveRange(attributeItem.LineOfBusinessAttributeDropdownMapping);

                // Remove the attribute itself
                _rubyDbContext.LineOfBusinessAttributeItems.Remove(attributeItem);

                await _rubyDbContext.SaveChangesAsync();
                await transaction.CommitAsync();

                return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>(
                    "Attribute deleted successfully",
                    HttpStatusCode.OK
                );
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return ResponseFactory.CreateError<GenericNameResponse>(
                    $"Error deleting attribute: {ex.Message}",
                    HttpStatusCode.InternalServerError
                );
            }
        }

        public async Task<BaseResponse<GenericNameResponse>> AddToExistingGenericAttribute(List<CreateLineOfBusinessAttributeItemDto> request,int categoryId)
        {
            var checkCategoryId = await _rubyDbContext.LineOfBusinessAttributeItems.FirstOrDefaultAsync(s => s.CategoryId == categoryId);
            if (checkCategoryId == null)
                return ResponseFactory.CreateError<GenericNameResponse>("Category does not exist", HttpStatusCode.NotFound);

            foreach (var attribute in request)
            {

                var existingItem = await _rubyDbContext.LineOfBusinessAttributeItems
                        .FirstOrDefaultAsync(item => item.Name == attribute.Name && item.CategoryId == attribute.CategoryId);
                if (existingItem != null)
                {
                    return ResponseFactory.CreateError<GenericNameResponse>($"An item with the name '{attribute.Name}' already exists for this category.", HttpStatusCode.BadRequest);
                }
            }

            // Validation checks for name and field type
            foreach (var attribute in request)
            {
                if (string.IsNullOrEmpty(attribute.Name))
                    return ResponseFactory.CreateError<GenericNameResponse>("Attribute Name is required", HttpStatusCode.BadRequest);

                if (string.IsNullOrEmpty(attribute.FieldType))
                    return ResponseFactory.CreateError<GenericNameResponse>("Data type is required", HttpStatusCode.BadRequest);
            }


            var businessItems = request.Select(attribute => new LineOfBusinessAttributeItem()
            {
                Name = attribute.Name,
                DataType = attribute.FieldType,
                IsSumAssured = attribute.IsSumAssured,
                RequiredAtQuoting = attribute.RequiredAtQuoting,
                ViolationSpecification = attribute.ViolationSpecification,
                CategoryId = attribute.CategoryId,
                IsNew = true,
                BusinessAttributeItemDropdownValues = attribute.BusinessAttributeDropdownValues?.Select(dv => new BusinessAttributeItemDropdownValues
                {
                    Value = dv.Value
                }).ToList(),
            }).ToList();


            _rubyDbContext.LineOfBusinessAttributeItems.AddRange(businessItems);
            await _rubyDbContext.SaveChangesAsync();

            // Return success response
            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Attributes created successfully.", HttpStatusCode.Created);
        }

        public async Task<BaseResponse<PaginatedLineOfBusinessAttributeItemResponseDto>> GetAttributesForGenericCategory(int categoryId, string? name = null, int pageNumber = 1, int pageSize = 10)
        {
            var threeDaysAgo = DateTime.UtcNow.AddDays(-3);

            var query = _rubyDbContext.LineOfBusinessAttributeItems
                          .Include(d => d.LineOfBusinessAttributeCategory)
                          .Where(d => d.CategoryId == categoryId)
                          .AsNoTracking();

            // Apply name filtering if provided
            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(d => d.Name.Contains(name));
            }

            // Apply ordering
            query = query.OrderByDescending(p => p.DateCreated);

            // Get total count before pagination
            var totalCount = await query.CountAsync();

            // Apply pagination
            var pagedQuery = await query.Skip((pageNumber - 1) * pageSize)
                                        .Take(pageSize)
                                        .ToListAsync();

            // Check for empty results
            if (!pagedQuery.Any())
            {
                return ResponseFactory.CreateError<PaginatedLineOfBusinessAttributeItemResponseDto>(
                       "No matching attributes found.", HttpStatusCode.NotFound);
            }


            var recordsToUpdate = await _rubyDbContext.LineOfBusinessAttributeItems
                           .Where(d => d.CategoryId == categoryId && d.IsNew && d.DateCreated <= threeDaysAgo)
                           .ToListAsync();

            if (recordsToUpdate.Any())
            {
                foreach (var record in recordsToUpdate)
                {
                    record.IsNew = false;
                }

                await _rubyDbContext.SaveChangesAsync();
            }

            // Map results to DTOs
            var lineOfBusiness = pagedQuery.Select(q => new LineOfBusinessAttributeItemResponseDto
            {
                Id = q.Id,
                Name = q.Name,
                FieldType = q.DataType,
                IsSumAssured = q.IsSumAssured,
                RequiredAtQuoting = q.RequiredAtQuoting,
                ViolationSpecification = q.ViolationSpecification,
                CategoryId = categoryId,
                CategoryName = q.LineOfBusinessAttributeCategory.CategoryName,
                IsNew = q.IsNew,
                IsEditable =q.IsEditable,
                BusinessAttributeDropdownValues = q.BusinessAttributeItemDropdownValues?.Select(d => new BusinessAttributeDropdownValueDto
                {
                    Value = d.Value
                }).ToList()
            }).ToList();

            var paginatedAttributeItems = new PaginatedLineOfBusinessAttributeItemResponseDto
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize),
                HasPreviousPage = pageNumber > 1,
                HasNextPage = (pageNumber * pageSize) < totalCount,
                LineOfBusinessAttributeItemResponseDto = lineOfBusiness
            };

            // Return the mapped response
            return ResponseFactory.GetSuccessResponse(paginatedAttributeItems, "Attributes retrieved successfully.");
        }

        public async Task<BaseResponse<LineOfBusinessAttributeItemResponseDto>>GetSingleAttribute(int attributeId)
        {
            var attributeCheck = await _rubyDbContext.LineOfBusinessAttributeItems
                                        .Include(d=>d.LineOfBusinessAttributeCategory)
                .FirstOrDefaultAsync(q => q.Id == attributeId);
            if (attributeCheck == null)
                return ResponseFactory.CreateError<LineOfBusinessAttributeItemResponseDto>("Attribute not found",HttpStatusCode.NotFound);

            var attributeItem = new LineOfBusinessAttributeItemResponseDto
            {

                Id = attributeId,
                Name = attributeCheck.Name,
                FieldType = attributeCheck.DataType,
                IsSumAssured = attributeCheck.IsSumAssured,
                RequiredAtQuoting = attributeCheck.RequiredAtQuoting,
                ViolationSpecification = attributeCheck.ViolationSpecification,
                CategoryId = attributeCheck.CategoryId,
                CategoryName = attributeCheck.LineOfBusinessAttributeCategory.CategoryName,
                IsNew = attributeCheck.IsNew,
                IsEditable = attributeCheck.IsEditable,
                BusinessAttributeDropdownValues = attributeCheck.BusinessAttributeItemDropdownValues?.Select(d => new BusinessAttributeDropdownValueDto
                {
                    Value = d.Value
                }).ToList()

            };
            return ResponseFactory.CreateSuccess<LineOfBusinessAttributeItemResponseDto>(attributeItem, "Attributes retrieved successfully");
        }
        public async Task<BaseResponse<GenericNameResponse>> UpdateAttributeForGenericCategory(UpdateLineOfBusinessAttributeItemDto request)
        {
            
            var existingItem = await _rubyDbContext.LineOfBusinessAttributeItems
                .FirstOrDefaultAsync(item => item.Id == request.Id && item.CategoryId == request.CategoryId);

           
            if (existingItem == null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>($"Attribute with ID '{request.Id}' not found in this category.", HttpStatusCode.NotFound);
            }
            var duplicateItem = await _rubyDbContext.LineOfBusinessAttributeItems
                .FirstOrDefaultAsync(item => item.Name == request.Name && item.CategoryId == request.CategoryId && item.Id != request.Id);
            if (duplicateItem != null)
            {
                return ResponseFactory.CreateError<GenericNameResponse>($"An item with the name '{request.Name}' already exists in this category.", HttpStatusCode.BadRequest);
            }

            
            existingItem.Name = request.Name;
            existingItem.DataType = request.FieldType;
            existingItem.IsSumAssured = request.IsSumAssured;
            existingItem.RequiredAtQuoting = request.RequiredAtQuoting;
            existingItem.ViolationSpecification = request.ViolationSpecification;

            
            existingItem.BusinessAttributeItemDropdownValues = request.BusinessAttributeDropdownValues?
                .Select(dv => new BusinessAttributeItemDropdownValues
                {
                    Value = dv.Value
                }).ToList();

            
            await _rubyDbContext.SaveChangesAsync();
            return ResponseFactory.CreateSuccessWithOutData<GenericNameResponse>("Attribute updated successfully.", HttpStatusCode.OK);
        }

        public async Task<BaseResponse<List<LineOfBusinessAttributeDropdownMapping>>> CreateLineOfBusinessAttributeMapping(
            List<CreateLineOfBusinessAttributeMappingDto> dropdownMappingRequests)
        {
            var response = new BaseResponse<List<LineOfBusinessAttributeDropdownMapping>>();
            var dropdownMappings = new List<LineOfBusinessAttributeDropdownMapping>();

            // Collect all attribute IDs needed
            var parentAttributeIds = dropdownMappingRequests.Select(r => r.ParentAttributeId).Distinct().ToList();
            var childAttributeIds = dropdownMappingRequests.Select(r => r.ChildAttributeId).Distinct().ToList();

            // Fetch all necessary attributes in one query (including ProductId)
            var parentAttributes = await _rubyDbContext.LineOfBusinessAttributeItems
                .Where(attr => parentAttributeIds.Contains(attr.Id))
                .Include(attr => attr.LineOfBusinessAttributeCategory)
                .ToDictionaryAsync(attr => attr.Id);

            var childAttributes = await _rubyDbContext.LineOfBusinessAttributeItems
                .Where(attr => childAttributeIds.Contains(attr.Id))
                .Include(attr => attr.LineOfBusinessAttributeCategory)
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
                dropdownMappings.Add(new LineOfBusinessAttributeDropdownMapping
                {
                    CategoryId = parentAttribute.CategoryId,
                    ParentAttributeId = parentAttribute.Id,
                    ParentValue = dropdownMappingRequest.ParentValue,
                    ChildAttributeId = childAttribute.Id,
                    ChildValues = string.Join(",", dropdownMappingRequest.ChildValues),
                    DateCreated = DateTime.UtcNow
                });
            }

            if (dropdownMappings.Any())
            {
                await _rubyDbContext.LineOfBusinessAttributeDropdownMappings.AddRangeAsync(dropdownMappings);
                await _rubyDbContext.SaveChangesAsync();
            }

            response.Success = true;
            response.ResponseMessage = "Subject Mapped Successfully.";
            response.StatusCode = HttpStatusCode.Created;
            return response;
        }
        public async Task<BaseResponse<List<LineOfBusinessAttributeDropdownMappingResponse>>> GetLineOfBusinessAttributeMappings(int categoryId)
        {
          
            var category = await _rubyDbContext.LineOfBusinessAttributeCategories
                .FirstOrDefaultAsync(d => d.Id == categoryId);
               

            if (category == null)
            {
                return ResponseFactory.CreateError<List<LineOfBusinessAttributeDropdownMappingResponse>>($"No Category found", HttpStatusCode.NotFound);
            }

            // Get all ProductSubjectAttributes linked to the SubjectTypeIds
            var productSubjectAttributes = await _rubyDbContext.LineOfBusinessAttributeItems
                .Where(attr => attr.CategoryId == categoryId)
                .ToListAsync();

            if (!productSubjectAttributes.Any())
            {
                return ResponseFactory.CreateError<List<LineOfBusinessAttributeDropdownMappingResponse>>($"No Item found for this CategoryId {categoryId}.",HttpStatusCode.NotFound);
            }

            // Create a dictionary for attribute lookup
            var attributeDictionary = productSubjectAttributes.ToDictionary(attr => attr.Id, attr => attr.Name);

            // Get ParentAttributeIds related to ProductSubjectAttributes
            var parentAttributeIds = productSubjectAttributes.Select(attr => attr.Id).ToList();

            // Get all dropdown mappings related to those ParentAttributeIds
            var dropdownMappings = await _rubyDbContext.LineOfBusinessAttributeDropdownMappings
                .Where(mapping => parentAttributeIds.Contains(mapping.ParentAttributeId))
                .ToListAsync();

            if (!dropdownMappings.Any())
            {
                return ResponseFactory.CreateError<List<LineOfBusinessAttributeDropdownMappingResponse>>($"No mappings found for the given CategoryId {categoryId}.", HttpStatusCode.NotFound);
              
            }

            // Create a list of mappings in the required structure
            var mappedData = dropdownMappings.Select(mapping => new LineOfBusinessAttributeDropdownMappingResponse
            {
                ParentAttributeId = mapping.ParentAttributeId,
                ParentAttributeName = attributeDictionary.ContainsKey(mapping.ParentAttributeId) ? attributeDictionary[mapping.ParentAttributeId] : "Unknown",
                ParentValue = mapping.ParentValue,
                ChildAttributeId = mapping.ChildAttributeId,
                ChildAttributeName = attributeDictionary.ContainsKey(mapping.ChildAttributeId) ? attributeDictionary[mapping.ChildAttributeId] : "Unknown",
                ChildValues = mapping.ChildValues.Split(',').Select(value => new ChildValueDto { Value = value }).ToList()
            }).ToList();


            return ResponseFactory.CreateSuccess<List<LineOfBusinessAttributeDropdownMappingResponse>>(mappedData, "Mappings fetched successfully.");
        }

        public async Task<BaseResponse<LineOfBusinessCategoryDetailsResponseDto>> GetByCategoryId(int categoryId)
        {
            // Fetch category with insured objects
            var category = await _rubyDbContext.LineOfBusinessAttributeCategories
                .Include(c => c.LineOfBusinessInsuredObjects)
                .FirstOrDefaultAsync(c => c.Id == categoryId);

            if (category == null)
            {
                return ResponseFactory.CreateError<LineOfBusinessCategoryDetailsResponseDto>("Category not found", HttpStatusCode.NotFound);
            }

            // Fetch all attribute items linked to the category
            var attributes = await _rubyDbContext.LineOfBusinessAttributeItems
                .Include(a => a.LineOfBusinessAttributeCategory)
                .Include(a => a.BusinessAttributeItemDropdownValues)
                .Where(a => a.CategoryId == categoryId)
                .ToListAsync();

            // Create dictionary for attribute lookup
            var attributeDictionary = attributes.ToDictionary(a => a.Id, a => a.Name);

            // Extract attribute IDs into a list (Fix for ContainsKey issue)
            var attributeIds = attributes.Select(a => a.Id).ToList();

            // Fetch dropdown mappings for attributes in this category
            var dropdownMappings = await _rubyDbContext.LineOfBusinessAttributeDropdownMappings
                .Where(m => attributeIds.Contains(m.ParentAttributeId)) // Fixed query
                .ToListAsync();

            // Get subject of insurance names
            var subjectOfInsuranceIds = category.LineOfBusinessInsuredObjects
                .Select(o => o.ObjectId)
                .Distinct()
                .ToList();

            var subjectOfInsuranceNameResponse = await _adminService.GetSubjectOfInsuranceNamesById(subjectOfInsuranceIds);
            var subjectOfInsuranceNames = subjectOfInsuranceNameResponse.Data ?? new List<string>();

            var subjectOfInsuranceNameDict = subjectOfInsuranceIds.Zip(subjectOfInsuranceNames, (id, name) => new { id, name })
                .ToDictionary(x => x.id, x => x.name);

            // Map category details
            var categoryDetails = new LineOfBusinessCategoryDetailsResponseDto
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                Alias = category.Alias,
                Description = category.Description,
                ApplicableObjects = category.LineOfBusinessInsuredObjects.Select(o => new LineOfBusinessApplicableObjectResponseDto
                {
                    ApplicableObjectId = o.ObjectId,
                    ObjecName = subjectOfInsuranceNameDict.GetValueOrDefault(o.ObjectId, "Unknown"),
                    CategoryId = o.CategoryId,
                    CategoryName = category.CategoryName
                }).ToList(),
                Attributes = attributes.Select(a => new LineOfBusinessAttributeItemResponseDto
                {
                    Id = a.Id,
                    Name = a.Name,
                    FieldType = a.DataType,
                    IsSumAssured = a.IsSumAssured,
                    RequiredAtQuoting = a.RequiredAtQuoting,
                    ViolationSpecification = a.ViolationSpecification,
                    CategoryId = a.CategoryId,
                    CategoryName = a.LineOfBusinessAttributeCategory.CategoryName,
                    IsNew = a.IsNew,
                    IsEditable = a.IsEditable,
                    BusinessAttributeDropdownValues = a.BusinessAttributeItemDropdownValues?.Select(d => new BusinessAttributeDropdownValueDto
                    {
                        Value = d.Value
                    }).ToList()
                }).ToList(),
                AttributeDropdownMappings = dropdownMappings.Select(m => new LineOfBusinessAttributeDropdownMappingResponse
                {
                    ParentAttributeId = m.ParentAttributeId,
                    ParentAttributeName = attributeDictionary.GetValueOrDefault(m.ParentAttributeId, "Unknown"),
                    ParentValue = m.ParentValue,
                    ChildAttributeId = m.ChildAttributeId,
                    ChildAttributeName = attributeDictionary.GetValueOrDefault(m.ChildAttributeId, "Unknown"),
                    ChildValues = m.ChildValues.Split(',').Select(v => new ChildValueDto { Value = v }).ToList()
                }).ToList()
            };

            return ResponseFactory.CreateSuccess(categoryDetails, "Category details retrieved successfully");
        }

        public async Task<BaseResponse<List<LineOfBusinessCategoryDetailsResponseDto>>> GetAllCategoryAttributesMapping(int lineOfBusinessId)
        {
            // Fetch all categories with insured objects
            var categories = await _rubyDbContext.LineOfBusinessAttributeCategories
                .Include(c => c.LineOfBusinessInsuredObjects)
                .Where(c=>c.BusinesslineId ==  lineOfBusinessId)
                .ToListAsync();

            if (!categories.Any())
            {
                return ResponseFactory.CreateError<List<LineOfBusinessCategoryDetailsResponseDto>>("No categories found", HttpStatusCode.NotFound);
            }

            // Fetch all attribute items linked to the categories
            var attributes = await _rubyDbContext.LineOfBusinessAttributeItems
                .Include(a => a.LineOfBusinessAttributeCategory)
                .Include(a => a.BusinessAttributeItemDropdownValues)
                .ToListAsync();

            // Create dictionary for attribute lookup
            var attributeDictionary = attributes.ToDictionary(a => a.Id, a => a.Name);

            // Extract attribute IDs into a list (Fix for ContainsKey issue)
            var attributeIds = attributes.Select(a => a.Id).ToList();

            // Fetch all dropdown mappings for the attributes
            var dropdownMappings = await _rubyDbContext.LineOfBusinessAttributeDropdownMappings
                .Where(m => attributeIds.Contains(m.ParentAttributeId)) // Fixed query
                .ToListAsync();

            // Get all subject of insurance names
            var subjectOfInsuranceIds = categories
                .SelectMany(c => c.LineOfBusinessInsuredObjects)
                .Select(o => o.ObjectId)
                .Distinct()
                .ToList();

           


            var subjectOfInsurancNameResponse = await _adminService.GetSubjectOfInsuranceNamesById(subjectOfInsuranceIds);
            var subjectOfInsurancNames = subjectOfInsurancNameResponse.Data ?? new List<string>();

            var subjectOfInsurancNameDict = subjectOfInsuranceIds.Zip(subjectOfInsurancNames, (id, name) => new { id, name })
                                                            .ToDictionary(x => x.id, x => x.name);

            // Map all category details
            var categoryDetailsList = categories.Select(category => new LineOfBusinessCategoryDetailsResponseDto
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                Alias = category.Alias,
                Description = category.Description,
                ApplicableObjects = category.LineOfBusinessInsuredObjects.Select(o => new LineOfBusinessApplicableObjectResponseDto
                {
                    ApplicableObjectId = o.ObjectId,
                    ObjecName = subjectOfInsurancNameDict.ContainsKey(o.ObjectId) ? subjectOfInsurancNameDict[o.ObjectId] : "Unknown",
                    CategoryId = o.CategoryId,
                    CategoryName = category.CategoryName
                }).ToList(),
                Attributes = attributes.Where(a => a.CategoryId == category.Id).Select(a => new LineOfBusinessAttributeItemResponseDto
                {
                    Id = a.Id,
                    Name = a.Name,
                    FieldType = a.DataType,
                    IsSumAssured = a.IsSumAssured,
                    RequiredAtQuoting = a.RequiredAtQuoting,
                    ViolationSpecification = a.ViolationSpecification,
                    CategoryId = a.CategoryId,
                    CategoryName = a.LineOfBusinessAttributeCategory.CategoryName,
                    IsNew = a.IsNew,
                    IsEditable = a.IsEditable,
                    BusinessAttributeDropdownValues = a.BusinessAttributeItemDropdownValues?.Select(d => new BusinessAttributeDropdownValueDto
                    {
                        Value = d.Value
                    }).ToList()
                }).ToList(),
                AttributeDropdownMappings = dropdownMappings
                    .Where(m => attributeDictionary.ContainsKey(m.ParentAttributeId))
                    .Select(m => new LineOfBusinessAttributeDropdownMappingResponse
                    {
                        ParentAttributeId = m.ParentAttributeId,
                        ParentAttributeName = attributeDictionary.GetValueOrDefault(m.ParentAttributeId, "Unknown"),
                        ParentValue = m.ParentValue,
                        ChildAttributeId = m.ChildAttributeId,
                        ChildAttributeName = attributeDictionary.GetValueOrDefault(m.ChildAttributeId, "Unknown"),
                        ChildValues = m.ChildValues.Split(',').Select(v => new ChildValueDto { Value = v }).ToList()
                    }).ToList()
            }).ToList();

            return ResponseFactory.CreateSuccess(categoryDetailsList, "All category details retrieved successfully");
        }


    }
}




