using Wraptor.Core.Models;
using Wraptor.Core.Models.Server;

namespace Wraptor.Core.Services.Server;

public interface IServer
{
    /// <summary>
    /// Get server information from the authenticated server
    /// </summary>
    /// <returns> <see cref="ServerInfo"/></returns>
    public Task<WraptorResponse<ServerInfo>> GetServerAsync();

    /// <summary>
    /// Get the list of server members from the authenticated server.
    /// </summary>
    /// <param name="properties"></param>
    /// <returns><see cref="Member"/></returns>
    Task<WraptorResponse<PaginatedResult<Member>>> GetMembersAsync(
        PaginationProperties? properties = null
    );

    /// <summary>
    /// Get a member from your authenticated server by their Melonly member id.
    /// </summary>
    /// <param name="memberId"></param>
    /// <returns><see cref="Member"/></returns>
    Task<WraptorResponse<Member>> GetMemberAsync(string memberId);

    /// <summary>
    /// Get a member from your authenticated server by discord id.
    /// </summary>
    /// <param name="discordId"></param>
    /// <returns><see cref="Member"/></returns>
    Task<WraptorResponse<PaginatedResult<Member>>> GetMemberByDiscordAsync(string discordId);

    /// <summary>
    /// Get a discord member from your authenticated server by their Melonly member id.
    /// </summary>
    /// <param name="memberId"></param>
    /// <returns><see cref="DiscordMember"/></returns>
    Task<WraptorResponse<DiscordMember>> GetMemberDiscordAsync(string memberId);
}
