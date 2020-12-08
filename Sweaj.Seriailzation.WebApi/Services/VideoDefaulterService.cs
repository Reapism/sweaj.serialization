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
            models.ForEach(e =>
            {
                if (e.Id == Guid.Empty)
                    e.Id = Guid.NewGuid();
                if (e.ViewCount != 0)
                    e.ViewCount = 0;

                if (e.ShortDescription.Length > 100)
                    e.ShortDescription.Trim().Substring(0, 100);

                e.Language = "English";
                e.PublishDate = DateTime.Now;
                e.UploadDate = DateTime.Now;
                e.ImageSeed = Random.Next().ToString();
            });
        }
    }
}
