using System;
using System.IO;
using System.Reflection;
using Sweaj.Serialization.Api.Models;

namespace Sweaj.Serialization.Api.Services
{
    public class RandomVideoGenerator
    {
        private static Random random = new Random();
        private static string[] categories;
        private static string[] descriptions;
        private static string[] tags;
        private static string[] titles;

        static RandomVideoGenerator()
        {
            categories = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources", "categories.txt"));
            descriptions = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources", "descriptions.txt"));
            tags = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources", "tags.txt"));
            titles = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources", "titles.txt"));
        }

        public static VideoMetadata[] CreateRandomVideo(int numberOfVideos = 1)
        {
            var videos = new VideoMetadata[numberOfVideos];

            for (int i = 0; i < numberOfVideos; i++)
            {
                var videoMetadata = new VideoMetadata()
                {
                    Id = Guid.NewGuid(),
                    AllowEmbedding = random.Next(2) == 0,
                    IsAgeRestricted = random.Next(2) == 0,
                    IsCommentsAllowed = random.Next(2) == 0,
                    IsForKids = random.Next(2) == 0,
                    Category = categories[random.Next(categories.Length)],
                    UploadDate = DateTime.Now.AddDays(-random.Next(10)),
                    ImageSeed = random.Next().ToString(),
                    IsMonetized = true,
                    Language = "English",
                    LicenseType = "Standard",
                    PlaylistId = Guid.Empty,
                    PublishDate = DateTime.Now.AddDays(random.Next(10)),
                    ShortDescription = descriptions[random.Next(descriptions.Length)],
                    Tags = tags[random.Next(tags.Length)],
                    Thumbnail = null,
                    Title = titles[random.Next(titles.Length)],
                    ViewCount = random.Next(),
                    Visibility = random.Next(2) == 0 ? "Public" : "Private",
                };

                videoMetadata.RecordingDate = videoMetadata.UploadDate.AddDays(-random.Next(3));
                videos[i] = videoMetadata;
            }

            return videos;
        }
    }
}
