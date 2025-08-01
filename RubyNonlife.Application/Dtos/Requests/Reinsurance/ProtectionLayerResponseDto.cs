using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.Reinsurance
{
    public record ProtectionLayerResponseDto
    {
        public int Id { get; set; }
        public int AgreementId { get; set; }
        public string ProtectionType { get; set; }
        public string ProtectionSubType { get; set; }
        public decimal? RetentionAmount { get; set; }
        public int? NumbersOfLines { get; set; }
        public decimal TreatyCapacity { get; set; }
        public decimal? UnderWriterCapacity { get; set; }
        public decimal? Deductible { get; set; }
    }
}
