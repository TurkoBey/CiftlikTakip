using CiftlikTakip.DataAccess.EF.Contexts;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Implementations.EF;

namespace CiftlikTakip.DataAccess.EF.Repositories
{
    public class FPricingRepository : BaseRepository<FPricing, FarmHerdContext>, IFPricingRepository
    {
        public async Task<FPricing> GetByIdAsync(Guid Id, params string[] includeList)
        {
            return await GetAsync(x => x.Id == Id && x.IsActive == true, includeList);
        }
    }
}
