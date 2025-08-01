using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Responses.ProductSetup
{
    public class AccountResponse
    {
        //public int Id { get; set; }
        //public int ControlAccountId { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        //public string Alias { get; set; }
        //public string Status { get; set; }
        //public string Description { get; set; }
    }

    public class AccountClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ControlAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Data
    {
        public AccountClass AccountClass { get; set; }
        public ControlAccount ControlAccount { get; set; }
        public List<AccountResponse> Accounts { get; set; }
    }

    public class Root
    {
        public string Code { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public Data Data { get; set; }
        public Metadata Metadata { get; set; }
    }

    public class Metadata
    {
        public object Pagination { get; set; }
    }



    public class FinanceApiResponse
    {
        public string code { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }


    public class FinanceApiBaseResponse
    {
        public string Code { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public FinanceApiData Data { get; set; }
        public object Metadata { get; set; }
    }

    public class FinanceApiData
    {
        public List<FinanceTransaction> Transactions { get; set; }
        public DateTime DateCommitted { get; set; }
        public string Status { get; set; }
        public string TransactionSource { get; set; }
        public string TransactionReference { get; set; }
    }

    public class FinanceTransaction
    {
        public string TransactionType { get; set; }
        public string BatchReference { get; set; }
        public string VoucherNumber { get; set; }
    }


}
