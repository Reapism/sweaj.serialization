using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Sweaj.Serialization.Web.Services
{
    public class StringContentConstructor
    {
        private readonly JsonSerializerOptions options;

        public StringContentConstructor(JsonSerializerOptions options)
        {
            this.options = options;
        }

        public StringContent ToStringContent<T>(T value)
        {
            var json = JsonSerializer.Serialize(value, options);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");

            return stringContent;
        }
    }
}
