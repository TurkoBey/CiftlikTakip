using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface ICompanyRepository : IBaseRepository<Company>
    {
        Task<Company> GetByIdIsActiveAsync(Guid companyId, params string[] includeList);
        Task<Company> GetByIdAsync(Guid companyId, params string[] includeList);
    }
}
