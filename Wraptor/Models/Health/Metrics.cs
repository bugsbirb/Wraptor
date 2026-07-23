using Newtonsoft.Json;

namespace Wraptor.Core.Models.Health;

public class Metrics
{
    [JsonProperty("status")]
    public string? Status { get; private set; }

    [JsonProperty("databasePoolSize")]
    public Int32? DatabasePoolSize { get; private set; }
}
