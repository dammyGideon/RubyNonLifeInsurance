using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.Booking
{
    public record CustomerInformationRequest
    {
        public string CustomerNumber { get; init; }
        public int QuoteId { get; init; }
        public string Subject { get; init; }
        public List<BookingSubjectAttributeRequest> BookingSubjectAttributeRequests { get; init; }
        public List<GenericLocationAttributeDto> GenericLocationAttributeDtos { get; init; }

    }

    public class BookingSubjectAttributeRequest
    {
        public List<BookingSubjectAttributeRequests> BookingSubjectAttributeRequests { get; set; }
    }

    public class BookingSubjectAttributeRequests
    {
        public string AttributeName { get; set; }
        public dynamic AttributeValue { get; set; }
        public int? AttributeId { get; set; }
        public Guid EntityId { get; set; }
    }

    public class GenericLocationAttributeDto
    {
        public string AttributeName { get; init; } 
        public string AttributeValue { get; init; } 
        public int ProductGenericLocationId { get; init; }
    }

   

}
