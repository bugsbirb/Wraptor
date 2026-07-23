using Wraptor.Core.Models;
using Wraptor.Core.Models.Server;

namespace Wraptor.Core.Services.Server;

public interface IServer
{
    public Task<WraptorResponse<ServerInfo>> GetServerAsync();
}
