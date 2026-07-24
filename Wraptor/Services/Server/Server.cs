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

    public async Task<WraptorResponse<PaginatedResult<Member>>> GetMembersAsync(
        PaginationProperties properties
    )
    {
        string query = new PaginationQuery().Params(properties);

        return WraptorResponse<PaginatedResult<Member>>.FromResponse(
            await _http.GetAsync("/server/members" + query)
        );
    }

    public async Task<WraptorResponse<PaginatedResult<Member>>> GetMemberAsync(string memberId)
    {
        return WraptorResponse<PaginatedResult<Member>>.FromResponse(
            await _http.GetAsync("/server/members/" + memberId)
        );
    }

    public async Task<WraptorResponse<PaginatedResult<Member>>> GetMemberByDiscordAsync(
        string discordId
    )
    {
        return WraptorResponse<PaginatedResult<Member>>.FromResponse(
            await _http.GetAsync("/server/members/discord/" + discordId)
        );
    }

    public async Task<WraptorResponse<DiscordMember>> GetMemberDiscordAsync(string memberId)
    {
        return WraptorResponse<DiscordMember>.FromResponse(
            await _http.GetAsync($"/server/members/{memberId}/discord")
        );
    }
}
