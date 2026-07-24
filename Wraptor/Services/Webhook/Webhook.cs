using System.Text;
using Newtonsoft.Json.Linq;

namespace Wraptor.Core.Services.Webhook;

public class WebhookService : IWebhook
{
    private readonly WraptorHttp _http;

    internal WebhookService(WraptorHttp http)
    {
        _http = http;
    }

    public async Task PostAsync(string webhookUrl, object payload)
    {
        if (webhookUrl == null)
            throw new ArgumentNullException(nameof(webhookUrl), "Webhook url cannot be null.");
        if (payload == null)
            throw new ArgumentNullException(nameof(payload), "Payload cannot be null.");

        string? json = payload.ToString();
        if (string.IsNullOrWhiteSpace(json))
        {
            throw new ArgumentException("Payload cannot be null or empty.", nameof(payload));
        }
        StringContent content = new(json, Encoding.UTF8, "application/json");
        await _http.PostAsync(new Uri(webhookUrl), content);
    }
}
