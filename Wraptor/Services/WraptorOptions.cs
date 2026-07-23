namespace Wraptor.Core.Services;

public class WraptorOptions
{
    public required string  ApiKey { get; set; }
    public string BaseUrl { get; set; } = ConstantValues.DefaultBaseUrl;
}