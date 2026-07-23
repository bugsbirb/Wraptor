using Newtonsoft.Json;

namespace Wraptor.Core.Models;

public class ServerInfo
{
    [JsonProperty("createdAt")]
    public Int64 CreatedAt { get; private set; }

    [JsonProperty("discordGuildId")]
    public Int64 DiscordGuildId { get; private set; }

    [JsonProperty("joinCode")]
    public string? JoinCode { get; private set; }

    [JsonProperty("name")]
    public string? Name { get; private set; }

    [JsonProperty("ownerId")]
    public string? OwnerId { get; private set; }

    [JsonProperty("roles")]
    public List<string>? Roles { get; private set; }
}
