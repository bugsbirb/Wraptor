using Wraptor.Core.Models;

namespace Wraptor.Core.Services.Health;

internal class HealthService : IHealth
{
    private readonly WraptorHttp _http;

    internal HealthService(WraptorHttp http)
    {
        _http = http;
    }

    public async Task<WraptorResponse<Live>> GetLivenessAsync()
    {
        return WraptorResponse<Live>.FromResponse(await _http.GetAsync("/livez"));
    }

    public async Task<WraptorResponse<Metrics>> GetMetricsAsync()
    {
        return WraptorResponse<Metrics>.FromResponse(await _http.GetAsync("/metrics"));
    }

    public async Task<WraptorResponse<Ready>> GetReadinessAsync()
    {
        return WraptorResponse<Ready>.FromResponse(await _http.GetAsync("/readyz"));
    }
}
