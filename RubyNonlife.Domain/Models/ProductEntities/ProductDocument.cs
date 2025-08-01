using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.PolicyEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities;

public partial class ProductDocument : BaseEntity
{
    public string Name { get; set; } 
    public string Format {  get; set; }
    public string Size { get; set; }
    public bool IsRequired { get; set; }
    public bool IsDeleted { get; set; }
    public string? DocumentName { get; set; }
  
    public int ProductDocumentCategoryId { get; set; }
    public ProductDocumentCategory ProductDocumentCategory { get; set; }


    public ICollection<BookingUploadedDocument> BookingUploadedDocuments { get; set; }
    
}
