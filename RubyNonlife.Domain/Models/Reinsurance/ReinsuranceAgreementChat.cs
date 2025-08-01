using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.Reinsurance
{
    public class ReinsuranceAgreementChat : BaseEntity
    {

        [ForeignKey("AgreementId")]
        public int AgreementId { get; set; } 
        public ReinsuranceAgreement ReinsuranceAgreement { get; set; }
        public string Comment { get; set; } 
        public string UserId { get; set; }  

    }



}
