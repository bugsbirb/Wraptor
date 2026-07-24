using System.Net;

namespace Wraptor.Core.Exceptions;

public class WraptorRateLimitException(TimeSpan retryAfter)
    : WraptorApiFailure(HttpStatusCode.TooManyRequests, "Rate limit exceeded.")
{
    public TimeSpan RetryAfter { get; } = retryAfter;
}
