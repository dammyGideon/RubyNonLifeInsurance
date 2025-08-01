using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Implementations
{


    public class ReinsuranceSimulatorService
    {
        // The method now takes a Policy and Premium as input
       
    }




    public class Policy
    {
        public string Product { get; set; }
        public decimal Risk { get; set; }
        public decimal Premium { get; set; }
        public List<Treaty> Treaties { get; set; } = new List<Treaty>();
    }

    public class Treaty
    {
        public string Layer { get; set; } // A, B, C
        public TreatyType Type { get; set; }
        public decimal Retention { get; set; }
        public decimal TreatyLimit { get; set; }
        public List<Security> Securities { get; set; } = new List<Security>();

        // New property for Treaty Capacity
        public decimal TreatyCapacity => TreatyLimit;
    }

    public enum TreatyType
    {
        QuotaShare,
        Surplus,
        ExcessOfLoss
    }

    public class Security
    {
        public string Name { get; set; }
        public decimal ShareOfRiskPercent { get; set; } // e.g. 50 for 50%
        public decimal CommissionPercent { get; set; } // e.g. 30 for 30%
    }


    public class SimulationResult
    {
        public string AssociatedPremium { get; set; }
        public decimal TreatyCapacity { get; set; }
        public decimal ExcessCapacity { get; set; }
        public decimal RetentionCapacity { get; set; }
        public decimal UnderwritingCapacity { get; set; }
    }



}
