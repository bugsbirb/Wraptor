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
        string? sort,
        string? orderBy,
        Int64? page = 1,
        Int64? pageSize = 10,
        Int64? limit = 10
    )
    {
        List<string> queryParams = [];

        if (!string.IsNullOrWhiteSpace(sort))
            queryParams.Add(nameof(sort));
        if (!string.IsNullOrWhiteSpace(orderBy))
            queryParams.Add(nameof(orderBy));
        if (page.HasValue)
            queryParams.Add(nameof(page));
        if (pageSize.HasValue)
            queryParams.Add(nameof(pageSize));
        if (limit.HasValue)
            queryParams.Add(nameof(limit));

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
