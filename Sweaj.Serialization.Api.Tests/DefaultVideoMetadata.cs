using System;
using System.Collections.Generic;
using NUnit.Framework;
using Sweaj.Serialization.Api.Models;

namespace Sweaj.Serialization.Api.Tests
{
    public class Tests
    {
        [Test]
        public void ResetContext()
        {
            using var context = new DemoContext();
            context.VideoMetadatas.RemoveRange(context.VideoMetadatas);
            Assert.DoesNotThrow(() => context.SaveChanges());
        }

        [Test]
        public void ApplyDefaults()
        {
            var context = new DemoContext();
            var videos = GetDefaultVideoMetadata();
            context.AddRange(videos);
            Assert.DoesNotThrow(() => context.SaveChanges());
        }

        private IEnumerable<VideoMetadata> GetDefaultVideoMetadata()
        {
            const int videosToGenerate = 10;
            var videos = new List<VideoMetadata>(videosToGenerate);
            var random = new Random();
            for (int i = 0; i < videosToGenerate; i++)
            {
                var videoMetadata = new VideoMetadata()
                {
                    Id = Guid.NewGuid(),
                    AllowEmbedding = random.Next(2) == 0,
                    IsAgeRestricted = random.Next(2) == 0,
                    IsCommentsAllowed = random.Next(2) == 0,
                    IsForKids = random.Next(2) == 0,
                    Category = categories[random.Next(categories.Length)],
                    UploadDate = DateTime.Now.AddDays(random.Next(i + i)).AddHours(random.Next(i + i)).AddMonths(random.Next(i + i) % 10),
                    IsMonetized = true,
                    Language = "English",
                    LicenseType = "Standard",
                    PlaylistId = Guid.Empty,
                    PublishDate = DateTime.Now.AddDays(random.Next(i + i)).AddHours(random.Next(i + i)).AddMonths(random.Next(i + i) % 10),
                    RecordingDate = DateTime.Now.AddDays(random.Next(i + i)).AddHours(random.Next(i + i)).AddMonths(random.Next(i + i) % 10),
                    ShortDescription = descs[i % descs.Length],
                    Tags = tags[random.Next(tags.Length)],
                    Thumbnail = null,
                    Title = titles[random.Next(titles.Length)],
                    ViewCount = random.Next(),
                    Visibility = random.Next(2) == 0 ? "Public" : "Private"
                };

                videos.Add(videoMetadata);
            }

            return videos;
        }

        private string[] categories = { "Science & Technology", "News", "Gaming"};
        private string[] titles = { "What you should be doing as a FRESHMAN studying CS/CPIS", "What makes a great Software Engineering project", "Best practices for software engineers" };
        private string[] descs = { "Please check out my other channel", "Please subscribe to this channel", "Be the first to like this video!" };
        private string[] tags = { "hd, anthony, video, programming, engineering", "video, hd, helloworld", "science, anthony, technology, programming" };
    }
}