using Wraptor.Core.Models;
using Wraptor.Core.Models.Ratelimits;

namespace Wraptor.Core.Services.Ratelimit;

public interface IRatelimit
{
    /// <summary>
    /// Get rate limit information from the authenticated server.
    /// </summary>
    /// <param name="serverId"></param>
    /// <returns><see cref="Ratelimits"/></returns>
    Task<WraptorResponse<Ratelimits>> GetRatelimitAsync(string serverId);
}
