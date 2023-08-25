using CiftlikTakip.DataAccess.EF.Contexts;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Implementations.EF;

namespace CiftlikTakip.DataAccess.EF.Repositories
{
    public class CompanyRepository : BaseRepository<Company, FarmHerdContext>, ICompanyRepository
    {
        public async Task<Company> GetByIdIsActiveAsync(Guid companyId, params string[] includeList)
        {
            return await GetAsync(x => x.Id == companyId && x.IsActive == true, includeList);
        }
        public async Task<Company> GetByIdAsync(Guid companyId, params string[] includeList)
        {
            return await GetAsync(x => x.Id == companyId && x.IsActive == true, includeList);
        }
    }
}
