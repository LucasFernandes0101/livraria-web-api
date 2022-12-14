using Newtonsoft.Json;

namespace livraria_api.v1.Helpers
{
    public class HttpResponse
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object? Content { get; set; }

        [JsonProperty("errors", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ErrorResponse? Errors { get; set; }
    }
}
