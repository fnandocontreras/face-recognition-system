using FaceIdentityService.Services;
using FaceManagement.Server.Context;
using FaceManagement.Shared.Models;
using FaceManagement.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FaceManagement.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FaceController : ControllerBase
    {
        FaceContext _dbContext;
        TensorflowServiceClient _tfService;
        public FaceController(FaceContext dbContext, TensorflowServiceClient tfService)
        {
            _dbContext = dbContext;
            _tfService = tfService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Face>>> List()
        {
            return await _dbContext.Faces.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post(FaceViewModel face)
        {
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            var image = face.Image.output.image;
            if (string.IsNullOrEmpty(face.Image.output.image))
                return BadRequest("Image cannot be empty");
            
            string imgData = image.Remove(0, image.IndexOf("base64,") + 7);
            byte[] imgBytes = Convert.FromBase64String(imgData);
            using (Image loadedImage = Image.Load(imgBytes))
            {
                loadedImage.Mutate(x => {
                    x.Resize(Contracts.ImageSize.Width, Contracts.ImageSize.Height);
                });
                await loadedImage.SaveAsJpegAsync(Path.Combine(Contracts.ImagesFolderPath, fileName));
            }

            var predictionResult = await _tfService.GetFaceEncoding(imgData);

            await _dbContext.Faces.AddAsync(new Face {
                FirstName = face.FirstName,
                LastName = face.LastName,
                FileName = fileName,
                Encoding = predictionResult.Encoding
            });

            await _dbContext.SaveChangesAsync();

            return Ok();
        }

    }
}
