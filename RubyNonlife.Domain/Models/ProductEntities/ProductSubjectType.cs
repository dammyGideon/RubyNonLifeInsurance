using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RubyNonlife.Domain.Models.Lookups;

namespace RubyNonlife.Domain.Models.ProductEntities;

public partial class ProductSubjectType : BaseEntity
{

    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
    public int SubjectTypeId { get; set; }
    public bool IsDeleted { get; set; }

    [ForeignKey(nameof(ProductSubjectCategory))]
    public int CategoryId { get; set; }
    public ProductSubjectCategory ProductSubjectCategory { get; set; }
    public virtual ICollection<ProductBaseSubjectTypeCover> ProductBaseSubjectTypeCovers { get; set; } = new List<ProductBaseSubjectTypeCover>();
    public virtual ICollection<ProductAdditionalSubjectTypeCover> ProductAdditionalCovers { get; set; }
    public ICollection<ProductSubjectTypeAttribute> ProductSubjectTypeAttributes { get; set; }



}