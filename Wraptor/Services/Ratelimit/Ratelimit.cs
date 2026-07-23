using Wraptor.Models;

namespace Wraptor.Services.Ratelimit;

internal class RatelimitService: IRatelimit
{
    private readonly WraptorClient _client;

    internal RatelimitService(WraptorClient client)
    {
        _client = client;
    }
    
    public async Task<WraptorResponse<Ratelimits>> Ratelimit(string serverId)
    {
        return WraptorResponse<Ratelimits>.FromResponse(
            await _client.GetAsync($"/admin/server/{serverId}/rate-limit"));
    }
}