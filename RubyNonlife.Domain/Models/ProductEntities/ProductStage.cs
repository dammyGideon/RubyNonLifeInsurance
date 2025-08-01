using RubyNonlife.Domain.Models.Lookups;

namespace RubyNonlife.Domain.Models.ProductEntities;

    public class ProductStage : BaseEntity
    {
       
        public int TeamId { get; set; }

        public int StageOrder { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DateDeleted { get; set; }

        public string? DeletedBy { get; set; }

        public virtual ICollection<ProductDisapproval> ProductDisapprovals { get; set; } = new List<ProductDisapproval>();

        public virtual ICollection<ProductStageAudit> ProductStageAudits { get; set; } = new List<ProductStageAudit>();

    }



