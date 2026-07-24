namespace Wraptor.Core.Models;

public class PaginationProperties
{
    public string? Sort { get; set; }
    public string? OrderBy { get; set; }
    public long? Page { get; set; } = 1;
    public long? PageSize { get; set; } = 10;
    public long? Limit { get; set; } = 10;
}
