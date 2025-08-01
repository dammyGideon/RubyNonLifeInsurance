using RubyNonlife.Application.Dtos.Responses.Quotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.LineOfBuisnessGenericResponse
{
    public class LineOfBusinessAttributeCategoryResponseDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public List<LineOfBusinessApplicableObjectResponseDto> ApplicableObjects { get; set; }
    }


    public class LineOfBusinessCategoryDetailsResponseDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public List<LineOfBusinessApplicableObjectResponseDto> ApplicableObjects { get; set; }
        public List<LineOfBusinessAttributeItemResponseDto> Attributes { get; set; }
        public List<LineOfBusinessAttributeDropdownMappingResponse> AttributeDropdownMappings { get; set; }
    }

}
