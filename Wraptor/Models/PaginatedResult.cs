using Newtonsoft.Json;

namespace Wraptor.Core.Models;

public class PaginatedResult<T> where T: class
{
    public T? Data { get; private set; }
    
    [JsonProperty("page")]
    public Int64 Page { get; private set; }
    
    [JsonProperty("pageSize")]
    public Int64 PageSize { get; private set; }
    
    [JsonProperty("total")]
    public Int64 Total { get; private set; }
    
    [JsonProperty("totalPages")]
    public Int64 TotalPages { get; private set; }
}