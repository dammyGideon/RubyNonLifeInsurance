using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.PolicyEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductGenericLocation : BaseEntity
    {
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Name { get; set; }
        public bool RequiredGenericLocation {  get; set; }
        public bool RequiredSpecificGenericLocation { get; set; }
        public ICollection<ProductGenericLocationField> ProductGenericLocationFields { get; set; }
        public ICollection<PolicyBookingGenericLocation> PolicyBookingGenericLocation { get; set; } = new List<PolicyBookingGenericLocation>();
    }

}
