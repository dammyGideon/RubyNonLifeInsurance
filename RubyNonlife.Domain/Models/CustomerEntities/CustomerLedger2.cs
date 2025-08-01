using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomerLedger2
    {
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerNumber { get; set; }
        public string FirstName { get; set; }
    }
}
