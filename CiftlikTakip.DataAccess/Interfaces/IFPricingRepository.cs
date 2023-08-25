using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IFPricingRepository : IBaseRepository<FPricing>
    {
        Task<FPricing> GetByIdAsync(Guid Id, params string[] includeList);
    }
}
