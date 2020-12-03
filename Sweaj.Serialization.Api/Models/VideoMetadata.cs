using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Sweaj.Serialization.Data.Models
{
    public class VideoMetadata
    {
        public Guid Id { get; set; }
        public Guid PlaylistId { get; set; }
        [NotMapped]
        public Guid[] RecommendedVideosById { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string ShortDescription { get; set; }
        [JsonPropertyName("tags")]
        public string Tags { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("lang")]
        public string Language { get; set; }
        [JsonPropertyName("license")]
        public string LicenseType { get; set; }
        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }
        public string ImageSeed { get; set; }

        [JsonPropertyName("isAgeRestricted")]
        public bool IsAgeRestricted { get; set; }
        [JsonPropertyName("isForKids")]
        public bool IsForKids { get; set; }
        [JsonPropertyName("isMonetized")]
        public bool IsMonetized { get; set; }
        [JsonPropertyName("allowComments")]
        public bool IsCommentsAllowed { get; set; }
        [JsonPropertyName("allowEmbedding")]

        public bool AllowEmbedding { get; set; }
        public byte[] Thumbnail { get; set; }
        public long ViewCount { get; set; }

        [JsonPropertyName("recordedDate")]
        public DateTime RecordingDate { get; set; }
        [JsonPropertyName("uploadDate")]
        public DateTime UploadDate { get; set; }
        [JsonPropertyName("publishDate")]
        public DateTime PublishDate { get; set; }
    }
}
