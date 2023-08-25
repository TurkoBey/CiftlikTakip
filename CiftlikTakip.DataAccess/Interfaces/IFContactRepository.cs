using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IFContactRepository : IBaseRepository<FContact>
    {
        Task<FContact> GetByIdAsync(Guid Id, params string[] includeList);
    }
}
