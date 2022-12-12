using Newtonsoft.Json;

namespace livraria_api.v1.Helpers
{
    public class HttpResponse
    {
        [JsonProperty("success", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Success { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Content { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; set; }
    }
}
