using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using RubyNonlife.Application.Contract;
using RubyNonlife.Application.Dtos.Requests.WorkFlowRequest;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Application.Utitlies;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Domain.Models.ProductEntities;


namespace RubyNonlife.Application.EmailServices
{
    public class ProductServiceEmail
    {
        
            private readonly INotificationService _notificationService;
            private readonly IConfiguration _configurtion;
            private readonly IWebHostEnvironment _environment;

            public ProductServiceEmail(INotificationService notificationService, IConfiguration configuration, IWebHostEnvironment environment)
            {
                _notificationService = notificationService;
                _configurtion = configuration;
                _environment = environment;
            }


            public async Task<RequestExecutionStatus> SendProductSetupEmail(Product product, string template, string subjectPath, string emailRecipient, string team)
            {
                string subject = EmailSubjectReader.GetEmailSubject(subjectPath, ResourceFilesDefinition.PRODUCT_SETUP_SUBJECTS, _environment.ContentRootPath);
                string emailBody = await GetTemplateContent(template, _environment.ContentRootPath);

                // replacing placeholders in the email template with dynamic data.
                emailBody = emailBody.Replace("{Team}", team);
                emailBody = emailBody.Replace("{ProductName}", product.Name);
                emailBody = emailBody.Replace("{ProductCode}", product.Code);
                emailBody = emailBody.Replace("{ProductVersion}",  "0.0");

                MailSenderRequest mailRequest = new()
                {
                    EmailSubject = subject,
                    EmailBody = emailBody,
                    EmailReciever = emailRecipient
                };
                List<Emailattachment> files = new();
                mailRequest.EmailAttachments = files.ToArray();
                await _notificationService.SendEmailWithApi(mailRequest);
                //Delete the files from server
                return RequestExecutionStatus.Successful;
            }

            public async Task<RequestExecutionStatus> ProductRejectionEmail(Product product, string template, string subjectPath, string emailRecipient, string team, string comment)
            {
                string subject = EmailSubjectReader.GetEmailSubject(subjectPath, ResourceFilesDefinition.PRODUCT_SETUP_SUBJECTS, _environment.ContentRootPath);
                string emailBody = await GetTemplateContent(template, _environment.ContentRootPath);

                emailBody = emailBody.Replace("{Team}", team);
                emailBody = emailBody.Replace("{ProductName}", product.Name);
                emailBody = emailBody.Replace("{ProductCode}", product.Code);
                emailBody = emailBody.Replace("{Comment}", comment);
                emailBody = emailBody.Replace("{ProductVersion}", "0.0");

                MailSenderRequest mailRequest = new()
                {
                    EmailSubject = subject,
                    EmailBody = emailBody,
                    EmailReciever = emailRecipient
                };
                List<Emailattachment> files = new();
                mailRequest.EmailAttachments = files.ToArray();
                await _notificationService.SendEmailWithApi(mailRequest);
                //Delete the files from server
                return RequestExecutionStatus.Successful;
            }



        private async Task<string> GetTemplateContent(string templateName, string contentRoot)
        {
            string templatePath = Path.Combine(contentRoot, ResourceFilesDefinition.ROOT_RESOURCE_DIRECTORY, EmailFilesDefinition.ROOT_TEMPLATE_DIRECTORY, templateName);
            string emailContent = string.Empty;
            using (StreamReader reader = new(templatePath))
            {
                emailContent = await reader.ReadToEndAsync();
            }

            return emailContent;
        }

    }
  }

