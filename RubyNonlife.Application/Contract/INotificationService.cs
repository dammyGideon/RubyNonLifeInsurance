using RubyNonlife.Application.Dtos.Requests.WorkFlowRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Contract
{
    public interface INotificationService
    {
        Task SendEmailAsync(MailRequest request);
        Task SendEmailWithApi(MailSenderRequest request);
        Task SendEmailWithApi(NewMailSenderRequest request);
    }
}
