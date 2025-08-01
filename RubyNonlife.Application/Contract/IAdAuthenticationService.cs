using RubyNonlife.Application.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Contract
{
    public interface IAdAuthenticationService
    {
        Task<BaseResponse<string>> AuthenticationAdUser(string username, string password);
        Task<BaseResponse<string>> AuthenticatedUser(string username, string password);
    }
}
