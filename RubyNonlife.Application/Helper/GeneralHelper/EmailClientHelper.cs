using Microsoft.Extensions.Configuration;
using MimeKit;
using Newtonsoft.Json;
using RubyNonlife.Application.Dtos.Requests.WorkFlowRequest;
using System.Net.Mail;
using System.Text;
using MailKit.Net.Smtp;





namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public class EmailClientHelper
    {
       
            private readonly IConfiguration _configuration;

            #region Email Configuration Variables
            private readonly string host;
            private readonly int port;
            private readonly bool useSsl;
            private readonly string userName;
            private readonly string password;
            private readonly string fromEmail;
            private readonly string senderName;
            #endregion

            public EmailClientHelper(IConfiguration configuration)
            {
                _configuration = configuration;

                #region Email Configuration Values
                host = _configuration.GetSection("NotificationConfiguration:EmailSettings:SmtpHost").Value;
                port = Convert.ToInt32(_configuration.GetSection("NotificationConfiguration:EmailSettings:SmtpPort").Value);
                useSsl = Convert.ToBoolean(_configuration.GetSection("NotificationConfiguration:EmailSettings:SmtpEnableSSL").Value);
                userName = _configuration.GetSection("NotificationConfiguration:EmailSettings:SmtpUser").Value;
                password = _configuration.GetSection("NotificationConfiguration:EmailSettings:SmtpPassword").Value;
                fromEmail = _configuration.GetSection("NotificationConfiguration:EmailSettings:FromMail").Value;
                senderName = _configuration.GetSection("NotificationConfiguration:EmailSettings:DisplayName").Value;
                #endregion
            }

            public async Task SendEmailAsync(MailRequest request)
            {
                if (!string.IsNullOrEmpty(request.Body) && !string.IsNullOrEmpty(request.Subject) && request.Recipient.Count > 0)
                {
                    var mailMessage = new MimeMessage();
                    mailMessage.From.Add(new MailboxAddress(senderName, fromEmail));

                    for (int i = 0; i < request.Recipient.Count; i++)
                    {
                        mailMessage.To.Add(new MailboxAddress(request.Recipient[i]));
                    }

                    if (request?.CC != null && request.CC.Count > 0)
                    {
                        for (int i = 0; i < request.CC.Count; i++)
                        {
                            mailMessage.To.Add(new MailboxAddress(request.CC[i]));
                        }
                    }

                    if (request?.BCC != null && request.BCC.Count > 0)
                    {
                        for (int i = 0; i < request.BCC.Count; i++)
                        {
                            mailMessage.To.Add(new MailboxAddress(request.BCC[i]));
                        }
                    }

                    mailMessage.Subject = request.Subject;
                    mailMessage.Importance = MessageImportance.High;
                    mailMessage.Priority = MessagePriority.Urgent;

                    if (request.IsHtmlBody)
                    {
                        BodyBuilder builder = new()
                        {
                            HtmlBody = request.Body
                        };

                        if (request.Attachments != null)
                        {
                            byte[] fileBytes;
                            foreach (var file in request.Attachments)
                            {
                                if (file.Length > 0)
                                {
                                    using (var ms = new MemoryStream())
                                    {
                                        file.CopyTo(ms);
                                        fileBytes = ms.ToArray();
                                    }
                                    builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                                }
                            }
                        }
                        mailMessage.Body = builder.ToMessageBody();
                    }
                    else
                    {
                        mailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
                        {
                            Text = request.Body
                        };
                    }

                using var smtpClient = new MailKit.Net.Smtp.SmtpClient();
                smtpClient.Connect(host, port, useSsl);
                    smtpClient.Authenticate(userName, password);
                    await smtpClient.SendAsync(mailMessage);
                    smtpClient.Disconnect(true);
                }
            }
            public async Task SendEmail(MailSenderRequest request)
            {
                if (!string.IsNullOrEmpty(request.EmailBody) && !string.IsNullOrEmpty(request.EmailSubject) && !string.IsNullOrEmpty(request.EmailReciever))
                {
                    var client = new HttpClient();
                    var response = await client.PostAsync("http://172.20.5.238/MailSender365/api/mails/sendmail365", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
                }
            }

        }
    
}
