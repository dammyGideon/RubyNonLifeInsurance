using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Booking
{
    public record SbuDetailResponse
    {
        public int PolicyId {  get; set; }
        public string Comments { get; init; }
        public string Location { get; init; }
        public List<SubResponse> Sub { get; init; }
    }

    public record SubResponse
    {
        public int SubId { get; init; }
        public string Name { get; init; }
        public decimal SharingPercentage { get; init; }
        public List<ParticipantResponse> Participants { get; init; }
    }

    public record ParticipantResponse
    {
        public Guid ParticipantsId { get; init; }
        public string Name { get; init; }
        public decimal SharingPercentage { get; init; }
        public List<SubAgentResponse> SubAgents { get; init; }
    }

    public record SubAgentResponse
    {
        public int SubAgentId { get; init; }
        public string Name { get; init; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public decimal SharingPercentage { get; set; }
    }

}


