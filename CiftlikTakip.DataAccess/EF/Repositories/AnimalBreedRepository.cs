using CiftlikTakip.DataAccess.EF.Contexts;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Implementations.EF;

namespace CiftlikTakip.DataAccess.EF.Repositories
{
    public class AnimalBreedRepository : BaseRepository<AnimalBreed, FarmHerdContext>, IAnimalBreedRepository
    {
        public async Task<List<AnimalBreed>> GetByBreedTypeNameAsync(byte groupId, params string[] includeList)
        {
            return await GetAllAsync(x => x.GroupId == groupId && x.IsActive == true);
        }

        public async Task<AnimalBreed> GetByIdAsync(Guid Id, params string[] includeList)
        {
            return await GetAsync(x => x.Id == Id && x.IsActive == true, includeList);
        }
        public async Task<AnimalBreed> GetByIdPassiveAsync(Guid Id, params string[] includeList)
        {
            return await GetAsync(x => x.Id == Id && x.IsActive == false, includeList);
        }

        public async Task<List<AnimalBreed>> GetByTitleAsync(string title, params string[] includeList)
        {
            return await GetAllAsync(x => x.Title == title && x.IsActive == true);
        }
    }
}
