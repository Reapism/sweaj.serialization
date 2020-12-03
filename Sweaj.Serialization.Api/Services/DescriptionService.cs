using System;
using Sweaj.Serialization.Data.Models;

namespace Sweaj.Serialization.Data.Services
{
    public class DescriptionService
    {
        public string GetFullDescription(VideoMetadata videoMetadata)
        {
            return GetFullDescriptionByVideoId(videoMetadata.Id);
        }

        private string GetFullDescriptionByVideoId(Guid videoId)
        {
            return "This is the full description.";
        }
    }
}
