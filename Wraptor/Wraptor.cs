using Wraptor.Core.Services;
using Wraptor.Core.Services.Health;
using Wraptor.Core.Services.Ratelimit;
using Wraptor.Core.Services.Verification;

namespace Wraptor.Core;

public class WraptorClient
{
    private readonly WraptorHttp _client;
    
    public IHealth Health { get; set; }
    public IRatelimit Ratelimit { get; set; }
    public IVerification Verification { get; set; }

    public WraptorClient(WraptorOptions options)
    {
        _client = new WraptorHttp(options);
        
        Health = new HealthService(_client);
        Ratelimit = new RatelimitService(_client);
        Verification = new VerificationService(_client);
    }

    public void UpdateKey(string apiKey)
    {
        _client.UpdateKey(apiKey);
    }
}