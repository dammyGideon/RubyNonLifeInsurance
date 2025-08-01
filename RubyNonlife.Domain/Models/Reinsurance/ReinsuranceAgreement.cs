using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.Reinsurance
{
    public class ReinsuranceAgreement : BaseEntity
    {
        public int BusinessYear {get;set;}
        public string TransactionType { get;set;}
        public string AgreementCaption { get;set;}
        public string AgreementDescription { get; set; }
        public bool ExpiryDate { get;set;}
        public DateTime? ExpiresDate { get;set;}
        public string ReviewStatus { get; set; } = string.Empty;
        public string ApprovalStatus {  get; set; } = string.Empty;
        public string Status {  get; set; } = string.Empty;


        // Navigation property for chat messages
        public ICollection<ReinsuranceAgreementChat> ReinsuranceAgreementChat { get; set; } 
        public  ICollection<ReinsuranceProtectionSchedule> ReinsuranceProtectionSchedule { get; set;}
    }
}
