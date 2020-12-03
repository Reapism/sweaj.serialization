using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sweaj.Serialization.Data;
using Sweaj.Serialization.Data.Models;

namespace Sweaj.Serialization.Wpf.ViewModels
{
    public class VideosViewModel
    {
        public VideosViewModel()
        {
            var context = new VideoContext();
            Videos = context.VideoMetadatas.ToArray();
        }

        public IEnumerable<VideoMetadata> Videos { get; set; } 
    }
}
