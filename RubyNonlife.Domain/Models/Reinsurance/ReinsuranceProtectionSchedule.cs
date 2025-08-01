using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.Reinsurance
{
    public class ReinsuranceProtectionSchedule : BaseEntity
    {
        public int AgreementId { get; set; }
        [ForeignKey("AgreementId")]
        public ReinsuranceAgreement ReinsuranceAgreement { get; set; }
        public string ProtectionType { get; set; }
        public string ProtectionSubType { get; set; }
        public decimal RetentionAmount { get; set; } = decimal.Zero;
        public int NumbersOfLines { get; set; } = 0;
        public decimal TreatyCapacity { get; set; } = decimal.Zero;
        public decimal UnderWriterCapacity { get; set; } = decimal.Zero;
        public decimal Deductible { get; set; } = decimal.Zero;

    }
}
