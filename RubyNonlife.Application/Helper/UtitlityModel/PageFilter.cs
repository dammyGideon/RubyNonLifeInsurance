using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.UtitlityModel
{
    public class PageFilter
    {
        public PageFilter()
        {
            PageNumber = 1;
            PageSize = 50;
        }

        public PageFilter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber > 0 ? pageNumber : 1;
            PageSize = pageSize <= 0 ? 50 : (pageSize > 50 ? 50 : pageSize);
        }

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
