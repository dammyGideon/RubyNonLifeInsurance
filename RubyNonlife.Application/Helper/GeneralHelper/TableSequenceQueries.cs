using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public class TableSequenceQueries
    {
        public const string NON_LIFE_PRODUCT_CODE = "Select NEXT VALUE FOR dbo.NonLifeProductSequence";
        public const string QUOTATION_CODE = "Select NEXT VALUE FOR dbo.QuotationCodeSequence";
        public const string PolicyBooking_CODE = "Select NEXT VALUE FOR dbo.PolicyCodeSequence";
    }
}

