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
        private readonly VideoDefaulterService videoDefaulter;

        public UploadController(VideoContext context, VideoDefaulterService videoDefaulter)
        {
            this.context = context;
            this.videoDefaulter = videoDefaulter;
        }

        [HttpGet]
        public async Task<ActionResult<VideoMetadata>> Get(Guid id)
        {
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
            if (models is null || models.Length == 0)
            {
                return NoContent();
            }

            var modelsList = models.ToList();
            videoDefaulter.ApplyVideoDefaults(modelsList);

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
