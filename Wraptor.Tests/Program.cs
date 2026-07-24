using Wraptor.Core;
using Wraptor.Core.Models;
using Wraptor.Core.Models.Server;
using Wraptor.Core.Services;

WraptorOptions options = new() { ApiKey = "", BaseUrl = "https://api.melonly.xyz/api/v1/" };
WraptorClient client = new(options);

var members = await client.Server.GetMembersAsync();
foreach (Member member in members.EnsureData())
{
    List<string> criminals = new() { "459374864067723275", "288031235455057920" };
    DiscordMember? discordMember = await client.Server.GetMemberDiscordAsync(member.Id);
    if (discordMember == null)
    {
        continue;
    }

    if (criminals.Contains(discordMember.DiscordId))
    {
        Console.WriteLine($"Criminal spotted - {member.Id} ({discordMember.DiscordId})");
    }
    else
    {
        Console.WriteLine($"Not a criminal - {member.Id} ({discordMember.DiscordId})");
    }
}
