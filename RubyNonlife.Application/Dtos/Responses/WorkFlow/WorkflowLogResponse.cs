using RubyNonlife.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.WorkFlow
{
    public class WorkflowLogResponse
    {
        public int WorkflowId { get; set; }
        public RequestExecutionStatus Status { get; set; }
        public string Message { get; set; }
    }
}
