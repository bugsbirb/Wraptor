using Wraptor.Core.Models;
using Wraptor.Core.Models.Verification;

namespace Wraptor.Core.Services.Verification;

public interface IVerification
{
    /// <summary>
    /// Returns the Roblox account linked to a verified Discord user.
    /// </summary>
    /// <param name="discordId"></param>
    /// <returns>Roblox account details</returns>
    Task<WraptorResponse<RobloxUser>> DiscordToRobloxAsync(string discordId);

    /// <summary>
    /// Returns the discord account linked to a verified roblox account.
    /// </summary>
    /// <param name="robloxId"></param>
    /// <returns>Discord account details</returns>
    Task<WraptorResponse<DiscordUser>> RobloxToDiscordAsync(string robloxId);
}
