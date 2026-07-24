using Newtonsoft.Json;

namespace Wraptor.Core.Models.Server;

public class Member
{
    [JsonProperty("createdAt")]
    public Int64 CreatedAt { get; private set; }

    [JsonProperty("id")]
    public string? Id { get; private set; }

    [JsonProperty("roles")]
    public List<string>? Name { get; private set; }

    [JsonProperty("serverId")]
    public string? ServerId { get; private set; }
}
