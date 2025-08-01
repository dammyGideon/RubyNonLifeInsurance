using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Domain.Models
{
    public class AuditEntry(EntityEntry entry)
    {
        public EntityEntry Entry { get; set; }
        public string TableName { get; set; }
        public DateTime ActionDate { get; set; }
        public string UserId { get; set; }
        public string Action { get; set; }

        public Dictionary<string, object> OldValues { get; } = new Dictionary<string, object>();
        public Dictionary<string, object> NewValues { get; } = new Dictionary<string, object>();
        public Dictionary<string, object> KeyValues { get; } = new Dictionary<string, object>();
        public List<PropertyEntry> TemporaryProperties { get; } = new List<PropertyEntry>();

        public bool HasTemporaryProperties => TemporaryProperties.Any();


        public AuditLog ToAuditLog()
        {
            var auditLog = new AuditLog()
            {
                UserId = UserId,
                ActionDate = ActionDate,
                Action = Action,
                EntityName = TableName,
                OldValues = OldValues.Count == 0 ? null : JsonConvert.SerializeObject(OldValues),
                NewValues = NewValues.Count == 0 ? null : JsonConvert.SerializeObject(NewValues)
            };
            return auditLog;
        }

    }
}
