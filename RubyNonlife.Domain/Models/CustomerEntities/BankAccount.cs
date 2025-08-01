using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class BankAccount : BaseEntity
    {
        public int BankId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? DateLastModified { get; set; }

        public virtual BankLookup BankLookup { get; set; }
        public virtual ICollection<CustomerBankAccount> CustomerBankAccounts { get; set; }
    }
}
