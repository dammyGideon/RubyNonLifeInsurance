using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses
{
    public record GenericNameResponse
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }

    public record CustomerIdResponse
    {
        public int CustomerId { get; init; }
        public int BookingId { get; init; }
    }
    public record PolicyBookingDocumentResponse
    {
        public int ProductDocumentId { get; init; }
        public string DocumentName { get; init; }
        public bool IsRequired { get; init; }
        public string FilePath { get; init; }
    }

   
    

}
