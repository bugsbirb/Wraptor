using System.Text.Json.Serialization;

namespace Wraptor.Models;

public class PaginatedResult<T> where T: class
{
    public T? Data { get; private set; }
    
    [JsonPropertyName("page")]
    public Int64 Page { get; private set; }
    
    [JsonPropertyName("pageSize")]
    public Int64 PageSize { get; private set; }
    
    [JsonPropertyName("total")]
    public Int64 Total { get; private set; }
    
    [JsonPropertyName("totalPages")]
    public Int64 TotalPages { get; private set; }
}