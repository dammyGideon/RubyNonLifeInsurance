using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public static class CoverStatusConstants
    {
        private const string Compulsory = "Compulsory";
        private const string Optional = "Optional";
        private const string Locked = "Locked";
        private const string Open = "Open";



        public static string MapCoverStatus(string coverStatus)
        {
            return coverStatus == Compulsory
                ? Locked
                : Open;
        }
    }



}
