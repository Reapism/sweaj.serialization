using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sweaj.Serialization.Data;
using Sweaj.Serialization.Data.Models;

namespace Sweaj.Seriailzation.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UploadVideoController : ControllerBase
    {
        private readonly VideoContext context;

        public UploadVideoController(VideoContext context)
        {
            this.context = context;
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
        public async Task<ActionResult> Post(VideoMetadata model)
        {
            if (model is null)
            {
                return NoContent();
            }
            
            await context.VideoMetadatas.AddAsync(model);
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
