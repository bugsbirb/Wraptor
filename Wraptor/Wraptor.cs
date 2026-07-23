using Wraptor.Core.Services;
using Wraptor.Core.Services.Department;
using Wraptor.Core.Services.Health;
using Wraptor.Core.Services.Ratelimit;
using Wraptor.Core.Services.Server;
using Wraptor.Core.Services.Verification;

namespace Wraptor.Core;

public class WraptorClient
{
    private readonly WraptorHttp _client;

    public IHealth Health { get; set; }
    public IRatelimit Ratelimit { get; set; }
    public IVerification Verification { get; set; }
    public IServer Server { get; set; }
    public IDepartment Department { get; set; }

    public WraptorClient(WraptorOptions options)
    {
        _client = new WraptorHttp(options);

        Health = new HealthService(_client);
        Ratelimit = new RatelimitService(_client);
        Verification = new VerificationService(_client);
        Server = new ServerService(_client);
        Department = new DepartmentService(_client);
    }

    public void UpdateKey(string apiKey)
    {
        _client.UpdateKey(apiKey);
    }
}
