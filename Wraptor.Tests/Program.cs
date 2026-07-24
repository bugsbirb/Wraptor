using Wraptor.Core;
using Wraptor.Core.Models;
using Wraptor.Core.Models.Verification;
using Wraptor.Core.Services;

WraptorOptions options = new() { ApiKey = "blah" };
WraptorClient client = new(options);

await client.Health.GetMetricsAsync();
await client.Department.GetDepartmentAsync("123");
await client.Department.GetDepartmentsAsync(new PaginationProperties { Page = 1 });
await client.Webhook.PostAsync("https://workflows.melonly.xyz/webhook/x/x", new { e = "hi" });

RobloxUser? e = await client.Verification.DiscordToRobloxAsync("795743076520820776");

Console.WriteLine(e.CreatedAt);
