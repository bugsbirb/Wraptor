using System.Text.Json.Serialization;

namespace Wraptor.Models;

public class Live
{
    [JsonPropertyName("status")]
    public string? Status { get; private set; }
}