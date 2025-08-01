using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public class ProductSubjectAttributeDropdownMappingResponse
    {
        public int ParentAttributeId { get; set; }
        public string ParentAttributeName { get; set; }
        public string ParentValue { get; set; }
        public int ChildAttributeId { get; set; }
        public string ChildAttributeName { get; set; }
        public List<ChildValueDto> ChildValues { get; set; }
    }

    public class ChildValueDto
    {
        public string Value { get; set; }
    }

}
