using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Wraptor.Core.Models;

public class ApplicationResponse
{
    [JsonProperty("applicationId")]
    public string? ApplicationId { get; private set; }
    
    [JsonProperty("createdAt")]
    public Int64 CreatedAt { get; private set; }
    
    [JsonProperty("finalizedAt")]
    public Int64 FinalizedAt { get; private set; }
    
    [JsonProperty("finalizedBy")]
    public string? FinalizedBy { get; private set; }
    
    [JsonProperty("id")]
    public string? Id { get; private set; }
    
    [JsonProperty("reason")]
    public string? Reason { get; private set; }
    
    [JsonProperty("reviewedAt")]
    public Int64 ReviewedAt { get; private set; }
    
    [JsonProperty("reviewedBy")]
    public string? ReviewedBy { get; private set; }
    
    [JsonProperty("robloxId")]
    public string? RobloxId { get; private set; }
    
    
}