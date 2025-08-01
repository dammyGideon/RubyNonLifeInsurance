using RubyNonlife.Domain.Models.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubyNonlife.Domain.Models.PolicyEntities
{
    public class BookingOperationalSettlementDetails : BaseEntity
    {
        public string OperationType { get; set; }
        public string AccountName {  get; set; }
        public decimal Amount { get; set; }
        public string  Description { get; set; }
        public string AccountNumber { get; set; }
       
        [ForeignKey(nameof(BookingOperationalTransactionsMaster))]
        public int TransactionId { get; set; }
        public string LedgerGroupKey { get; set; }
        public string TransactionVoucher { get; set; } = string.Empty;
        public string PostingType { get; set; }= string.Empty;
        public bool isCustomerAccountNumber { get; set; } = false;
        public BookingOperationalTransactionsMaster BookingOperationalTransactionsMaster { get; set; }

    }
}
