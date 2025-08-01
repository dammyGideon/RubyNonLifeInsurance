using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.Booking
{
    public class SbuSharingRequest
    {
        public int PolicyId { get; set; }
        public string Comments { get; set; }
        public string Location { get; set; }
        public List<SbuDetailRequest> Sbus { get; set; }   
    }
}

public class SbuDetailRequest
{
    public string Name { get; set; }
    public int SubId { get; set; }
    public decimal SharingPercentage { get; set; }
    public List<SBUParticipants> Participants { get; set; }
}

public class SBUParticipants
{
    public string Name { get; set; }
    public Guid ParticipantsId { get; set; }
    public decimal SharingPercentage { get; set; }
    public List<SBUSubAgent> SBUSubAgents { get; set; }
}
public class SBUSubAgent
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber {  get; set; }
    public int SubAgentId { get; set; }
    public decimal SharingPercentage { get; set; }
}





public class DocumentationRequest
{
    public int policyId { get; set; }
    public string comment {  get; set; }
}
public class DocumentUploadsRequest
{
    public int policyId { get; set; }
    public int ProductDocumentId { get; set; }
    public IFormFile Document { get; set; }
}