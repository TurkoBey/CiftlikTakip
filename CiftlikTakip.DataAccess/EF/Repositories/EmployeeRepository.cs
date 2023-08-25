using CiftlikTakip.DataAccess.EF.Contexts;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Implementations.EF;

namespace CiftlikTakip.DataAccess.EF.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee, FarmHerdContext>, IEmployeeRepository
    {
        public async Task<List<Employee>> GetByEmployeesAsync(Guid employeeId, params string[] includeList)
        {
            return await GetAllAsync(x => x.Id == employeeId && x.IsActive == true, includeList);
        }

        public async Task<Employee> GetByIdAsync(Guid employeeId, params string[] includeList)
        {
            return await GetAsync(x => x.Id == employeeId && x.IsActive == true, includeList);
        }

        public async Task<Employee> GetByIdPassiveAsync(Guid employeeId, params string[] includeList)
        {
            return await GetAsync(x => x.Id == employeeId && x.IsActive == false, includeList);
        }

        public async Task<Employee> GetByTcknAsync(string tckn, params string[] includeList)
        {
            return await GetAsync(x => x.TCKN == tckn, includeList);
        }
    }
}
