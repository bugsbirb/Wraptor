using System.Collections;
using Newtonsoft.Json;

namespace Wraptor.Core.Models;

[JsonObject]
public class PaginatedResult<T> : IEnumerable<T>
    where T : class
{
    [JsonProperty("data")]
    public List<T> Data { get; private set; } = new();

    [JsonProperty("page")]
    public long Page { get; private set; }

    [JsonProperty("pageSize")]
    public long PageSize { get; private set; }

    [JsonProperty("total")]
    public long Total { get; private set; }

    [JsonProperty("totalPages")]
    public long TotalPages { get; private set; }

    public IEnumerator<T> GetEnumerator() => Data.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
