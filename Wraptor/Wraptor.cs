using Wraptor.Services;
using Wraptor.Services.Health;
using Wraptor.Services.Ratelimit;
using Wraptor.Services.Verification;

namespace Wraptor;

public class Wraptor
{
    private readonly WraptorClient _client;
    
    public IHealth Health { get; set; }
    public IRatelimit Ratelimit { get; set; }
    public IVerification Verification { get; set; }

    public Wraptor(WraptorOptions options)
    {
        _client = new WraptorClient(options);
        
        Health = new HealthService(_client);
        Ratelimit = new RatelimitService(_client);
        Verification = new VerificationService(_client);
    }

    public void UpdateKey(string apiKey)
    {
        _client.UpdateKey(apiKey);
    }
}