using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses
{
    public record LocationFieldResponses
    {
        public int ProductId { get; set; }
        public string LocationName { get; set; }
        public int LocationId { get; set; }
        public bool RequiredGenericLocation { get; set; }
        public bool RequiredSpecificGenericLocation { get; set; }
        public List<LocationFieldResponse> Attributes { get; set; }
    }

    public class LocationFieldResponse
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeType { get; set; }
        public bool IsRequired { get; set; }
        public List<string> DropdownOptions { get; set; }
    }

    public class GenericLocationAttributeResponse
    {
        public Guid? EntityId { get; set; }
        public string GenericLocationName { get; set; }
        public List<Detail> Attributes { get; set; }

        public class Detail
        {
            public int Id { get; set; }
            public int AttributeId { get; set; }
            public string AttributeName { get; set; }
            public string AttributeValue { get; set; }
        }
    }

}
