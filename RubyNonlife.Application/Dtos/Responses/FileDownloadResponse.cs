

using RubyNonlife.Domain.Enums;

namespace RubyNonlife.Application.Dtos.Responses
{
    public class FileDownloadResponse
    {
        public FileUploadStatus Status { get; set; }
        public string Message { get; set; }
        public byte[] FileContent { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public string FileContentBase64 { get; set; }
    }

}


