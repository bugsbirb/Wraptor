namespace Wraptor.Core.Services.Webhook;

public interface IWebhook
{
    /// <summary>
    /// Using Melonly's Workflow feature
    /// </summary>
    /// <param name="webhookUrl"></param>
    /// <param name="payload"></param>
    /// <returns></returns>
    Task PostAsync(string webhookUrl, object payload);
}
