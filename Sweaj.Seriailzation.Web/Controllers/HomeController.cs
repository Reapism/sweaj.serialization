using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sweaj.Serialization.Web.Models;
using Sweaj.Serialization.Api;
using Sweaj.Serialization.Api.Services;
using Sweaj.Serialization.Api.Models;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace Sweaj.Serialization.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DemoContext context;

        public HomeController(ILogger<HomeController> logger, DemoContext demoContext)
        {
            _logger = logger;
            this.context = demoContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var videos = context.VideoMetadatas
                .OrderByDescending(e => e.Visibility)
                .ThenBy(e => e.Title)
                .Take(10)
                .ToArray();

            return View(videos);
        }
        
        [HttpGet]
        public IActionResult Video(Guid? id)
        {
            if (!id.HasValue)
                return View();

            var videoModel = context.VideoMetadatas.FirstOrDefault(e => e.Id == id);

            if (videoModel is null)
                return Error();

            return View(videoModel);
        }

        [HttpGet]
        public IActionResult RandomVideo(int? numberOfVideos)
        {
            var videos = RandomVideoGenerator.CreateRandomVideo(numberOfVideos.HasValue ? numberOfVideos.Value : 1);
            
            context.VideoMetadatas.AddRange(videos);
            context.SaveChanges();
            ViewData.Add("Title", videos[0].Title);
            return RedirectToAction(nameof(Video), new { id = videos[0].Id });
        }

        [HttpGet]
        public IActionResult ClearVideos()
        {
            context.VideoMetadatas.RemoveRange(context.VideoMetadatas);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult DownloadVideo(Guid? videoId)
        {
            if (!videoId.HasValue)
            {
                return NoContent();
            }

            var video = context.VideoMetadatas.First(e => e.Id == videoId.Value);
            var json = JsonSerializer.Serialize(video, new JsonSerializerOptions() { WriteIndented = true });
            var jsonBytes = Encoding.UTF8.GetBytes(json);
            return File(jsonBytes, "application/json");
        }

        [HttpGet]
        public IActionResult DeleteVideo(Guid? videoId)
        {
            if (!videoId.HasValue)
            {
                return NoContent();
            }

            context.VideoMetadatas.Remove(context.VideoMetadatas.First(e => e.Id == videoId.Value));
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
