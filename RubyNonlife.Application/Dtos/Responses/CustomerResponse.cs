using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses
{
    public class CustomerResponse
    {

        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerType { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Status { get; set; }
        public int Age { get; set; }
        public int AgeNextBirthday { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string StateOfOrigin { get; set; }
        public string Religion { get; set; }
        public string Occupation { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Bvn { get; set; }
        public bool IsPoliticallyExposed { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }
        public string ApprovalStatus { get; set; }
        public string CaseId { get; set; }

        public string AssociationType { get; set; }
        public string NinNumber { get; set; }
        public string TaxIdNumber { get; set; }
        public string PreferredCommunicationMethod { get; set; }
        public DateTime? DateOfInCorporation { get; set; }
        public decimal? EstimatedAnnualRevenue { get; set; }
        public string NatureOfBusiness { get; set; }
        public string CompanyName { get; set; }
        public string RcNumber { get; set; }
        public string AssociationName { get; set; }
    }
}
