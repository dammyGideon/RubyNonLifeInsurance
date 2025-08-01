using RubyNonlife.Domain.Models.Lookups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BookingOperationalTransactionsMaster : BaseEntity
    {
        public decimal Premium {  get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public string VoucherNo { get; set; } = string.Empty;
        public string VoucherType { get; set;} = string.Empty;
        [ForeignKey(nameof(PolicyBooking))]
        public int BookingId { get; set; }
        public PolicyBooking PolicyBooking { get; set; }

        public ICollection<BookingOperationalSettlementDetails> BookingOperationalSettlementDetails { get; set; }
    }
}
