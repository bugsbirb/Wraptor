using System.Text.Json.Serialization;

namespace Wraptor.Core.Models;

public class Live
{
    [JsonPropertyName("status")]
    public string? Status { get; private set; }
}