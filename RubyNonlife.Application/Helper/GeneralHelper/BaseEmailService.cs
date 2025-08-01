using RubyNonlife.Application.Utitlies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public class BaseEmailService
    {
        public async Task<string> GetTemplateContent(string templateName, string contentRoot)
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
