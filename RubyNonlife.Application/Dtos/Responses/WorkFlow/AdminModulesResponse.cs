using RubyNonlife.Application.Dtos.Responses.Quotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.WorkFlow
{
    public class AdminModulesResponse
    {
        public int Id { get; set; }
        public int LineOfBusinessId { get; set; }
        public int PendingCount { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public List<AdminWorkflowResponse> Workflows { get; set; }
    }


    public class AdminWorkflowResponse
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool EnableEmailNotifications { get; set; }
        public List<Approvalsetup> ApprovalSetups { get; set; }
    }

    public class Approvalsetup
    {
        public int Id { get; set; }
        public int? WorkflowId { get; set; }
        public bool IsCompleted { get; set; }
        public int? ApprovingOfficeId { get; set; }
        public string ApprovingOffice { get; set; }
        public string User { get; set; }
        public int? ApprovingPositionId { get; set; }
        public string ApprovingPosition { get; set; }
        public int? FunctionId { get; set; }
        public string Function { get; set; }
        public int Sequence { get; set; }
    }




    public class AdminFunction
    {
        public int Id { get; set; }
        public int? LineOfBusinessId { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
    }

    public class Officer
    {
        public int Id { get; set; }
        public int OfficeId { get; set; }
        public string UserId { get; set; }
        public int? PositionId { get; set; }
        public int? FunctionId { get; set; }
    }


    public class ApprovingPosition
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
    }

    public class WorkflowResponse
    {
        public int Id { get; set; }
        public int WorkflowProcessId { get; set; }
        public int ProgressPercentage { get; set; }
        public string RequestTitle { get; set; }
        public string ProductAlias { get; set; }
        public string ProductDescription { get; set; }
        public string CreatedBy { get; set; }
        public string Status { get; set; }
        public int? SourceId { get; set; }
        public int? PolicySourceId {  get; set; }
        public bool IsRequestCompleted { get; set; }
        public string ApprovingOffice { get; set; }
        public string Function { get; set; }
        public int ApprovalLevel { get; set; }
        public List<WorkflowApprovalResponse> Approvals { get; set; }
        public int? ApprovingOfficeId { get; set; }
        public int FunctionId { get; set; }
        public object Source { get; set; }
        public DateTime Date { get; set; }
        public bool IsApprovalCompleted {  get; set; }
    }



    public record PaginatedWorkflowResponse
    {
        public int PageNumber { get; init; }
        public int PageSize { get; init; }
        public int TotalCount { get; init; }
        public int TotalPages { get; init; }
        public bool HasPreviousPage { get; init; }
        public bool HasNextPage { get; init; }

        public List<WorkflowResponse> WorkflowResponse { get; init; }

    }
    public class WorkflowApprovalResponse
    {
        public int Id { get; set; }
        public int Sequence { get; set; }
        public int? ApproverUserId { get; set; }
        public string ApprovingOffice { get; set; }
        public string Function { get; set; }
        public string FullName { get; set; }
        public bool? IsApproved { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
    }




    public class PaginatedProductApprovalResponse
    {
        public int PageNumber { get; init; }
        public int PageSize { get; init; }
        public int TotalCount { get; init; }
        public int TotalPages { get; init; }
        public bool HasPreviousPage { get; init; }
        public bool HasNextPage { get; init; }
        public List<ProductApprovalResponse> ProductApprovalResponse { get; init; }
    }
    public class ProductApprovalResponse
    {
        public string ProductName { get; set; }
        public string ProductAlias { get; set; }
        public string ProductDescription { get; set; }
        public int ProductStage {  get; set; }
        public string ApprovalStatus { get; set; }
        public List<GenericNameResponse> ApprovingOffices { get; set; }

    }

    public class AdminStatesResponse
    {
        public int Id { get; set; }
        public int StateCode { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Slogan { get; set; }
        public List<Localgovernmentarea> LocalGovernmentAreas { get; set; }
    }

    public class Localgovernmentarea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
    }

    public class ApprovingOfficeApproval
    {
        public string ApprovalName {  get; set; }
        public DateTime? ApproveDate {  get; set; }
        public string Comment {  get; set; } = string.Empty;

        public int Sequence {  get; set; }

    }

}
