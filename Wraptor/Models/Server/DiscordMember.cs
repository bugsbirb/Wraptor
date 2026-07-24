using Newtonsoft.Json;

namespace Wraptor.Core.Models.Server;

public class DiscordMember
{
    [JsonProperty("discordId")]
    public string? DiscordId { get; private set; }
}
