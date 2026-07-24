using Wraptor.Core.Models;
using Wraptor.Core.Models.Departments;

namespace Wraptor.Core.Services.Department;

public class DepartmentService : IDepartment
{
    private readonly WraptorHttp _http;

    internal DepartmentService(WraptorHttp http)
    {
        _http = http;
    }

    public async Task<WraptorResponse<PaginatedResult<DepartmentInfo>>> GetDepartmentsAsync(
        PaginationProperties properties
    )
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

        return WraptorResponse<PaginatedResult<DepartmentInfo>>.FromResponse(
            await _http.GetAsync("/server/departments" + query)
        );
    }

    public async Task<WraptorResponse<DepartmentInfo>> GetDepartmentAsync(string departmentId)
    {
        return WraptorResponse<DepartmentInfo>.FromResponse(
            await _http.GetAsync($"/departments/{departmentId}")
        );
    }
}
