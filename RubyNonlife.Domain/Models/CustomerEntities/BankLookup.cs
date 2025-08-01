using RubyNonlife.Domain.Models.Lookups;

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class BankLookup : BaseEntity {
        
            public string BankCode { get; set; }
            public string Name { get; set; }
            public bool IsDeleted { get; set; }
            public DateTime? DateDeleted { get; set; }

            public virtual ICollection<BankAccount> BankAccounts { get; set; }
           
    }
}
