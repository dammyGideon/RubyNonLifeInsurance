using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BookingUploadedDocument : BaseEntity
    {
        [ForeignKey(nameof(ProductDocument))]
        public int ProductDocumentId { get; set; } 
        public ProductDocument ProductDocument { get; set; }

        [ForeignKey(nameof(PolicyDocument))]
        public int PolicyDocumentId { get; set; }
        public PolicyBooking PolicyBooking {  get; set; }

        public string DocumentName { get; set; } = string.Empty;
    }
}
