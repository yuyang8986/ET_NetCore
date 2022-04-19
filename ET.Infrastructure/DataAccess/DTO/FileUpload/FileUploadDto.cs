using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace ET.Infrastructure.DataAccess.DTO.FileUpload
{
    public class FileUploadDto
    {
        public IFormFile File { get; set; }
        public string FileType { get; set; }
    }
}
