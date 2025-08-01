using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Enums
{
    public enum PaymentTypeEnum
    {
        [Display(Name = "Cash Payment")]
        CashPayment,

        [Display(Name = "Credit Note")]
        CreditNote,

        [Display(Name = "Card Payment")]
        CardPayment,

        [Display(Name = "Bank Transfer")]
        BankTransfer
    }

}
