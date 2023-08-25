using CiftlikTakip.Model.Dtos.Employee;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IEmployeeBs
    {
        Task<ApiResponse<EmployeeGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<EmployeeGetDto>> GetByTcknAsync(string tckn, params string[] includeList);
        Task<ApiResponse<List<EmployeeGetDto>>> GetEmployeesAsync(params string[] includeList);
        Task<ApiResponse<Employee>> InsertAsync(EmployeePostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(EmployeePutDto dto);
        Task<ApiResponse<NoData>> SDeleteAsync(Guid id);
        Task<ApiResponse<NoData>> RDeleteAsync(Guid id);
    }
}
