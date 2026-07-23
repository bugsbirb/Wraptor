using Wraptor.Core.Models;

namespace Wraptor.Core.Services.Server;

public interface IServer
{
    public Task<WraptorResponse<ServerInfo>> GetServerAsync();
}
