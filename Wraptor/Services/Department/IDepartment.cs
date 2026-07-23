using Wraptor.Core.Models;
using Wraptor.Core.Models.Departments;

namespace Wraptor.Core.Services.Department;

public interface IDepartment
{
    /// <summary>
    /// Get a list of departments owned by the authenticated server
    /// </summary>
    /// <param name="sort"></param>
    /// <param name="orderBy"></param>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <param name="limit"></param>
    /// <returns></returns>
    Task<WraptorResponse<PaginatedResult<DepartmentInfo>>> GetDepartmentsAsync(
        string? sort = null,
        string? orderBy = null,
        Int64? page = 1,
        Int64? pageSize = 10,
        Int64? limit = 10
    );

    /// <summary>
    /// Get a department that is owned by the authenticated server
    /// </summary>
    /// <param name="departmentId"></param>
    /// <returns></returns>
    Task<WraptorResponse<DepartmentInfo>> GetDepartmentAsync(string departmentId);
}
