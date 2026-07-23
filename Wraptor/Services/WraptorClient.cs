using System.Net.Http.Headers;
using Wraptor.Services.Health;
using Wraptor.Services.Ratelimit;
using Wraptor.Services.Verification;

namespace Wraptor.Services;

internal class WraptorClient : HttpClient
{
    public WraptorClient(WraptorOptions options)
    {
        BaseAddress = new Uri(options.BaseUrl);
        DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", options.ApiKey);
    }

    public void UpdateKey(string apiKey)
    {
        DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", apiKey);
    }
}