using Newtonsoft.Json;

namespace Wraptor.Core.Models.Departments;

public class DepartmentInfo
{
    [JsonProperty("activated")]
    public bool Activated { get; private set; }

    [JsonProperty("discordGuildId")]
    public string? DiscordGuildId { get; private set; }

    [JsonProperty("icon")]
    public string? Icon { get; private set; }

    [JsonProperty("id")]
    public required string Id { get; init; }

    [JsonProperty("name")]
    public required string Name { get; init; }

    [JsonProperty("serverId")]
    public required string ServerId { get; init; }

    [JsonProperty("type")]
    public Int32? Type { get; private set; }
}
