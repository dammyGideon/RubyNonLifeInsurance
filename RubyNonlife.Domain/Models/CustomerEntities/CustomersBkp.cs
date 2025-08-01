using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class CustomersBkp : BaseEntity
    {
        public string CustomerNumber { get; set; }
        public int? TitleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public int? ReligionId { get; set; }
        public short? MaritalStatusId { get; set; }
        public short? GenderId { get; set; }
        public int? OccupationId { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? NationalityId { get; set; }
        public int? StateOfOriginId { get; set; }
        public int? AverageNumberOfMembersOrEmployees { get; set; }
        public string AssociationType { get; set; }
        public string NinNumber { get; set; }
        public string Status { get; set; }
        public string Bvn { get; set; }
        public string TaxIdNumber { get; set; }
        public string ReasonForCreation { get; set; }
        public bool? HasDualCitizenship { get; set; }
        public string ForeignMailingAddress { get; set; }
        public string ResidencePermitNumber { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public bool IsPoliticallyExposed { get; set; }
        public bool IsApproved { get; set; }
        public bool HasPendingModificationRequest { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string CustomerType { get; set; }
        public DateTime? DateOfInCorporation { get; set; }
        public decimal? EstimatedAnnualRevenue { get; set; }
        public int? NatureOfBusinessId { get; set; }
        public string CompanyName { get; set; }
        public string RcNumber { get; set; }
        public string AssociationName { get; set; }
        public int? RmId { get; set; }
    }
}
