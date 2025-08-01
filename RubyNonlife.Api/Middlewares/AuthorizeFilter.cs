using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Ruby.Api.Middlewares;
using System.Collections.Generic;
using System.Linq;

namespace RubyNonlife.Api.Middlewares
{
    public class AuthorizeFilter : IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //var userPermissions = context.HttpContext.Items["UserPermissions"] as UserPermissions;
            //if (userPermissions == null)
            //{
            //    context.Result = new UnauthorizedResult();
            //    return;
            //}

            //var requiredPermission = ((List<object>)context.ActionDescriptor.EndpointMetadata).OfType<AuthorizeAttribute>().FirstOrDefault()?.Permission;
            //if (!userPermissions.Actions.Contains(requiredPermission) && !userPermissions.Roles.Contains(requiredPermission))
            //{
            //    context.Result = new ForbidResult();
            //    return;
            //}
        }
    }
}
