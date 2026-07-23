using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Wraptor.Core.Models;

public class RobloxUser
{
    [JsonProperty("createdAt")]
    public Int64 CreatedAt { get; private set; }
    
    [JsonProperty("headShotImage")]
    public string? HeadShotImage { get; private set; }
    
    [JsonProperty("lastUpdatedAt")]
    public Int64 LastUpdatedAt { get; private set; }
    
    [JsonProperty("name")]
    public string? Name { get; private set; }
    
    [JsonProperty("nickname")]
    public string? Nickname { get; private set; }
    
    [JsonProperty("preferredUsername")]
    public string? PreferredUsername { get; private set; }
    
    [JsonProperty("robloxCreatedAt")]
    public Int64 RobloxCreatedAt { get; private set; }
    
    [JsonProperty("robloxId")]
    public string? RobloxId { get; private set; }
    
    [JsonProperty("userId")]
    public string? UserId { get; private set; }

}