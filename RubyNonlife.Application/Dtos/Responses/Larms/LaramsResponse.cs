using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Larms
{


    public class LaramsResponse<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public object Errors { get; set; }
        public object ValidationErrors { get; set; }
        public PageData PageData { get; set; }
    }

    public class PageData
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }
    }


    public class LeadDto
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string LeadNumber { get; set; }
        public string Name { get; set; }
        public string CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string FullAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePicture { get; set; }
        public string ReceivableLedger { get; set; }
        public string PayableLedger { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateAssigned { get; set; }
        public string Nin { get; set; }

    }



}

