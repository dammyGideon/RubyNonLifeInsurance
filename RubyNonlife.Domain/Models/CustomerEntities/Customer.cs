using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.QuoteEntities;
using System;
using System.Collections.Generic;

#nullable disable

namespace RubyNonlife.Domain.Models.CustomerEntities
{
    public partial class Customer : BaseEntity
    {
        public Customer()
        {
           
            ContactPeople = new HashSet<ContactPerson>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            CustomerBankAccounts = new HashSet<CustomerBankAccount>();
            CustomerDocuments = new HashSet<CustomerDocument>();
            CustomerLedgers = new HashSet<CustomerLedger>();
            CustomerModifications = new HashSet<CustomerModification>();
            CustomerOccupations = new HashSet<CustomerOccupation>();
            CustomerOnboardingApprovals = new HashSet<CustomerOnboardingApproval>();
            CustomerPhoneBooks = new HashSet<CustomerPhoneBook>();
            // NonLifePolicies = new HashSet<NonLifePolicy>();
            //  Quotations = new HashSet<Quotation>();
           


        }
        public string CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public int? GenderId { get; set; }
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
        
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string CustomerType { get; set; }
        public DateTime? DateOfInCorporation { get; set; }
        public decimal? EstimatedAnnualRevenue { get; set; }
        public int? NatureOfBusinessId { get; set; }
        public string CompanyName { get; set; }
        public string FullAddress { get; set; }
        public string RcNumber { get; set; }
        public string AssociationName { get; set; }
        public string? LeadId {  get; set; }
        public string PhoneNumber {  get; set; }
        public string PayableLedger { get; set; } = string.Empty;
        public string IncomeLedger { get; set; } = string.Empty;
        public string ExpenseLeger {get; set; } = string.Empty;
        public string ReceivableLedger { get; set; } = string.Empty;
        public virtual NatureOfBusinessLookup NatureOfBusiness { get; set; }
        public virtual State StateOfOrigin { get; set; }
        public virtual CustomerTitleLookup Title { get; set; }
        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<CustomerBankAccount> CustomerBankAccounts { get; set; }
        public virtual ICollection<CustomerDocument> CustomerDocuments { get; set; }
        public virtual ICollection<CustomerLedger> CustomerLedgers { get; set; }
        public virtual ICollection<CustomerModification> CustomerModifications { get; set; }
        public virtual ICollection<CustomerOccupation> CustomerOccupations { get; set; }
        public virtual ICollection<CustomerOnboardingApproval> CustomerOnboardingApprovals { get; set; }
        public virtual ICollection<CustomerPhoneBook> CustomerPhoneBooks { get; set; }
        public virtual ReligionLookup Religion {  get; set; }
        public virtual GenderLookup Gender { get; set; }
        public virtual MaritalStatusLookup MaritalStatus { get; set; }
       
       // public virtual ICollection<NonLifePolicy> NonLifePolicies { get; set; }
       // public virtual ICollection<Quotation> Quotations { get; set; }
      
    }
}
