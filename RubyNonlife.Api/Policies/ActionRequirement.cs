using Microsoft.AspNetCore.Authorization;

namespace RubyNonlife.Api.Policies
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IAuthorizationRequirement" />
    public class ActionRequirement :IAuthorizationRequirement
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRequirement"/> class.
        /// </summary>
        /// <param name="status">The status.</param>
        public ActionRequirement(string status)
        {
            Status = status;
        }
    }
}
