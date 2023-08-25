using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IAnimalBreedRepository : IBaseRepository<AnimalBreed>
    {
        Task<List<AnimalBreed>> GetByBreedTypeNameAsync(byte groupId, params string[] includeList);
        Task<List<AnimalBreed>> GetByTitleAsync(string title, params string[] includeList);
        Task<AnimalBreed> GetByIdAsync(Guid Id, params string[] includeList);
        Task<AnimalBreed> GetByIdPassiveAsync(Guid Id, params string[] includeList);
    }
}
