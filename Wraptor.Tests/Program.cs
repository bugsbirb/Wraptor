using Wraptor.Core;
using Wraptor.Core.Models;
using Wraptor.Core.Services;

WraptorOptions options = new(){ ApiKey = "blah" };
WraptorClient client = new(options);

await client.Health.Metrics();
RobloxUser? e = await client.Verification.DiscordToRoblox("795743076520820776");

Console.WriteLine(e.CreatedAt);