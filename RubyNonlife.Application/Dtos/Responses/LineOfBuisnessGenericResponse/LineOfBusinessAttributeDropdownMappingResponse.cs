using RubyNonlife.Application.Dtos.Requests.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.LineOfBuisnessGenericResponse
{
    public class LineOfBusinessAttributeDropdownMappingResponse
    {
        public int ParentAttributeId { get; set; }
        public string ParentAttributeName { get; set; }
        public string ParentValue { get; set; }
        public int ChildAttributeId { get; set; }
        public string ChildAttributeName { get; set; }
        public List<ChildValueDto> ChildValues { get; set; }
    }


}
