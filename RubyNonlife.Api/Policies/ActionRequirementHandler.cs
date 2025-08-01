using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace RubyNonlife.Api.Policies
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AuthorizationHandler{ActionRequirement}" />
    public class ActionRequirementHandler : AuthorizationHandler<ActionRequirement>
    {
        /// <summary>
        /// Makes a decision if authorization is allowed based on a specific requirement.
        /// </summary>
        /// <param name="context">The authorization context.</param>
        /// <param name="requirement">The requirement to evaluate.</param>
        /// <returns></returns>
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ActionRequirement requirement)
        {
           var actionClaim = context.User.Claims.SingleOrDefault(x=> x.Type == "Actions");
            if (actionClaim ==null || !actionClaim.Value.Contains(requirement.Status))
            {
                return Task.CompletedTask;
            }
            context.Succeed(requirement);
            return Task.CompletedTask;
            
        }
    }
}
