using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IAnimalTreatmentRepository : IBaseRepository<AnimalTreatment>
    {
        Task<AnimalTreatment> GetByIdAsync(Guid id, params string[] includeList);
        Task<AnimalTreatment> GetByIdPassiveAsync(Guid id, params string[] includeList);
    }
}
