using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sweaj.Serialization.Data;
using Sweaj.Serialization.Data.Services;
using Sweaj.Serialization.Web.Models;

namespace Sweaj.Serialization.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VideoContext context;
        private readonly HttpClient httpClient;

        public HomeController(ILogger<HomeController> logger, VideoContext demoContext, HttpClient httpClient)
        {
            _logger = logger;
            this.context = demoContext;
            this.httpClient = httpClient;
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
        public async Task<IActionResult> Video(Guid? id)
        {
            if (!id.HasValue)
                return View();

            var videoModel = await context.VideoMetadatas.FirstOrDefaultAsync(e => e.Id == id);

            if (videoModel is null)
                return Error();

            return View(videoModel);
        }

        [HttpGet]
        public async Task<IActionResult> RandomVideo(int? numberOfVideos)
        {
            var videos = RandomVideoGenerator.CreateRandomVideo(numberOfVideos.HasValue ? numberOfVideos.Value : 1);

            var response = await httpClient.PostAsJsonAsync("api/uploadvideo", videos);

            if (response.IsSuccessStatusCode)
                return RedirectToAction(nameof(Video), new { id = videos[0].Id });
            else
                return BadRequest();
        }

        [HttpGet]
        public IActionResult DeleteAllVideos()
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
