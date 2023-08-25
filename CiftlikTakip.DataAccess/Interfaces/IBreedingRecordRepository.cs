using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IBreedingRecordRepository : IBaseRepository<BreedingRecord>
    {
        Task<BreedingRecord> GetByIdAsync(Guid id, params string[] includeList);
        Task<BreedingRecord> GetByIdPassiveAsync(Guid Id, params string[] includeList);
    }
}
