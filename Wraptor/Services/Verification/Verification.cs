using Wraptor.Core.Models;

namespace Wraptor.Core.Services.Verification;

internal class VerificationService: IVerification
{
    private readonly WraptorHttp _http;

    public VerificationService(WraptorHttp http)
    {
        _http = http;
    }
    
    public async Task<WraptorResponse<RobloxUser>> DiscordToRoblox(string discordId)
    {
        return WraptorResponse<RobloxUser>.FromResponse(
            await _http.GetAsync($"/verification/discord/{discordId}/roblox"));
    }
    
    public async Task<WraptorResponse<DiscordUser>> RobloxToDiscord(string robloxId)
    {
        return WraptorResponse<DiscordUser>.FromResponse(
            await _http.GetAsync($"/verification/roblox/{robloxId}/discord"));
    }
    
}