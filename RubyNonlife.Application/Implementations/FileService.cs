using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using RubyNonlife.Application.Dtos.Responses;
using RubyNonlife.Application.Helper.GeneralHelper;
using RubyNonlife.Domain.Enums;
using RubyNonlife.Infrastructure.Contract;
using System;
using System.IO;
using System.Threading.Tasks;

namespace RubyNonlife.Infrastructure.Implementations
{
    public class FileService : IFileService
    {
        private readonly IConfiguration _configuration;
        public string BaseUrl { get; set; }
        public string RootDirectory { get; set; }

        public FileService(IConfiguration configuration)
        {
            _configuration = configuration;
            BaseUrl = _configuration.GetSection("AppSettings:FileServerConfiguration:BaseUrl").Value.ToString();
            RootDirectory = _configuration.GetSection("AppSettings:FileServerConfiguration:RootDirectory").Value.ToString();
        }

        public async Task<FileUpload> UploadFile(IFormFile file)
        {
            if (file == null || file.Length <= 0)
            {
                return new FileUpload()
                {
                    Status = FileUploadStatus.Failed,
                    Message = "Kindly upload a valid file.",
                };
            }

            if (string.IsNullOrEmpty(BaseUrl) || string.IsNullOrEmpty(RootDirectory))
            {
                return new FileUpload()
                {
                    Status = FileUploadStatus.Failed,
                    Message = "File server configuration is missing.",
                };
            }

            // Combine BaseUrl and RootDirectory to get the absolute path
            string uploadDirectory = Path.Combine(BaseUrl, RootDirectory);
            string extension = Path.GetExtension(file.FileName);
            string mimeType = MimeTypeMapHelper.GetMimeType(extension);
            string uniqueFileName = $"{DateTime.UtcNow.Ticks}{extension}";
            string filePath = Path.Combine(uploadDirectory, uniqueFileName);

            try
            {
                // Ensure the directory exists on the server
                Directory.CreateDirectory(uploadDirectory);

                // Save the file to the server
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return new FileUpload()
                {
                    Status = FileUploadStatus.Successful,
                    Document = new FileDocument
                    {
                        DocumentName = uniqueFileName,
                        MimeType = mimeType
                    }
                };
            }
            catch (Exception ex)
            {
                return new FileUpload()
                {
                    Status = FileUploadStatus.Failed,
                    Message = $"File upload failed: {ex.Message}",
                };
            }
        }

        public async Task<BaseResponse<FileDownloadResponse>> GetFile(string fileName)
        {
            var response = new BaseResponse<FileDownloadResponse>();

            if (string.IsNullOrEmpty(fileName))
            {
                response.Success = false;
                response.ResponseMessage = "File name is required.";
                response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return response;
            }

            if (string.IsNullOrEmpty(BaseUrl) || string.IsNullOrEmpty(RootDirectory))
            {
                response.Success = false;
                response.ResponseMessage = "File server configuration is missing.";
                response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                return response;
            }

            // Combine BaseUrl and RootDirectory to form the absolute file path
            string serverDirectory = Path.Combine(BaseUrl, RootDirectory);
            string filePath = Path.Combine(serverDirectory, fileName);

            try
            {
                if (!File.Exists(filePath))
                {
                    response.Success = false;
                    response.ResponseMessage = "File not found.";
                    response.StatusCode = System.Net.HttpStatusCode.NotFound;
                    return response;
                }

                // Read file bytes from the server directory
                var fileBytes = await File.ReadAllBytesAsync(filePath);
                string mimeType = MimeTypeMapHelper.GetMimeType(Path.GetExtension(fileName));

                // Convert file bytes to Base64 string
                string base64Content = Convert.ToBase64String(fileBytes);

                var fileDownload = new FileDownloadResponse
                {
                    FileContentBase64 = base64Content,
                    FileName = fileName,
                    MimeType = mimeType
                };

                response.Success = true;
                response.ResponseMessage = "File successfully retrieved.";
                response.Data = fileDownload;
                response.StatusCode = System.Net.HttpStatusCode.OK;

                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ResponseMessage = $"File retrieval failed: {ex.Message}";
                response.StatusCode = System.Net.HttpStatusCode.InternalServerError;
                return response;
            }
        }



        public string GenerateExposedPath(string filePath)
        {
            // Remove the root directory part from the full file path
            if (filePath.StartsWith(RootDirectory))
            {
                filePath = filePath.Replace(RootDirectory, "").TrimStart('\\', '/');
            }

            // Ensure BaseUrl ends with a slash for proper URL construction
            if (!BaseUrl.EndsWith("/"))
            {
                BaseUrl += "/";
            }

            return $"{BaseUrl}{filePath.Replace("\\", "/")}"; // Replace backslashes with forward slashes for URLs
        }


    }

}
