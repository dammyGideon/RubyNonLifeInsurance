using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record PolicyCodeBookingResponses
    {
        public string BookingCode { get; init; }
        public int BookingId { get; init; }
        public string CustomerNumber { get; init; }
        public decimal? Premium { get; init; }
    }
}


