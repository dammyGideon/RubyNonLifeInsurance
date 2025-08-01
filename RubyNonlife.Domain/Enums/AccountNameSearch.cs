using System.ComponentModel;

namespace RubyNonlife.Domain.Enums
{
    public enum AccountNameSearch
    {
        [Description("Product Income Account")]
        ProductIncomeAccount,

        [Description("Coinsurance Management Fees")]
        CoinsuranceManagementFee,

        [Description("Reinsurance Commissions")]
        ReinsuranceCommissions,

        [Description("Coinsurance Premium Outward")]
        CoinsurancePremiumOutward,

        [Description("Reinsurance Premium Expense")]
        ReinsurancePremiumExpense,

        [Description("Broker Commissions Expense")]
        BrokerCommissionExpense,

        [Description("Coinsurance Receivable Ledger")]
        CoinsuranceReceivableLedger,
        
        [Description("VAT Expense Ledger")]
        VATExpenseLedger,

        [Description("WithHolding Payable Ledger")]
        WithHoldingPayableLedger
        
    }


}
