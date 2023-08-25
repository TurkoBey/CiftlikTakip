using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IAnimalStallRepository : IBaseRepository<AnimalStall>
    {
        Task<AnimalStall> GetByIdAsync(Guid Id, params string[] includeList);
        Task<AnimalStall> GetByIdPassiveAsync(Guid Id, params string[] includeList);
    }
}
