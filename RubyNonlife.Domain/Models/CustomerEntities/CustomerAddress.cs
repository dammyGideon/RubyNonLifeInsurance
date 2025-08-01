using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomerAddress : BaseEntity
    {
        public int CustomerId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        //public int LocalGovernmentAreaId { get; set; }
        public string Street { get; set; }
        public string FullAddress { get; set; }
        public string StreetArea { get; set; }
        public string BuildingNumber { get; set; }
        public string Landmark { get; set; }
        public string AddressType { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual Customer Customer { get; set; }
       // public virtual LocalGovernmentAreaLookup LocalGovernmentArea { get; set; }
       // public virtual LocalGovernmentAreaLookupsOld LocalGovernmentAreaNavigation { get; set; }
    }
}
