using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models
{
    public class AuditLog
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public DateTime ActionDate { get; set; }
        public string Action {  get; set; }
        public string EntityName { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }

    }
}
