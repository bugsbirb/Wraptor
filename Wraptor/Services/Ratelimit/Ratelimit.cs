using Wraptor.Core.Models;

namespace Wraptor.Core.Services.Ratelimit;

internal class RatelimitService : IRatelimit
{
    private readonly WraptorHttp _http;

    internal RatelimitService(WraptorHttp http)
    {
        _http = http;
    }

    public async Task<WraptorResponse<Ratelimits>> GetRatelimitAsync(string serverId)
    {
        return WraptorResponse<Ratelimits>.FromResponse(
            await _http.GetAsync($"/admin/server/{serverId}/rate-limit")
        );
    }
}
