using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record GetBookingAttributeResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Datatype { get; set; }
        public List<DropdownValuesSubjectAttributeResponse> DropdownValues { get; set; }
    }


    public class DropdownValuesSubjectAttributeResponse
    {
        public string Value { get; set; }
    }
}
