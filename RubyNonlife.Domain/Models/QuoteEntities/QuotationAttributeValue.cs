using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.ProductEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.QuoteEntities
{
    public class QuotationAttributeValue : BaseEntity
    {

        [ForeignKey(nameof(Quotation))]
        public int QuotationId { get; set; }
        public virtual Quotation Quotation { get; set; }

        public string AttributeName { get; set; } = string.Empty;
        public string AttributeValue { get; set; } = string.Empty;

       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public Guid EntityId { get; set; } 


        [ForeignKey(nameof(ProductSubjectTypeAttribute))]
        public int AttributeId { get; set; }
        public virtual ProductSubjectTypeAttribute ProductSubjectTypeAttribute { get; set; } = null!;
      

    }

}
