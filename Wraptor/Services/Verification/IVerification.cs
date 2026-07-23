using Wraptor.Core.Models;

namespace Wraptor.Core.Services.Verification;

public interface IVerification
{
    /// <summary>
    /// Returns the Roblox account linked to a verified Discord user.
    /// </summary>
    /// <param name="discordId"></param>
    /// <returns>Roblox account details</returns>
    Task<WraptorResponse<RobloxUser>> DiscordToRoblox(string discordId);
    
    /// <summary>
    /// Returns the discord account linked to a verified roblox account.
    /// </summary>
    /// <param name="robloxId"></param>
    /// <returns>Discord account details</returns>
    Task<WraptorResponse<DiscordUser>> RobloxToDiscord(string robloxId);


}