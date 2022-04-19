using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ET.Application.Infrastructure.StorageManager
{
    public interface IStorageManager
    {
        Task<bool> Upload(IFormFile formFile, string fileType);
        Task<bool> UploadToBlob(string filename, string fileType,byte[] imageBuffer = null, Stream stream = null);
        Task<List<string>> GetFiles();
    }
}