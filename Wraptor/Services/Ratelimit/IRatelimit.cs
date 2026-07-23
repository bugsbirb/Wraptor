using Wraptor.Core.Models;

namespace Wraptor.Core.Services.Ratelimit;

public interface IRatelimit
{
    Task<WraptorResponse<Ratelimits>> Ratelimit(string serverId);
}