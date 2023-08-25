using CiftlikTakip.DataAccess.EF.Contexts;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Implementations.EF;

namespace CiftlikTakip.DataAccess.EF.Repositories
{
    public class WebsiteInfoRepository : BaseRepository<WebsiteInfo, FarmHerdContext>, IWebsiteInfoRepository
    {
        public async Task<WebsiteInfo> GetByIdAsync(Guid Id, params string[] includeList)
        {
            return await GetAsync(c => c.Id == Id && c.IsActive == true, includeList);
        }
    }
}
