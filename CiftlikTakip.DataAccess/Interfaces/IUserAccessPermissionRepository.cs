using CiftlikTakip.Model.Entities;
using Infrastructure.DataAccess.Interfaces;

namespace CiftlikTakip.DataAccess.Interfaces
{
    public interface IUserAccessPermissionRepository : IBaseRepository<UserAccessPermission>
    {
        Task<UserAccessPermission> GetByMailPassAsync(string email, string password, params string[] includeList);
        Task<UserAccessPermission> GetByIdAsync(Guid id, params string[] includeList);
        Task<UserAccessPermission> GetByIdPassiveAsync(Guid id, params string[] includeList);
        Task<List<UserAccessPermission>> GetByUserIdAsync(Guid Id, params string[] includeList);
    }
}
