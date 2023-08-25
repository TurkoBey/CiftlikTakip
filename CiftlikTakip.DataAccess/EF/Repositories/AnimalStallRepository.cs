using CiftlikTakip.DataAccess.EF.Contexts;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Implementations.EF;

namespace CiftlikTakip.DataAccess.EF.Repositories
{
    public class AnimalStallRepository : BaseRepository<AnimalStall, FarmHerdContext>, IAnimalStallRepository
    {
        public async Task<AnimalStall> GetByIdAsync(Guid id, params string[] includeList)
        {
            return await GetAsync(c => c.Id == id && c.IsActive == true, includeList);
        }

        public async Task<AnimalStall> GetByIdPassiveAsync(Guid Id, params string[] includeList)
        {
            return await GetAsync(c => c.Id == Id && c.IsActive == false, includeList);
        }
    }
}
