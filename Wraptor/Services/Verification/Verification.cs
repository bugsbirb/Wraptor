using Wraptor.Models;

namespace Wraptor.Services.Verification;

internal class VerificationService: IVerification
{
    private readonly WraptorClient _client;

    public VerificationService(WraptorClient client)
    {
        _client = client;
    }
    
    public async Task<WraptorResponse<RobloxUser>> DiscordToRoblox(string discordId)
    {
        return WraptorResponse<RobloxUser>.FromResponse(
            await _client.GetAsync($"/verification/discord/{discordId}/roblox"));
    }
    
    public async Task<WraptorResponse<DiscordUser>> RobloxToDiscord(string robloxId)
    {
        return WraptorResponse<DiscordUser>.FromResponse(
            await _client.GetAsync($"/verification/roblox/{robloxId}/discord"));
    }
    
}