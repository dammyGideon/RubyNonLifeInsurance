using Microsoft.Extensions.Configuration;
using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Dtos.Requests.WorkFlowRequest;
using RubyNonlife.Application.Helper.GeneralHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Implementations
{
    public class NotificationService : INotificationService
    {
        private readonly IConfiguration _configuration;

        public NotificationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Sends email to respective recipients from the application. The application is the sender of this email and not any personal entity. 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task SendEmailAsync(MailRequest request)
        {
            EmailClientHelper emailClient = new(_configuration);
            await emailClient.SendEmailAsync(request);
        }
        public async Task SendEmailWithApi(MailSenderRequest request)
        {
            EmailClientHelper emailClient = new(_configuration);
            request.EmailSender = _configuration.GetSection("EmailSender").Value;
            await emailClient.SendEmail(request);
        }

        public async Task SendEmailWithApi(NewMailSenderRequest request)
        {
            EmailClientHelper emailClient = new(_configuration);
            request.EmailSender = _configuration.GetSection("EmailSender").Value;
            var emailRequest = new MailSenderRequest
            {
                EmailBcc = request.EmailBcc,
                EmailSubject = request.EmailSubject,
                EmailAttachments = request.EmailAttachments,
                EmailBody = request.EmailBody,
                EmailCc = request.EmailCc,
                EmailSender = request.EmailSender,
            };
            foreach (var item in request.EmailReciever)
            {
                emailRequest.EmailReciever = item;
                await emailClient.SendEmail(emailRequest);
            }
        }

        /// <summary>
        /// Not yet implemented
        /// </summary>
        /// <returns></returns>
    }
}
