using Microsoft.AspNetCore.Mvc.Filters;
using RubyNonlife.Application.Helper.UtitlityModel;
using RubyNonlife.Application.Utitlies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.WorkFlowRequest
{
    public class WorkflowFilter : SearchParamRequest
    {
        public bool? IsPendingRequest { get; set; }
        public int WorkFlowId { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

    public class SearchParamRequest 
    {

        public List<SearchParam> SearchParams { get; set; } = new List<SearchParam>();
    }


    public class ProductApprovalFilterDto
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? Alias { get; set; }
        public string? CreatedBy { get; set; }
        public string? ApprovalStatus { get; set; }
        public string? ProductName { get; set; }
    }
}


