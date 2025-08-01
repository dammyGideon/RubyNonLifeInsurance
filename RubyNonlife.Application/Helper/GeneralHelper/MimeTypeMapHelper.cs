using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public static class MimeTypeMapHelper
    {
        private static readonly Dictionary<string, string> MimeTypeMappings = new()
    {
        { ".jpg", "image/jpeg" },
        { ".jpeg", "image/jpeg" },
        { ".png", "image/png" },
        { ".gif", "image/gif" },
        { ".pdf", "application/pdf" },
        { ".doc", "application/msword" },
        { ".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
        // Add more mappings as needed
    };

        public static string GetMimeType(string extension)
        {
            if (MimeTypeMappings.TryGetValue(extension.ToLower(), out string mimeType))
            {
                return mimeType;
            }
            return "application/octet-stream"; // Default for unknown types
        }
    }

}
