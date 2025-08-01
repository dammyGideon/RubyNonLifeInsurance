using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomerBankAccount
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BankAccountId { get; set; }
        public bool? IsCustomerDefault { get; set; }
        public bool IsDeleted { get; set; }

        public virtual BankAccount BankAccount { get; set; }
        public virtual Customer Customers { get; set; }
    }
}
