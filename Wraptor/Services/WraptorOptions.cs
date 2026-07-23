namespace Wraptor.Services;

public abstract class WraptorOptions
{
    public required string  ApiKey { get; set; }
    public string BaseUrl { get; set; } = ConstantValues.DefaultBaseUrl;
}