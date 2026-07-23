using Wraptor.Core.Models;
using Wraptor.Core.Models.Ratelimits;

namespace Wraptor.Core.Services.Ratelimit;

public interface IRatelimit
{
    Task<WraptorResponse<Ratelimits>> GetRatelimitAsync(string serverId);
}
