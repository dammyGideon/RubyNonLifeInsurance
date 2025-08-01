using RubyNonlife.Application.Dtos.Requests.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.Booking
{
    public class VoucherDataResponse
    {
        public string ReceiptNumber { get; set; }
        public string Status { get; set; }
        public string TransactionDate { get; set; }
        public decimal AmountLeftOnReceipt { get; set; }
     
    }


    public class ApiResponse<T>
    {
        public string Code { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public List<T> Data { get; set; }
        public Metadata Metadata { get; set; }
    }




    public class Currency
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class Metadata
    {
        public object Pagination { get; set; }
    }

}


