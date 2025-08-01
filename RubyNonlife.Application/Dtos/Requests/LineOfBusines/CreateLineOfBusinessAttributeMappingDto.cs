using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.LineOfBusines
{
    public class CreateLineOfBusinessAttributeMappingDto
    {
        public int ParentAttributeId { get; init; }
        public string ParentValue { get; init; }
        public int ChildAttributeId { get; init; }
        public List<string> ChildValues { get; init; }
    }
}
