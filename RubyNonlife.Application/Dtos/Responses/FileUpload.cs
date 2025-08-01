

using RubyNonlife.Domain.Enums;

namespace RubyNonlife.Application.Dtos.Responses
{
    public class FileUpload
    {
        public FileDocument Document { get; set; }
        public FileUploadStatus Status { get; set; }
        public string Message { get; set; }
    }
}


