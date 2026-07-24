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
        string query = new PaginationQuery().Params(properties);

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
