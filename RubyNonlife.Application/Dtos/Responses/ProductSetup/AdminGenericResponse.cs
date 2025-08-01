using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public class AdminGenericResponse
    {
        public int Id { get; set; }
        public int LineOfBusinessId { get; set; }
        public string Caption { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
    }
}
