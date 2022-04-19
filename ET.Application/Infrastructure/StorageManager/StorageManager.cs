using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

// Namespace for Azure Configuration Manager
// Namespace for Storage Client Library

namespace ET.Application.Infrastructure.StorageManager
{
    public class StorageManager : IStorageManager
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly CloudStorageAccount _storageAccount;
        private CloudBlobClient cloudBlobClient;
        private CloudBlobContainer cloudBlobContainer;


        private bool _uploadSuccess = false;

        public StorageManager(IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _storageAccount = CloudStorageAccount.Parse(_configuration["StorageConnectionString"]);
            cloudBlobClient = _storageAccount.CreateCloudBlobClient();
            cloudBlobContainer = cloudBlobClient.GetContainerReference(_httpContextAccessor.HttpContext.User.Identity.Name.ToLower());
        }

        public async Task<bool> Upload(IFormFile formFile, string fileType)
        {
            using (var stream = formFile.OpenReadStream())
            {
                _uploadSuccess = await UploadToBlob(formFile.FileName, fileType, null, stream);
            }

            return _uploadSuccess;
        }

        public async Task<List<string>> GetFiles()
        {
            List<string> filesUrlList = new List<string>();
            BlobResultSegment blobs = null;

            blobs = cloudBlobContainer.ListBlobsSegmentedAsync(null).Result;
            foreach (var blob in blobs.Results)
            {
                filesUrlList.Add(blob.Uri.ToString());
            }

            return filesUrlList;
        }
        public async Task<bool> UploadToBlob(string filename, string fileType, byte[] imageBuffer = null, Stream stream = null)
        {
            await cloudBlobContainer.CreateIfNotExistsAsync();

            filename = $"{fileType}-{filename}";

            BlobContainerPermissions permissions = new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            };
            await cloudBlobContainer.SetPermissionsAsync(permissions);


            CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(filename);

            if (imageBuffer != null)
            {
                // OPTION A: use imageBuffer (converted from memory stream)
                await cloudBlockBlob.UploadFromByteArrayAsync(imageBuffer, 0, imageBuffer.Length);
            }
            else if (stream != null)
            {
                // OPTION B: pass in memory stream directly
                await cloudBlockBlob.UploadFromStreamAsync(stream);
            }
            else
            {
                return false;
            }

            return true;
        }

    }
}
