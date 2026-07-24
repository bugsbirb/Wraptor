namespace Wraptor.Core.Models;

public class PaginationQuery
{
    public string Params(PaginationProperties properties)
    {
        List<string> queryParams = [];

        if (!string.IsNullOrWhiteSpace(properties.Sort))
            queryParams.Add(nameof(properties.Sort));
        if (!string.IsNullOrWhiteSpace(properties.OrderBy))
            queryParams.Add(nameof(properties.OrderBy));
        if (properties.Page.HasValue)
            queryParams.Add(nameof(properties.Page));
        if (properties.PageSize.HasValue)
            queryParams.Add(nameof(properties.PageSize));
        if (properties.Limit.HasValue)
            queryParams.Add(nameof(properties.Limit));

        string query = queryParams.Any() ? "?" + string.Join("&", queryParams) : "";
        return query;
    }
}
