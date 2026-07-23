using System.Text.Json.Serialization;

namespace Wraptor.Core.Models;

public class ApplicationResponse
{
    [JsonPropertyName("applicationId")]
    public string? ApplicationId { get; private set; }
    
    [JsonPropertyName("createdAt")]
    public Int64 CreatedAt { get; private set; }
    
    [JsonPropertyName("finalizedAt")]
    public Int64 FinalizedAt { get; private set; }
    
    [JsonPropertyName("finalizedBy")]
    public string? FinalizedBy { get; private set; }
    
    [JsonPropertyName("id")]
    public string? Id { get; private set; }
    
    [JsonPropertyName("reason")]
    public string? Reason { get; private set; }
    
    [JsonPropertyName("reviewedAt")]
    public Int64 ReviewedAt { get; private set; }
    
    [JsonPropertyName("reviewedBy")]
    public string? ReviewedBy { get; private set; }
    
    [JsonPropertyName("robloxId")]
    public string? RobloxId { get; private set; }
    
    
}