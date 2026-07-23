using Wraptor.Core.Models;
using Wraptor.Core.Models.Server;

namespace Wraptor.Core.Services.Server;

public class ServerService : IServer
{
    private readonly WraptorHttp _http;

    internal ServerService(WraptorHttp http)
    {
        _http = http;
    }

    public async Task<WraptorResponse<ServerInfo>> GetServerAsync()
    {
        return WraptorResponse<ServerInfo>.FromResponse(await _http.GetAsync("/server/info"));
    }
}
