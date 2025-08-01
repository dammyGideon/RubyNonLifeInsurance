using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public class ProductRejectionRequest
    {
        public int ProductId { get; set; }
        public string Reason { get; set; }
    }
}
