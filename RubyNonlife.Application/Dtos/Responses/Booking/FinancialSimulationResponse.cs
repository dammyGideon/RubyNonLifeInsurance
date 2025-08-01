using RubyNonlife.Application.Implementations;
using System.ComponentModel;

namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record FinancialSimulationResponse
    {
        public TotalPremiumResponse TotalPremium { get; set; }
        public AxaTotalPremiumResponse AxaTotalPremium { get; set; }
        public RetentionCapacityResponse RetentionCapacity { get; set; }
        public TreatyCapacityResponse TreatyCapacity { get; set; }
        public UnderWritingCapacityResponse UnderWritingCapacity { get; set; }
        public ExcessCapacityResponse ExcessCapacity { get; set; }

        public string TransactionId {  get; set; }
        public IncomeRecognitionResponse IncomeRecognitionResponse { get; set; }
        public ManagementFeeResponse ManagementFeeResponse { get; set; }
        public BookingCostOfInsuranceFeeResponse BookingCostOfInsuranceFeeResponse { get; set; }
        public BookingBrokerCommissionsResponse BookingBrokerCommissionsResponse { get; set; }
        public BookingCommissionAgentResponse BookingCommissionAgentResponse { get; set; }

        public ReinsuranceResponse ReinsuranceResponse { get; set; }


    }

   

    public record RetentionCapacityResponse
    {
        public decimal RetentionCapacity { get; set; }
        public string AssociatedPremium { get; set; }
    }
    public record TotalPremiumResponse
    {
        public decimal SumInsured { get; set; }
        public decimal TotalPremium { get; set; }
    }
    public record AxaTotalPremiumResponse
    {
        public decimal axaSumInsured { get; set; }
        public decimal axaPremium { get; set; }
    }


    public record TreatyCapacityResponse
    {
        public decimal TreatyCapacity { get; set; }
        public string AssociatedPremium { get; set; }
    }
    public record UnderWritingCapacityResponse
    {
        public decimal UnderWritingCapacity { get; set; }
        public string AssociatedPremium { get; set; }
    }
    public record ExcessCapacityResponse
    {
        public decimal ExcessCapacity { get; set; }
        public string AssociatedPremium { get; set; }
    }

    public record IncomeRecognitionResponse
    {
        public string VoucherNo { get; set; }
        public string VocherType { get; set; }
        public string PostType { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public List<IncomeRecognitionDebitResponse> Debits { get; set; }
        public List<IncomeRecognitionCreditResponse> Credits { get; set; }
    }

    public record IncomeRecognitionDebitResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }

    }

    public record IncomeRecognitionCreditResponse
    {
        public string AccountName { get; set; }
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string Description { get; set; }
        public decimal? Premium { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }

    }

    public record BookingCostOfInsuranceFeeResponse
    {
        public string Voucher { get; set; }
        public string VocherType { get; set; }
        public string Description { get; set; }
        public decimal NewPremium { get; set; }
        public List<CostOfInsuranceDebitResponse> Debits { get; set; }
        public List<CostOfInsuranceCreditResponse> Credits { get; set; }

    }

    public record ManagementFeeResponse
    {
        public string VoucherNo { get; set; }
        public string VocherType { get; set; }
        public string Description { get; set; }
        public decimal NewPremium { get; set; }
        public List<ManagementFeeDebitResponse> Debits { get; set; } = new List<ManagementFeeDebitResponse>();
        public List<ManagementFeeCreditResponse> Credits { get; set; } = new List<ManagementFeeCreditResponse>();
    }

    public record ManagementFeeDebitResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }
        public int? InsurerId { get; set; }
    };
    public record ManagementFeeCreditResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }
        public int? InsurerId { get; set; }
    }
    public record BookingReInsuranceResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string Description { get; set; }
        public string ProductAccountName { get; set; }
        public string AccountNumber { get; set; }

    }



    public class CostOfInsuranceDebitResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }
    }

    public class CostOfInsuranceCreditResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }
    }



    public record BookingBrokerCommissionsResponse
    {
        public string VoucherNo { get; set; }
        public string VocherType { get; set; }
        public string Description { get; set; }
        public decimal NewPremium { get; set; }
        public List<CommissionsBrokerCreditResponse> Credits { get; set; }
        public List<CommissionsBrokerDebitResponse> Debits { get; set; }
    }

    public record CommissionsBrokerDebitResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { set; get; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public string AccountNumber { get; set; }
    }

    public record CommissionsBrokerCreditResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { set; get; }
        public string Description { get; set; }
        public decimal? BrokerCommission { get; set; }
        public string AccountNumber { get; set; }
    }

    public record BookingCommissionAgentResponse
    {
        public string VoucherNo { get; set; }
        public string VocherType { get; set; }
        public string PostType { get; set; }
        public string Description { get; set; }
        public decimal NewPremium { get; set; }
        public List<CommissionAgentCreditResponse> Credits { get; set; }
        public List<CommissionAgentDebitResponse> Debits { get; set; }

    }

    public record CommissionAgentDebitResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }
    }




    public record CommissionAgentCreditResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }
    }

    public class CommissionAgentCreditAdditionalResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { get; set; } // "WHT Payable Ledger"
        public string Description { get; set; }
        public decimal Amount { get; set; } // WHT (5% of Agent Fee)
        public string AccountNumber { get; set; }
    }


    public class ReinsuranceResponse
    {
        public string VoucherNo { get; set; }
        public string VocherType { get; set; }
        public string PostType { get; set; }
        public string Description { get; set; }
        public List<ReinsuranceDebitResponse> Debits { get; set; } = new();
        public List<ReinsuranceCreditResponse> Credits { get; set; } = new();
        public decimal TotalReinsurancePremium { get; set; }
        public decimal TotalCommissionInward { get; set; }
    }
    public class ReinsuranceDebitResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }
    }
    public class ReinsuranceCreditResponse
    {
        public bool IsCustomerAccountNumber { get; set; } = false;
        public string PostType { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string AccountNumber { get; set; }
    }




    public class SavedFinancialSimulationResponse
    {
        public FinancialSimulationMasterResponse Master { get; set; }
        public List<FinancialSimulationSettlementDetailResponse> SettlementDetails { get; set; }
    }

    public class FinancialSimulationMasterResponse
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Premium { get; set; }
        public string Description { get; set; }
        public string VoucherType { get; set; }
        public string VoucherNo { get; set; }
    }

    public class FinancialSimulationSettlementDetailResponse
    {
        public string AccountName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string OperationType { get; set; }
        public string AccountNumber { get; set; }
        public string LedgerGroupKey { get; set; }
        public string PostType { get; set; }
        public bool IsCustomerAccountNumber { get; set; } = false;
        
    }



}
