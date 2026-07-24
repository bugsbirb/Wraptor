using Newtonsoft.Json;

namespace Wraptor.Core.Models.Server;

public class Member
{
    [JsonProperty("createdAt")]
    public Int64 CreatedAt { get; private set; }

    [JsonProperty("id")]
    public required string Id { get; init; }

    [JsonProperty("roles")]
    public List<string>? Roles { get; private set; }

    [JsonProperty("serverId")]
    public required string ServerId { get; init; }
}
