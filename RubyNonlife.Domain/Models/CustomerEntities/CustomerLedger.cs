using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomerLedger : BaseEntity
    {
        //public long AccountId { get; set; }
        public int CustomerId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool IsDefault { get; set; }

      //  public virtual Account Account { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
