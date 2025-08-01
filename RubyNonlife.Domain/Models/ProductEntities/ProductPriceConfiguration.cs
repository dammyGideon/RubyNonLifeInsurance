using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductPriceConfiguration : BaseEntity
    {
        public int CategoryId {  get; set; }
        public ProductSubjectCategory ProductSubjectCategory { get; set; }

        [ForeignKey(nameof(ProductSubjectTypeAttribute))]
        public int AttributeId { get; set; }
        public ProductSubjectTypeAttribute ProductSubjectTypeAttribute { get; set; }
        public string AttributeName { get; set; }
        public bool AffectPricing { get; set; }
        public string EffectType { get; set; }
        public decimal AffectRate { get; set; }
        public string Affects {  get; set; }
        public List<int> CoverIds { get; set; } = new();

        public ICollection<ProductApprovingOfficePriceConfiguration> ApprovingOfficePriceConfigurations { get; set; }

    }
}
