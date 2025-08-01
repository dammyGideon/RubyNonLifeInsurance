using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.ProductEntities
{
    public class ProductSubjectTypeAttributeOption
    {
        public int Id { get; set; }
        public string OptionName { get; set; }  // Option value (e.g., "Toyota", "Blue", etc.)

        // Nullable ParentOptionId for parent-child relationship (e.g., "Toyota" as parent, "Camry" as child)
        public int? ParentOptionId { get; set; }

        [ForeignKey("ParentOptionId")]
        public virtual ProductSubjectTypeAttributeOption ParentOption { get; set; }

        // Child options for hierarchical attributes (e.g., car models under a car make)
        public virtual ICollection<ProductSubjectTypeAttributeOption> ChildOptions { get; set; } = new List<ProductSubjectTypeAttributeOption>();

        // Flag to indicate if this option is special (e.g., to differentiate "Model" from "Make")
        public bool IsSpecialAttribute { get; set; } = false;
    }
}


   


