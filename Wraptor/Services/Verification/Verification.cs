using Wraptor.Core.Models;
using Wraptor.Core.Models.Verification;

namespace Wraptor.Core.Services.Verification;

internal class VerificationService : IVerification
{
    private readonly WraptorHttp _http;

    public VerificationService(WraptorHttp http)
    {
        _http = http;
    }

    public async Task<WraptorResponse<RobloxUser>> DiscordToRobloxAsync(string discordId)
    {
        return WraptorResponse<RobloxUser>.FromResponse(
            await _http.GetAsync($"/verification/discord/{discordId}/roblox")
        );
    }

    public async Task<WraptorResponse<DiscordUser>> RobloxToDiscordAsync(string robloxId)
    {
        return WraptorResponse<DiscordUser>.FromResponse(
            await _http.GetAsync($"/verification/roblox/{robloxId}/discord")
        );
    }
}
