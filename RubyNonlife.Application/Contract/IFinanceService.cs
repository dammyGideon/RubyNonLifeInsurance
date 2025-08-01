using RubyNonlife.Application.Dtos.Requests.FinanceRequest;
using RubyNonlife.Application.Dtos.Responses.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Contract
{
    public interface IFinanceService
    {
        Task<FinanceBaseResponse<AccountResponse>> CreateLedger(AccountRequestDto request);
    }
}
