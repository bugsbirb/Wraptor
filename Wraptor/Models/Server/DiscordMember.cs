using Newtonsoft.Json;

namespace Wraptor.Core.Models.Server;

public class DiscordMember
{
    [JsonProperty("discordId")]
    public required string DiscordId { get; init; }
}
