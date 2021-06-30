using Newtonsoft.Json;

namespace NewYorkTimes.Core.Helpers
{
    public class ApiResponse
    {
        public Success success { get; set; }
        public Error error { get; set; } = new Error();
    }

    public class Success : BaseEntity
    {
        [JsonProperty(Order = 1)]
        public object Data { get; set; }
    }
    public class Error : BaseEntity
    {
        [JsonProperty(Order = 1)]
        public string SubCode { get; set; }
        [JsonProperty(Order = 1)]

        public string Field { get; set; }
        [JsonProperty(Order = 1)]

        public string Title { get; set; }
        [JsonProperty(Order = 1)]

        public string Detail { get; set; }
    }
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public dynamic Code { get; set; }
        public dynamic Status { get; set; }
        public string Message { get; set; }
    }
}
