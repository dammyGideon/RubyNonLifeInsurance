using Microsoft.EntityFrameworkCore;
using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.PolicyEntities;
using RubyNonlife.Domain.Models.QuoteEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductSubjectTypeAttribute : BaseEntity
    {
       
        public string Name { get; set; }
        [ForeignKey(nameof(ProductSubjectCategory))]
        public int ProductSubjectCategoryId { get; set; }
        public ProductSubjectCategory ProductSubjectCategory { get; set; }
        public string FieldType { get; set; }
        public bool IsRequired { get; set; }
        public bool IsSumInsured { get; set; }
        public int DataTypeId { get; set; }
        public int? DataLength { get; set; }

        public string? SpecifyOperator { get; set; }
        public string? ComparativeValueType { get; set; }
        public string? ComparativeValue { get; set; }
        public bool GenericStateLgaStreet { get; set; }=false;
        public bool RequiresUnderwriting { get; set; }
        public bool AvailableAtQuotation { get; set; }
        public bool HasParentChildOptions { get; init; }

        [Column(TypeName ="json")]
        public List<DropdownValues> DropdownValues { get; set; }
        public int ProductSubjectTypeId { get; set; }
        public virtual ProductSubjectType ProductSubjectType { get; set; }

        public virtual ICollection<QuotationAttributeValue> QuoteAttributes { get; set; }
        public virtual ICollection<BookingSubjectAttribute> BookingSubjectAttributes { get; set; }
        public virtual ICollection<ProductSubjectAttributeDropdownMapping> DropdownMappings { get; set; }
        public virtual ICollection<ProductPriceConfiguration> ProductPriceConfigurations { get; set; }

    }

}

    [Owned]
    public class DropdownValues
    {
        public string Value { get; set; }
    }


   


