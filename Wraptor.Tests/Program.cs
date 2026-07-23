using Wraptor.Core;
using Wraptor.Core.Models;
using Wraptor.Core.Services;

WraptorOptions options = new() { ApiKey = "blah" };
WraptorClient client = new(options);

await client.Health.GetMetricsAsync();
RobloxUser? e = await client.Verification.DiscordToRobloxAsync("795743076520820776");

Console.WriteLine(e.CreatedAt);
