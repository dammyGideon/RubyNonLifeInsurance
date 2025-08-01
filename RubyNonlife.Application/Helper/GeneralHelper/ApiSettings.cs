using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public class ApiSettings
    {
        public AdminUrlConfig AdminUrl { get; set; }
        public AdminAuthOptions AdminAuth { get; set; }
        public FinanceAuthOptions FinanceAuth { get; set; }
        public FinanceUrlConfig FinanceBaseUrl { get; set; }
    }


    public class AdminUrlConfig
    {
        public string BaseUrl { get; set; }
        public int LineOfBusinessId { get; set; }
       
    }
    public class FinanceUrlConfig
    {
        public string BaseUrl { get; set; }
        public string VoucherBaseUrl { get; set; }
    }

    public class AdminAuthOptions
    {
        public string TokenUrl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class FinanceAuthOptions
    {
        public string AdminUrl { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
