using System;
using System.Text.Json.Serialization;

namespace Sweaj.Serialization.Wpf.Models
{
    public class UploadVideoMetadata
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }
        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        [JsonPropertyName("isMonetized")]
        public bool IsMonetized { get; set; }
        [JsonPropertyName("isForChildren")]
        public bool IsForChildren { get; set; }
        [JsonPropertyName("isAgeRestricted")]
        public bool IsForMatureAudience { get; set; }
        [JsonPropertyName("allowComments")]
        public bool AllowComments { get; set; }
        [JsonPropertyName("allowEmbedding")]
        public bool AllowEmbedding { get; set; }

        [JsonPropertyName("recordedDate")]
        public DateTime RecordingDate { get; set; }
        [JsonPropertyName("uploadDate")]
        public DateTime UploadDate { get; set; }
    }
}
