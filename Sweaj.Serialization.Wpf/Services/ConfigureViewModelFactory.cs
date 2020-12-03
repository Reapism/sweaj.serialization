using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Sweaj.Serialization.Wpf.ViewModels;

namespace Sweaj.Serialization.Wpf.Services
{
    public class ConfigureViewModelFactory
    {
        public async static Task<ConfigureViewModel> From(string scheme, string host, int port, string path)
        {
            var configureViewModel = new ConfigureViewModel()
            {
                Path = path,
                Host = host,
                Port = port,
                Scheme = scheme,
            };

            var client = new HttpClient();
            var uriBuilder = new UriBuilder(scheme, host, port, path);
            client.BaseAddress = new UriBuilder(scheme, host, port).Uri;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync(path, HttpCompletionOption.ResponseContentRead);
            if (response.IsSuccessStatusCode)
            {
                configureViewModel.IsSuccessful = true;
                configureViewModel.Status = $"Successfully reached {uriBuilder.Uri}.";
            }
            else
            {
                configureViewModel.IsSuccessful = false;
                configureViewModel.Status = $"Unable to reach {uriBuilder.Uri}. Please check the values, and the status of the webserver.";
                configureViewModel.ErrorInfo = response.ReasonPhrase;
            }

            configureViewModel.HttpClient = client;

            return configureViewModel;
        }
    }
}
