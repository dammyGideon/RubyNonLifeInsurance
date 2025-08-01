using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses
{
    public record FrequencyResponse
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }
}
