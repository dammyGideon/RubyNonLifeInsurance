using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.FinanceRequest
{
    public class AccountRequestDto
    {
        public string Name { get; set; }
        public string Remark { get; set; }
        public int CurrencyId { get; set; }
        public string SetupName { get; set; }
        public int ControlAccountId { get; set; }
    }
}
