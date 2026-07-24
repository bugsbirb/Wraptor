using System.Net;
using System.Net.Http.Headers;
using Wraptor.Core.Exceptions;

namespace Wraptor.Core.Services;

internal class WraptorHttp
{
    private readonly HttpClient _client;
    private readonly RateLimitHandler _ratelimit;

    internal WraptorHttp(WraptorOptions options)
    {
        _client = new HttpClient { BaseAddress = new Uri(options.BaseUrl) };
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            "Bearer",
            options.ApiKey
        );

        _ratelimit = new RateLimitHandler();
    }

    public Task<HttpResponseMessage> GetAsync(string uri) =>
        SendAsync(new HttpRequestMessage(HttpMethod.Get, uri.TrimStart('/')));

    public Task<HttpResponseMessage> PostAsync(Uri uri, HttpContent content) =>
        SendAsync(new HttpRequestMessage(HttpMethod.Post, uri) { Content = content });

    private async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
    {
        await _ratelimit.EnsureRatelimitAsync();

        HttpResponseMessage response = await _client.SendAsync(request);

        _ratelimit.UpdateFromHeaders(response.Headers);

        if (response.StatusCode == (HttpStatusCode)429)
        {
            TimeSpan retryAfter = response.Headers.RetryAfter?.Delta ?? TimeSpan.FromSeconds(1);
            throw new WraptorRateLimitException(retryAfter);
        }

        return response;
    }

    public void UpdateKey(string apiKey)
    {
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            "Bearer",
            apiKey
        );
    }
}
