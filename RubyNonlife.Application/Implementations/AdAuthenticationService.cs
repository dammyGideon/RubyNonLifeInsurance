using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Helper.GeneralHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Implementations
{
    public class AdAuthenticationService : IAdAuthenticationService
    {
        public readonly IAdminServiceIntegration _adminService;

        public AdAuthenticationService(IAdminServiceIntegration adminService) {

            _adminService = adminService;
        }


        public async Task<BaseResponse<string>> AuthenticationAdUser(string username, string password)
        {
            var auth = await _adminService.AuthenticateADUser(username, password);

            if (auth.Success && auth.Data.IsAuthenticated)
            {
                // Return only the token
                return ResponseFactory.CreateSuccess<string>(auth.Data.Token, "Login successful.");
            }
            else
            {
                // Return failure with message from auth response
                return ResponseFactory.CreateFailure<string>(auth.ResponseMessage);
            }
        }

        public async Task<BaseResponse<string>> AuthenticatedUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return ResponseFactory.CreateFailure<string>("Username (FullName) cannot be empty.");
            }

            // Optionally check password too if you're planning to use it
            if (string.IsNullOrWhiteSpace(password))
            {
                return ResponseFactory.CreateFailure<string>("Password cannot be empty.");
            }

            var authUser = await _adminService.AuthenticateByFullName(username);

            if (authUser.Success && authUser.Data.IsAuthenticated)
            {
                return ResponseFactory.CreateSuccess<string>(authUser.Data.Token, "Login successful.");
            }
            else
            {
                return ResponseFactory.CreateFailure<string>(authUser.ResponseMessage ?? "Authentication failed.");
            }
        }


    }
}
