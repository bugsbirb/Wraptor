using Newtonsoft.Json;

namespace Wraptor.Core.Models;

public class Ratelimits
{
    [JsonProperty("currentCount")]
    public Int64 CurrentCount { get; set; }
    
    [JsonProperty("limit")]
    public Int64 Limit { get; set; }
    
    [JsonProperty("remaining")]
    public Int64 Remaining { get; set; }
    
    [JsonProperty("serverId")]
    public string? ServerId { get; set; }
    
    [JsonProperty("timetoResetMin")]
    public Int64 TimeToResetMin { get; set; }

    [JsonProperty("timetoResetHrs")]
    public double TimetoResetHrs { get; set; }
    
    
}