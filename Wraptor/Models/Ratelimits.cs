using System.Text.Json.Serialization;

namespace Wraptor.Core.Models;

public class Ratelimits
{
    [JsonPropertyName("currentCount")]
    public Int64 CurrentCount { get; set; }
    
    [JsonPropertyName("limit")]
    public Int64 Limit { get; set; }
    
    [JsonPropertyName("remaining")]
    public Int64 Remaining { get; set; }
    
    [JsonPropertyName("serverId")]
    public string? ServerId { get; set; }
    
    [JsonPropertyName("timetoResetMin")]
    public Int64 TimeToResetMin { get; set; }

    [JsonPropertyName("timetoResetHrs")]
    public double TimetoResetHrs { get; set; }
    
    
}