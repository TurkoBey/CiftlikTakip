using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IFServiceRepository : IBaseRepository<FService>
    {
        Task<FService> GetByIdAsync(Guid Id, params string[] includeList);
    }
}
