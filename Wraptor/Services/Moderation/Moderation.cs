using Wraptor.Core.Models;
using Wraptor.Core.Models.Moderation;

namespace Wraptor.Core.Services.Moderation;

public class ModerationService : IModeration
{
    private readonly WraptorHttp _http;

    internal ModerationService(WraptorHttp http)
    {
        _http = http;
    }

    public async Task<WraptorResponse<PaginatedResult<ModerationLog>>> GetModerationsAsync(
        PaginationProperties? properties = null
    )
    {
        properties ??= new PaginationProperties();
        string query = new PaginationQuery().Params(properties);

        return WraptorResponse<PaginatedResult<ModerationLog>>.FromResponse(
            await _http.GetAsync("/server/logs" + query)
        );
    }

    public async Task<WraptorResponse<PaginatedResult<ModerationLog>>> GetModerationsByStaff(
        string staffId,
        PaginationProperties? properties = null
    )
    {
        properties ??= new PaginationProperties();
        string query = new PaginationQuery().Params(properties);

        return WraptorResponse<PaginatedResult<ModerationLog>>.FromResponse(
            await _http.GetAsync("/server/logs/staff/" + staffId + query)
        );
    }

    public async Task<WraptorResponse<PaginatedResult<ModerationLog>>> GetModerationsByUser(
        string userId,
        PaginationProperties? properties = null
    )
    {
        properties ??= new PaginationProperties();
        string query = new PaginationQuery().Params(properties);

        return WraptorResponse<PaginatedResult<ModerationLog>>.FromResponse(
            await _http.GetAsync("/server/logs/user/" + userId + query)
        );
    }

    public async Task<WraptorResponse<ModerationLog>> GetModeration(string logId)
    {
        return WraptorResponse<ModerationLog>.FromResponse(
            await _http.GetAsync("/server/logs/" + logId)
        );
    }
}
