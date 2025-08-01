using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public class ValidationError
    {
        public ValidationError(string Name, string Description)
        {
            this.Description = Description;
            this.Name = Name;
        }
        public ValidationError()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
