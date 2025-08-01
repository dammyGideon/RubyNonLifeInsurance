using RubyNonlife.Domain.Models.Lookups;
using RubyNonlife.Domain.Models.QuoteEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BookingBeneficiary : BaseEntity
    {
        [ForeignKey(nameof(QuotationAttributeValue))]
        public int QuotationAttributeValueId { get; set; }
        public QuotationAttributeValue QuotationAttributeValue { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey(nameof(BookingBeneficiaryType))]
        public int BookingBeneficiaryTypeId { get; set; }
        public BookingBeneficiaryType BookingBeneficiaryType { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool PrimaryBeneficiary { get; set; }
    }
}
