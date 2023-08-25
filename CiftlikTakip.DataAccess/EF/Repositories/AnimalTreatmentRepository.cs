using CiftlikTakip.DataAccess.EF.Contexts;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Implementations.EF;

namespace CiftlikTakip.DataAccess.EF.Repositories
{
    public class AnimalTreatmentRepository : BaseRepository<AnimalTreatment, FarmHerdContext>, IAnimalTreatmentRepository
    {
        public async Task<AnimalTreatment> GetByIdAsync(Guid id, params string[] includeList)
        {
            return await GetAsync(c => c.Id == id && c.IsActive == true, includeList);
        }

        public async Task<AnimalTreatment> GetByIdPassiveAsync(Guid id, params string[] includeList)
        {

            return await GetAsync(c => c.Id == id && c.IsActive == false, includeList);
        }
    }
}
