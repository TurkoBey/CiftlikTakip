using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IFFaqRepository : IBaseRepository<FFaq>
    {
        Task<FFaq> GetByIdAsync(Guid Id, params string[] includeList);
    }
}
