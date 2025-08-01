using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Enums
{
    public enum ProductStageEnum
    {
        [Description("Product Team")]
        ProductTeam =1,

        [Description("Underwriter Team")]
        UnderwriterTeam = 2,

        [Description("Financial Control")]
        FinancialControl = 3
    }
}
