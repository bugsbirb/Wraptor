
using Newtonsoft.Json;

namespace Wraptor.Core.Models;

public class Ready
{
    [JsonProperty("database")]
    public bool Database { get; private set; }
    
    [JsonProperty("redis")]
    public bool Redis { get; private set; }
}