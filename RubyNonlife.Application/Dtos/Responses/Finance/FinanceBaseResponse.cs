using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.Finance
{
    public class FinanceBaseResponse<T>
    {
        public string Code { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public Metadata Metadata { get; set; }
    }


    public class Metadata
    {
        public object Pagination { get; set; }
    }


    public class AccountResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
    }

}
