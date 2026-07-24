using Newtonsoft.Json;

namespace Wraptor.Core.Models.Server;

public class ServerInfo
{
    [JsonProperty("createdAt")]
    public Int64 CreatedAt { get; private set; }

    [JsonProperty("discordGuildId")]
    public Int64 DiscordGuildId { get; private set; }

    [JsonProperty("joinCode")]
    public string? JoinCode { get; private set; }

    [JsonProperty("name")]
    public required string Name { get; init; }

    [JsonProperty("ownerId")]
    public required string OwnerId { get; init; }

    [JsonProperty("roles")]
    public List<string>? Roles { get; private set; }
}
