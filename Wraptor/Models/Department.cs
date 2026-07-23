using Newtonsoft.Json;

namespace Wraptor.Core.Models;

public class DepartmentInfo
{
    [JsonProperty("activated")]
    public bool Activated { get; private set; }

    [JsonProperty("discordGuildId")]
    public Int64 DiscordGuildId { get; private set; }

    [JsonProperty("icon")]
    public string? Icon { get; private set; }

    [JsonProperty("id")]
    public Int64 Id { get; private set; }

    [JsonProperty("name")]
    public string? Name { get; private set; }

    [JsonProperty("serverId")]
    public Int64 ServerId { get; private set; }

    [JsonProperty("type")]
    public Int32? Type { get; private set; }
}
