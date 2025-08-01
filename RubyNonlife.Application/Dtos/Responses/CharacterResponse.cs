using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses
{
    public record CharacterResponse
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int value { get; init; }
    }
}
