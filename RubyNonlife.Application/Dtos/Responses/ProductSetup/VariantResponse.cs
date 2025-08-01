using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public record VariantResponse
    {
        public int Id {  get; set; }
        public string Caption { get; set; }
        public string alias { get; set; }
        public string description { get; set; }

    }
}
