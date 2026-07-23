using System.Text.Json.Serialization;

namespace Wraptor.Core.Models;

public class Ready
{
    [JsonPropertyName("database")]
    public bool Database { get; private set; }
    
    [JsonPropertyName("redis")]
    public bool Redis { get; private set; }
}