using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;
using RubyNonlife.Domain.Models.QuoteEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class PolicyBookingGenericLocation : BaseEntity
    {
        [ForeignKey(nameof(PolicyBooking))]
        public int PolicyBookingId { get; set; }
        public PolicyBooking PolicyBooking { get; set; }

        public string FieldName { get; set; }  
        public string FieldValue { get; set; }
        public Guid? EntityId { get; set; }

        [ForeignKey(nameof(ProductGenericLocation))]
        public int GenericLocationId { get; set; }
        public virtual ProductGenericLocation ProductGenericLocation { get; set; }

      

    }


}
