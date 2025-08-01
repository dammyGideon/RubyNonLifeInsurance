using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Dtos.Requests.WorkFlowRequest;
using RubyNonlife.Application.Helper.UtitlityModel;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Domain.Models.ApprovalWorks;
using RubyNonlife.Application.Utitlies;
using RubyNonlife.Application.Helper.GeneralHelper;


namespace RubyNonlife.Application.Implementations
{
    public class WorkflowEmailService : BaseEmailService,IWorkflowEmailService
    {
        private readonly INotificationService _notificationService;
        private readonly IConfiguration _configurtion;
        private readonly IWebHostEnvironment _environment;
        private readonly ConfigModels _options;

        public WorkflowEmailService(INotificationService notificationService, IConfiguration configuration, 
            IWebHostEnvironment environment, IOptions<ConfigModels> options)
        {
            _notificationService = notificationService;
            _configurtion = configuration;
            _environment = environment;
            _options = options.Value;
        }

        public async Task<RequestExecutionStatus> WorkflowApproved(List<string> emails, Workflow workflow)
        {
            string emailBody = await GetTemplateContent(EmailFilesDefinition.WORKFLOW_EMAIL_TEMPLATE, _environment.ContentRootPath);
            emailBody = emailBody.Replace("{Salutation}", "Team");
            emailBody = emailBody.Replace("{Body}", _options.WorkflowEmailTemplate.ApprovedEmail);

            var request = new NewMailSenderRequest
            {
                EmailBody = emailBody,
                EmailSender = _options.EmailSender,
                EmailSubject = _options.WorkflowEmailTemplate.ApprovedEmailSubject,
                EmailReciever = emails
            };
            await _notificationService.SendEmailWithApi(request);
            return RequestExecutionStatus.Successful;
        }

        public async Task<RequestExecutionStatus> WorkflowDeclined(List<string> emails, Workflow workflow)
        {
            string emailBody = await GetTemplateContent(EmailFilesDefinition.WORKFLOW_EMAIL_TEMPLATE, _environment.ContentRootPath);
            emailBody = emailBody.Replace("{Salutation}", "Team");
            emailBody = emailBody.Replace("{Body}", _options.WorkflowEmailTemplate.DeclinedEmail);

            var request = new NewMailSenderRequest
            {
                EmailBody = emailBody,
                EmailSender = _options.EmailSender,
                EmailSubject = _options.WorkflowEmailTemplate.DeclinedEmailSubject,
                EmailReciever = emails
            };
            await _notificationService.SendEmailWithApi(request);
            return RequestExecutionStatus.Successful;
        }

        public async Task<RequestExecutionStatus> WorkflowFinalApproval(List<string> emails, Workflow workflow)
        {
            string emailBody = await GetTemplateContent(EmailFilesDefinition.WORKFLOW_EMAIL_TEMPLATE, _environment.ContentRootPath);
            emailBody = emailBody.Replace("{Salutation}", "Team");
            emailBody = emailBody.Replace("{Body}", _options.WorkflowEmailTemplate.FinalApprovalEmail);

            var request = new NewMailSenderRequest
            {
                EmailBody = emailBody,
                EmailSender = _options.EmailSender,
                EmailSubject = _options.WorkflowEmailTemplate.FinalApprovalEmailSubject,
                EmailReciever = emails
            };
            await _notificationService.SendEmailWithApi(request);
            return RequestExecutionStatus.Successful;
        }

        public async Task<RequestExecutionStatus> WorkflowLogged(List<string> emails, Workflow workflow)
        {
            string emailBody = await GetTemplateContent(EmailFilesDefinition.WORKFLOW_EMAIL_TEMPLATE, _environment.ContentRootPath);
            emailBody = emailBody.Replace("{Salutation}", "Team");
            emailBody = emailBody.Replace("{Body}", _options.WorkflowEmailTemplate.LoggedEmail);

            var request = new NewMailSenderRequest
            {
                EmailBody = emailBody,
                EmailSender = _options.EmailSender,
                EmailSubject = _options.WorkflowEmailTemplate.LoggedEmailSubject,
                EmailReciever = emails
            };
            await _notificationService.SendEmailWithApi(request);
            return RequestExecutionStatus.Successful;
        }

        public async Task<RequestExecutionStatus> WorkflowReminder(List<string> emails, Workflow workflow)
        {
            string emailBody = await GetTemplateContent(EmailFilesDefinition.WORKFLOW_EMAIL_TEMPLATE, _environment.ContentRootPath);
            emailBody = emailBody.Replace("{Salutation}", "Team");
            emailBody = emailBody.Replace("{Body}", _options.WorkflowEmailTemplate.ReminderEmail);

            var request = new NewMailSenderRequest
            {
                EmailBody = emailBody,
                EmailSender = _options.EmailSender,
                EmailSubject = _options.WorkflowEmailTemplate.ReminderEmailSubject,
                EmailReciever = emails
            };
            await _notificationService.SendEmailWithApi(request);
            return RequestExecutionStatus.Successful;
        }
    }
}
