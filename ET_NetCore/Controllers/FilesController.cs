using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ET.Application.Infrastructure.StorageManager;
using ET.Infrastructure.DataAccess.DTO.FileUpload;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ET_NetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IStorageManager _storageManager;

        public FilesController(IStorageManager storageManager)
        {
            _storageManager = storageManager;
        }

        [HttpPost("UploadFile"), DisableRequestSizeLimit]
        public async Task<IActionResult> UploadFile([FromForm] FileUploadDto dto) //fileType in Core.Entities.Types
        {
            var result = await _storageManager.Upload(dto.File, dto.FileType);
            if (result) return Ok();
            return BadRequest();
        }

        [HttpGet("GetFile"), DisableRequestSizeLimit]
        public async Task<List<string>> GetFile()
        {
            var result = await _storageManager.GetFiles();
            if (result != null) return result;
            throw new NullReferenceException("No Files Found!");
        }
    }
}