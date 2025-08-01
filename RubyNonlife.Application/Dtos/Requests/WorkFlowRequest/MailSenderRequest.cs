using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Dtos.Requests.WorkFlowRequest
{
    public class MailSenderRequest
    {
        public string EmailSender { get; set; }
        public string EmailReciever { get; set; }
        public string EmailBody { get; set; }
        public string EmailSubject { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public Emailattachment[] EmailAttachments { get; set; }
    }

    public class Emailattachment
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string EmailAttachment { get; set; }
    }

    public class NewMailSenderRequest
    {
        public string EmailSender { get; set; }
        public List<string> EmailReciever { get; set; }
        public string EmailBody { get; set; }
        public string EmailSubject { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public Emailattachment[] EmailAttachments { get; set; }
    }
}
