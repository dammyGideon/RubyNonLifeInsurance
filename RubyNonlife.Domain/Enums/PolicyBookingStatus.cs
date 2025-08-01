using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Enums
{
    public enum PolicyBookingStatus
    {
        [Description("Customer Information")]
        CustomerInformation,

        [Description("Booking Information")]
        BookingInformation,

        [Description("Booking Details")]
        BookingDetails,

        [Description("SBU Information")]
        SBUInformation,

        [Description("Documentation")]
        Documentation,

        [Description("Financial Simulator")]
        FinancialSimulator,

        [Description("Complete")]
        Complete
    }

    public enum PaymentStatus
    {
        Pending,
        Paid,
        Overdue
    }


    public enum InsuranceType
    {
        [Description("Sole Insurance")]
        SoleInsurance,

        [Description("Facultative Inward")]
        FacultativeInward,

        [Description("Co-Insurance")]
        CoInsurance
    }

    public enum AdditionalInformation
    {
        [Description("Premium on quote represents 100% of transaction whole")]
        EntireTransactionPremium,

        [Description("Premium on quote represents 100% of Axa Transaction Only ")]
        AxaTransactionPremium
    }




    //public enum Accounts
    //{
    //    [Description("Product Income Account")]
    //    ProductIncomeAccount,

    //    [Description("")]
    //}
}
