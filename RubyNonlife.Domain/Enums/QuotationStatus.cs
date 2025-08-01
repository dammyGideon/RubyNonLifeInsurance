using System.ComponentModel;

namespace RubyNonlife.Domain.Enums
{
    public enum QuotationStatus
    {
        Pending,
        Approved,
        RequireUnderWriting,
        Review,
        Negotiation,
        Accepted,

    } 

   

    public enum QuotePreferencesStatus
    {
        Simulation,

        [Description("Customer Based")]
        CustomerBased,
    }
}


