using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Sweaj.Serialization.Wpf.ViewModels
{
    public class ConfigureViewModel
    {
        public ConfigureViewModel()
        {

        }
        public HttpClient HttpClient { get; set; }
        public string Scheme { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string Path { get; set; }
        public bool IsSuccessful { get; set; }
        public string Status { get; set; }
        public string ErrorInfo { get; set; }
    }
}
