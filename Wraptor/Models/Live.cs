using Newtonsoft.Json;

namespace Wraptor.Core.Models;

public class Live
{
    [JsonProperty("status")]
    public string? Status { get; private set; }
}