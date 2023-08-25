using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IWebsiteInfoRepository : IBaseRepository<WebsiteInfo>
    {
        Task<WebsiteInfo> GetByIdAsync(Guid Id, params string[] includeList);
    }
}