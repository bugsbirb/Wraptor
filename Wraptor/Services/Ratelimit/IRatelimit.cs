using Wraptor.Models;

namespace Wraptor.Services.Ratelimit;

public interface IRatelimit
{
    Task<WraptorResponse<Ratelimits>> Ratelimit(string serverId);
}