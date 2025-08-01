using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public static class NullValueHandler
    {
        public static string GetOrDefault(string value)
        {
            return string.IsNullOrEmpty(value) ? "Unknown" : value;
        }


    }
}
