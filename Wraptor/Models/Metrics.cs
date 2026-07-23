using System.Text.Json.Serialization;

namespace Wraptor.Models;

public class Metrics
{
    [JsonPropertyName("status")]
    public string? Status { get; private set; }
    
    [JsonPropertyName("databasePoolSize")]
    public Int32? DatabasePoolSize { get; private set; }
}