using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.jwtRequest
{
    public class AuthRequestDto
    {
        public string username {  get; set; }
        public string password { get; set; }
    }
}
