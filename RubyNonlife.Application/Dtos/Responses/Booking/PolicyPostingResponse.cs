using RubyNonlife.Application.Dtos.Requests.ProductSetup;

namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record PolicyPostingResponse
    {
        public CustomerPolicyResponse Customer { get; set; }
        public PolicyResponse Policy { get; set; }
        public PostingResponse Postings {  get; set; }
    }

    public record CustomerPolicyResponse
    {
        public string Name { get; set; }
        public string CustomerNumber { get; set; }
        public List<AccountNumberResponse> AccountNumber {  get; set; }

    }

    public record PolicyResponse
    {
        public string Name { get; set; }
        public decimal? AmountPayable { get; set; }
    }

    public record AccountNumberResponse
    {
        public string AccountNumber { get; set; }
    }
    public class PostingResponse
    {
        public List<IncomeLedgerResponse> IncomeLedgerResponse { get; set; }
        public List<ExpenseLedgerResponse> ExpenseLedgerResponse { get; set; }
        public List<ReceivableLedgerResponse> ReceivableLedgerResponse { get; set; }
        public CostOfInsurancePostingAccounts CostOfInsurance { get; set; }
    }
    public class BookingPostingAccounts
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
       
    }
    public class CostOfInsurancePostingAccounts
    {
        public string DebitAccount {  get; set; }
        public string CreditAccount { get; set;}
    }


    public record IncomeLedgerResponse
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
    }
    public record ExpenseLedgerResponse
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
    }
    public record ReceivableLedgerResponse
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
    }

    public record UpdateLedgerResponse
    {
        public string AccountNumber { get; set; }
        public string Description { get; set; }
    }





}
