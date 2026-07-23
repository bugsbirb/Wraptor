using Wraptor.Core.Models;

namespace Wraptor.Core.Services.Department;

public class DepartmentService
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
        return WraptorResponse<PaginatedResult<DepartmentInfo>>.FromResponse(
            await _http.GetAsync("/server/departments")
        );
    }

    public async Task<WraptorResponse<DepartmentInfo>> GetDepartmentAsync(string departmentId)
    {
        return WraptorResponse<DepartmentInfo>.FromResponse(
            await _http.GetAsync($"/departments/{departmentId}")
        );
    }
}
