using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.Larms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Contract
{
    public interface ILarmsService
    {
        Task<LaramsResponse<List<LeadDto>>> SearchLaramsLeadsAsync(string query);
       // Task<BaseResponse<LarmsResponse>> GetLeadByLeadId(Guid leadId);
    }
}

