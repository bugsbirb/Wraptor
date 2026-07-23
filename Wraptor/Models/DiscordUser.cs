using System.Text.Json.Serialization;

namespace Wraptor.Core.Models;

public class DiscordUser
{
    [JsonPropertyName("providerAccountId")]
    public string? ProviderAccountId { get; private set; }
    
    [JsonPropertyName("userId")]
    public string? UserId { get; private set; }
}