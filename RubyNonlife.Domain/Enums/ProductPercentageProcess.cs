using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Enums
{
    public enum ProductPercentageProcess
    {
        ProductSetupStage = 50,
        UnderWriterStage =50,
        AccountStage = 100,
    }

    public enum ProductStatuses
    {
        InProgress,
        Rejected,
        Complete,
        InComplete,
        Approved
    }

    public enum ProductStageOrder
    {
        [Description("Product Team")]
        ProductTeam = 1,
        [Description("UnderWriter Team")]
        UnderWriter = 2,
        [Description("Financial Control")]
        FinancialControl = 4,
        [Description("Reinsurance")]
        Reinsurance = 3
    }
}
