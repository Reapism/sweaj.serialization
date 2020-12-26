using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sweaj.Seriailzation.WebApi.Services;
using Sweaj.Serialization.Data;
using Sweaj.Serialization.Data.Models;

namespace Sweaj.Seriailzation.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadController : ControllerBase
    {

        private readonly VideoContext context;
        private readonly VideoDefaulterService videoDefaulterService;

        public UploadController(VideoContext context, VideoDefaulterService videoDefaulter)
        {
            this.context = context;
            this.videoDefaulterService = videoDefaulter;
        }

        [HttpGet]
        public async Task<ActionResult<VideoMetadata>> Get(Guid id)
        {
            // Get first model that fits the criteria or null asynchronously.
            var model = await context.VideoMetadatas.FirstOrDefaultAsync(e => e.Id == id);
            if (model is null)
            {
                return null;
            }

            return model;
        }

        // Create
        [HttpPost]
        public async Task<ActionResult> Post(VideoMetadata[] models)
        {
            // At this point, the models parameter was deserialized from UploadVideoDetails model (class), to the VideoMetadata data model (class).
            // This is the ASP.NET Web API framework automatically doing the deserialization for us and checking parameters, and method names.
            if (models is null || models.Length == 0)
            {
                return NoContent();
            }

            var modelsList = models.ToList();
            videoDefaulterService.ApplyVideoDefaults(modelsList);

            await context.VideoMetadatas.AddRangeAsync(modelsList);
            await context.SaveChangesAsync();

            return Ok();
        }

        // Update
        [HttpPut]
        public async Task<ActionResult> Put(Guid id, VideoMetadata metadata)
        {
            if (id != metadata.Id)
                return Problem("Cannot modify the video identifier.", null, (int)HttpStatusCode.Conflict, "Problem");

            var model = await context.VideoMetadatas.FirstOrDefaultAsync(e => e.Id == id);

            if (model is null)
                return NotFound();

            model = metadata;
            context.VideoMetadatas.Update(model);

            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Guid id)
        {
            var model = await context.VideoMetadatas.FirstOrDefaultAsync(e => e.Id == id);
            if (model is null)
                return NotFound();

            context.VideoMetadatas.Remove(model);

            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
