using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Utitlies
{
    public class EmailSubjectReader
    {
        public static string GetEmailSubject(string key, string fileName, string rootDirectory)
        {
            if (string.IsNullOrWhiteSpace(key))
                return string.Empty;

            string filePath = Path.Combine(rootDirectory, ResourceFilesDefinition.ROOT_RESOURCE_DIRECTORY, ResourceFilesDefinition.EMAIL_SUBJECTS_DIRECTORY, fileName);
            using StreamReader file = File.OpenText(filePath);
            using JsonTextReader reader = new(file);
            JObject jObject = (JObject)JToken.ReadFrom(reader);
            if (jObject == null)
                return string.Empty;

            JObject response = jObject["Subjects"] as JObject;
            string value = response.Value<string>(key);
            return value;
        }
    }
}
