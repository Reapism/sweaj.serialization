using System;
using Sweaj.Serialization.Api.Models;

namespace Sweaj.Serialization.Api.Services
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
