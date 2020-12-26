using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sweaj.Serialization.Data.Models;

namespace Sweaj.Seriailzation.WebApi.Services
{
    public class VideoDefaulterService
    {
        private static readonly Random Random = new Random();

        public void ApplyVideoDefaults(List<VideoMetadata> models)
        {
            // For every model, apply defaults to properties conditionally.
            models.ForEach(e =>
            {
                if (e.Id == Guid.Empty)
                    e.Id = Guid.NewGuid();

                if (string.IsNullOrEmpty(e.Language))
                    e.Language = "English";

                if (string.IsNullOrEmpty(e.ImageSeed))
                    e.ImageSeed = Random.Next().ToString();

                e.UploadDate = DateTime.Now;
            });
        }
    }
}
