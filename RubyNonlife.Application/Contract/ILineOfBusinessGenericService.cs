
using RubyNonlife.Application.Dtos.Requests.LineOfBusines;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.LineOfBuisnessGenericResponse;
using RubyNonlife.Domain.Models.GenericEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Contract
{
    public interface ILineOfBusinessGenericService
    {
        Task<BaseResponse<PaginatedLineOfBusinessAttributeCategoryResponse>> GetAllGenericCategory(int businessId, int pageNumber = 1, int pageSize = 10);
        Task<BaseResponse<LineOfBusinessAttributeCategoryResponseDto>> GetSingleGenericCategory(int categoryId);
        Task<BaseResponse<GenericNameResponse>> CreateGenericCategory(CreateLineOfBusinessAttributeCategoryDto request);
        Task<BaseResponse<GenericNameResponse>> DeleteGenericCategoryAsync(int id);
        Task<BaseResponse<GenericNameResponse>> UpdateGenericCategory(int id, UpdateLineOfBusinessAttributeCategoryDto request);
        Task<BaseResponse<GenericNameResponse>> CreateAttributeForGenericCategory(List<CreateLineOfBusinessAttributeItemDto> request);
        Task<BaseResponse<GenericNameResponse>> DeleteAttributeForGenericCategoryAsync(int id);

        Task<BaseResponse<LineOfBusinessAttributeItemResponseDto>> GetSingleAttribute(int attributeId);
        Task<BaseResponse<GenericNameResponse>> UpdateAttributeForGenericCategory(UpdateLineOfBusinessAttributeItemDto request);
        Task<BaseResponse<PaginatedLineOfBusinessAttributeItemResponseDto>> GetAttributesForGenericCategory(int categoryId, string? name = null, int pageNumber = 1, int pageSize = 10);
        Task<BaseResponse<List<LineOfBusinessAttributeDropdownMapping>>> CreateLineOfBusinessAttributeMapping(
            List<CreateLineOfBusinessAttributeMappingDto> dropdownMappingRequests);
        Task<BaseResponse<List<LineOfBusinessAttributeDropdownMappingResponse>>> GetLineOfBusinessAttributeMappings(int categoryId);
        Task<BaseResponse<LineOfBusinessCategoryDetailsResponseDto>> GetByCategoryId(int categoryId);
        Task<BaseResponse<List<LineOfBusinessCategoryDetailsResponseDto>>> GetAllCategoryAttributesMapping(int lineOfBusinessId);
    }
}
