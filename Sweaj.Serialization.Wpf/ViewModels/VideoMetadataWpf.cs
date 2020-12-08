using System;
using System.Text.Json.Serialization;

namespace Sweaj.Serialization.Wpf.ViewModels
{
    // Client Model - Represents data thats input from our
    // upload video form.
    // We also take the liberty of using the same serialized
    // names for the sake of the demo, and reduce complexity. 
    public class VideoMetadataWpf
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Decription { get; set; }
        [JsonPropertyName("tags")]
        public string Tags { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("lang")]
        public string Language { get; set; }
        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }

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

        [JsonPropertyName("recordedDate")]
        public DateTime RecordingDate { get; set; }

    }
}