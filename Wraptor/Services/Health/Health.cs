using Wraptor.Models;

namespace Wraptor.Services.Health;

internal class HealthService: IHealth
{
    private readonly WraptorClient _client;

    internal HealthService(WraptorClient client)
    {
        _client = client;
    }

    public async Task<WraptorResponse<Live>> Live()
    {
        return WraptorResponse<Live>.FromResponse(
            await _client.GetAsync("/livez"));
    }

    public async Task<WraptorResponse<Metrics>> Metrics()
    {
        return WraptorResponse<Metrics>.FromResponse(
            await _client.GetAsync("/metrics"));
    }
    
    public async Task<WraptorResponse<Ready>> Ready()
    {
        return WraptorResponse<Ready>.FromResponse(
            await _client.GetAsync("/readyz"));
    }
}