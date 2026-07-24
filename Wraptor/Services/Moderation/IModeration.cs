using Wraptor.Core.Models;
using Wraptor.Core.Models.Moderation;

namespace Wraptor.Core.Services.Moderation;

public interface IModeration
{
    /// <summary>
    /// Get a list of the servers moderations/logs
    /// </summary>
    /// <param name="properties"></param>
    /// <returns><see cref="PaginatedResult{T}"/> <see cref="ModerationLog"/></returns>
    Task<WraptorResponse<PaginatedResult<ModerationLog>>> GetModerationsAsync(
        PaginationProperties? properties = null
    );

    /// <summary>
    /// Get a list of the servers moderations/logs by the staff member who created them.
    /// </summary>
    /// <param name="staffId"></param>
    /// <param name="properties"></param>
    /// <returns><see cref="PaginatedResult{T}"/> <see cref="ModerationLog"/></returns>
    Task<WraptorResponse<PaginatedResult<ModerationLog>>> GetModerationsByStaff(
        string staffId,
        PaginationProperties? properties = null
    );

    /// <summary>
    /// Get a list of the servers moderations/logs from the moderated user's usernames
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="properties"></param>
    /// <returns><see cref="PaginatedResult{T}"/> <see cref="ModerationLog"/></returns>
    Task<WraptorResponse<PaginatedResult<ModerationLog>>> GetModerationsByUser(
        string userId,
        PaginationProperties? properties = null
    );

    /// <summary>
    /// Get a singular moderation it's log id.
    /// </summary>
    /// <param name="logId"></param>
    /// <returns> <see cref="ModerationLog"/></returns>
    Task<WraptorResponse<ModerationLog>> GetModeration(string logId);
}
