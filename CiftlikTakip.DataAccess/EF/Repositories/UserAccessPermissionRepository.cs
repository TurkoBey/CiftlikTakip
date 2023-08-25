using CiftlikTakip.DataAccess.EF.Contexts;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Implementations.EF;

namespace CiftlikTakip.DataAccess.EF.Repositories
{
    public class UserAccessPermissionRepository : BaseRepository<UserAccessPermission, FarmHerdContext>, IUserAccessPermissionRepository
    {
        public async Task<UserAccessPermission> GetByIdAsync(Guid id, params string[] includeList)
        {
            return await GetAsync(x => x.Id == id && x.IsActive == true);
        }

        public async Task<UserAccessPermission> GetByIdPassiveAsync(Guid id, params string[] includeList)
        {
            return await GetAsync(x => x.Id == id && x.IsActive == false);
        }

        public async Task<UserAccessPermission> GetByMailPassAsync(string email, string password, params string[] includeList)
        {
            return await GetAsync(x => x.Email == email && x.Password == password && x.IsActive == true, includeList);
        }

        public async Task<List<UserAccessPermission>> GetByUserIdAsync(Guid Id, params string[] includeList)
        {
            return await GetAllAsync(x => x.Id == Id && x.IsActive == true);
        }
    }
}
