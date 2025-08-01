using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Dtos.Responses.ProductSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Contract
{
    public interface IFinanceServiceIntegration
    {
        Task<BaseResponse<List<AccountResponse>>> FinanceAccountSetup(string searchParam, string searchKeyword = null);
        Task<FinanceApiBaseResponse> PostToFinanceSystemAsync(object financePayload);
    }
}
