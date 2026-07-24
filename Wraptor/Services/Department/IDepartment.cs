using Wraptor.Core.Models;
using Wraptor.Core.Models.Departments;

namespace Wraptor.Core.Services.Department;

public interface IDepartment
{
    /// <summary>
    /// Get a list of departments owned by the authenticated server
    /// </summary>
    /// <param name="properties"></param>
    /// <returns></returns>
    Task<WraptorResponse<PaginatedResult<DepartmentInfo>>> GetDepartmentsAsync(
        PaginationProperties properties
    );

    /// <summary>
    /// Get a department that is owned by the authenticated server
    /// </summary>
    /// <param name="departmentId"></param>
    /// <returns></returns>
    Task<WraptorResponse<DepartmentInfo>> GetDepartmentAsync(string departmentId);
}
