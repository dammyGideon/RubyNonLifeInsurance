using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public interface IFinancialResponse
    {
        decimal NewPremium { get; }
        List<AccountingEntry> Debits { get; }
        List<AccountingEntry> Credits { get; }
    }


    public class AccountingEntry
    {

    }
}
