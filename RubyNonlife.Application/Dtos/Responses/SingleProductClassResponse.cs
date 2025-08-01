using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses
{
    public record SingleProductClassResponse
    {
        public int ClassId { get; init; }
        public string ClassName { get; init; }
        public List<NonLifeProductCoverResponse> BaseCovers { get; init; }

        public List<NonLifeProductAdditionalCoversResponse> AdditionalCovers { get; init; }


        public record NonLifeProductCoverResponse
        {
            public int CoverId { get; init; }
            public string CoverName { get; init; }

        }

        public record NonLifeProductAdditionalCoversResponse
        {
            public int CoverId { get; init; }
            public string CoverName { get; init; }
        }



        public record AdminProductCoverResponse
        {
            public int Id { get; init; }
            public string Caption { get; init; }
        }
     

    }
}
