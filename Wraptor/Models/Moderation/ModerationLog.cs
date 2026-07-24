using Newtonsoft.Json;

namespace Wraptor.Core.Models.Moderation;

public class ModerationLog
{
    [JsonProperty("completedBy")]
    public string? CompletedBy { get; private set; }

    [JsonProperty("createdAt")]
    public Int64? CreatedAt { get; private set; }

    [JsonProperty("createdBy")]
    public string? CreatedBy { get; private set; }

    [JsonProperty("deniedBy")]
    public string? DeniedBy { get; private set; }

    [JsonProperty("expired")]
    public bool? Expired { get; private set; }

    [JsonProperty("expiredAt")]
    public Int64? ExpiredAt { get; private set; }

    [JsonProperty("hidden")]
    public bool? Hidden { get; private set; }

    [JsonProperty("hiddenBy")]
    public string? HiddenBy { get; private set; }

    [JsonProperty("id")]
    public string? Id { get; private set; }

    [JsonProperty("proof")]
    public List<string>? Proof { get; private set; }

    [JsonProperty("robloxId")]
    public string? RobloxId { get; private set; }

    [JsonProperty("serverId")]
    public string? ServerId { get; private set; }

    [JsonProperty("tempBan")]
    public bool? TempBan { get; private set; }

    [JsonProperty("text")]
    public string? Reason { get; private set; }

    [JsonProperty("type")]
    public Int64? Type { get; private set; }

    [JsonProperty("typeId")]
    public string? TypeId { get; private set; }

    [JsonProperty("unbanAt")]
    public Int64? UnbanAt { get; private set; }

    [JsonProperty("username")]
    public string? Username { get; private set; }
}
