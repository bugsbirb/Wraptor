using System.Net.Http.Headers;

namespace Wraptor.Core.Services;

public class RateLimitHandler
{
    private RatelimitState? _current;

    public async Task EnsureRatelimitAsync()
    {
        if (_current != null && _current.Remaining <= 0)
        {
            TimeSpan wait = _current.ResetAt - DateTimeOffset.UtcNow;
            if (wait > TimeSpan.Zero)
                await Task.Delay(wait);
        }
    }

    public void UpdateFromHeaders(HttpResponseHeaders headers)
    {
        if (
            headers.TryGetValues("X-RateLimit-Remaining", out var remainingValues)
            && Int64.TryParse(remainingValues.FirstOrDefault(), out var remaining)
            && headers.TryGetValues("X-RateLimit-Reset", out var resetValues)
            && Int64.TryParse(resetValues.FirstOrDefault(), out var resetSeconds)
        )
        {
            _current = new RatelimitState
            {
                Remaining = remaining,
                ResetAt = DateTimeOffset.UtcNow.AddSeconds(resetSeconds),
            };
        }
    }
}

internal class RatelimitState
{
    public Int64 Remaining { get; set; }
    public DateTimeOffset ResetAt { get; set; }
}
