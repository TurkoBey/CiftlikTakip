using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<List<Employee>> GetByEmployeesAsync(Guid employeeId, params string[] includeList);
        Task<Employee> GetByIdAsync(Guid employeeId, params string[] includeList);
        Task<Employee> GetByIdPassiveAsync(Guid employeeId, params string[] includeList);
        Task<Employee> GetByTcknAsync(string tckn, params string[] includeList);
    }
}
