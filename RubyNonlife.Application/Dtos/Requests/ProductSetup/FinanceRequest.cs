namespace RubyNonlife.Application.Dtos.Requests.ProductSetup
{
    public record FinanceRequest()
    {
        public int ProductId { get; set; }
        public List<AccountRecord> Accounts { get; set; }
    }

    public record AccountRecord
    {
       public List<IncomeLedgerRequest> IncomeLedgerRequests { get; set; }
       public List<ExpenseLedgerRequests> ExpenseLedgerRequests { get; set; }
       public List<ReceivableLedgerRequests> ReceivableLedgerRequests { get; set; }
       public List<PayableLedgerRequests> PayableLedgerRequests { get; set; }
    }

    public record IncomeLedgerRequest
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
        public string AccountName { get; set; }
    }
    public record ExpenseLedgerRequests
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
        public string AccountName { get; set; }
    }
    public record ReceivableLedgerRequests
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
        public string AccountName { get; set; }
    }
    public record PayableLedgerRequests
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
        public string AccountName { get; set; }
    }

    public record UpdateLedgerRequest
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
        public string AccountName { get; set; }
    }
}
