using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomerPhoneBook : BaseEntity
    {
        public int CustomerId { get; set; }
      //  public int? CountryPhoneCodeId { get; set; }
        public string PhoneNumber { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DateDeleted { get; set; }

        //public virtual CountryDialingCode CountryPhoneCode { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
