using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record SbuResponse
    {
        public string SubNames { get; set; }
    }
    public record SbuAgentResponse
    {
        public string AgentNames { get; set; }
    }

    public record Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
    }

    //public record Division
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Code { get; set; }
    //    public string Description { get; set; }
    //    public string Alias { get; set; }
    //    public int EntityId { get; set; }
    //    public Entity Entity { get; set; }
    //}

    public record DataItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public Division Division { get; set; }
    }

 



   

    public record SubAgentResponses
    {
        public string Id { get; set; }
        public string FullName { get; set; }

    }

    public record CustomerDocApiResponses<T>
    {
        public string ResponseMessage { get; set; }
        public string ResponseCode { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int Status { get; set; }
        public List<T> Data { get; set; }
        public List<string> Errors { get; set; }
    }
    public record CustomerApiResponses
    {
        public string ResponseMessage { get; set; }
        public string ResponseCode { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int Status { get; set; }
        public string Data { get; set; }
        public List<string> Errors { get; set; }
    }
    public record CustomerDocs
    {
        public string DocumentType { get; set; }
        public string DocumentName { get; set; }
        public int CustomerDocumentId { get; set; }
    }
    public record CustomerDocsDownload
    {
        public string FilePath { get; set; }
    }


    public class SubAdminApiResponse<T>
    {
        public List<T> Payload { get; set; }
        public int TotalCount { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public List<string> Errors { get; set; }
        public bool HasErrors { get; set; }
    }
    public class SubAgentPayload
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }  
    }
    public class Division
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class SbuPayload
    {
        public int Id { get; set; }
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public List<string> Users { get; set; }
    }
    public class SubApiResponses<T>
    {
        public T Payload { get; set; }
        public int TotalCount { get; set; }
        public string ResponseCode { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public List<string> Errors { get; set; }
        public bool HasErrors { get; set; }
    }
    public class UserPayload
    {
        public string Id { get; set; } 
        public string Image { get; set; } 
        public string FullName { get; set; } 
        public string PhoneNumber { get; set; } 
        public string Email { get; set; } 
        public string LastName { get; set; } 
        public string FirstName { get; set; } 
        public bool IsDeactivated { get; set; } 
        public string DeactivationReason { get; set; } 
        public int StructuralBusinessUnitId { get; set; } 
        public string StructuralBusinessUnit { get; set; } 
    }
    public record AgentResponse
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
    }
    public class SubAgentAdminApiResponse<T>
    {
        public T Payload { get; set; }
        public int TotalCount { get; set; }
        public int? ResponseCode { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public List<string> Errors { get; set; }
        public bool HasErrors { get; set; }
    }

   

   



}


