using Newtonsoft.Json;

namespace Wraptor.Core.Models.Health;

public class Ready
{
    [JsonProperty("database")]
    public bool Database { get; private set; }

    [JsonProperty("redis")]
    public bool Redis { get; private set; }
}
