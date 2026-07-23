using System.Text.Json.Serialization;

namespace Wraptor.Core.Models;

public class RobloxUser
{
    [JsonPropertyName("createdAt")]
    public Int64 CreatedAt { get; private set; }
    
    [JsonPropertyName("headShotImage")]
    public string? HeadShotImage { get; private set; }
    
    [JsonPropertyName("lastUpdatedAt")]
    public Int64 LastUpdatedAt { get; private set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; private set; }
    
    [JsonPropertyName("nickname")]
    public string? Nickname { get; private set; }
    
    [JsonPropertyName("preferredUsername")]
    public string? PreferredUsername { get; private set; }
    
    [JsonPropertyName("robloxCreatedAt")]
    public Int64 RobloxCreatedAt { get; private set; }
    
    [JsonPropertyName("robloxId")]
    public string? RobloxId { get; private set; }
    
    [JsonPropertyName("userId")]
    public string? UserId { get; private set; }

}