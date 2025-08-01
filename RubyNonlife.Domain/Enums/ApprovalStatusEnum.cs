using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Enums
{
    public enum ApprovalStatusEnum
    {
        [Description("Pending")]
        Pending = 1,

        [Description("Approved")]
        Approved = 2,

        [Description("Completed")]
        Completed = 2,

        [Description("Declined")]
        Declined = 3,

       [Description("Rejected")]
        Rejected = 4,

       [Description("Approve as Principal")]
        Principal,

       [Description("Approve as Alternate")]
        Alternate,

        [Description("Place on Hold")]
        Hold

    }

    public enum OperationType
    {
        [Description("Debit")]
        Debit,
        
        [Description("Credit")]
        Credit
    }
}
