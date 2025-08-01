using Microsoft.AspNetCore.Http;
using RubyNonlife.Application.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyNonlife.Infrastructure.Contract
{
    public interface IFileService
    {
        Task<FileUpload> UploadFile(IFormFile file);
        Task<BaseResponse<FileDownloadResponse>> GetFile(string fileName);
        string GenerateExposedPath(string fileName);
    }
}
