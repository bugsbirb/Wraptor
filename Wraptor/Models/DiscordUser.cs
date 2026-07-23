using Newtonsoft.Json;

namespace Wraptor.Core.Models;

public class DiscordUser
{
    [JsonProperty("providerAccountId")]
    public string? ProviderAccountId { get; private set; }
    
    [JsonProperty("userId")]
    public string? UserId { get; private set; }
}