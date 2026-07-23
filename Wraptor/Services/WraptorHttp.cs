using System.Net.Http.Headers;
using Wraptor.Core.Services.Health;
using Wraptor.Core.Services.Ratelimit;
using Wraptor.Core.Services.Verification;

namespace Wraptor.Core.Services;

internal class WraptorHttp : HttpClient
{
    public WraptorHttp(WraptorOptions options)
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