using CiftlikTakip.Model.Dtos.UserAccessPermission;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IUserAccessPermissionBs
    {
        Task<ApiResponse<UserAccessPermissionGetDto>> LogIn(string email, string password, params string[] includeList);
        Task<ApiResponse<UserAccessPermissionGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<UserAccessPermissionGetDto>>> GetUsersAsync(params string[] includeList);
        Task<ApiResponse<UserAccessPermission>> InsertAsync(UserAccessPermissionPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(UserAccessPermissionPutDto dto);
        Task<ApiResponse<NoData>> SDeleteAsync(Guid id);
        Task<ApiResponse<NoData>> RDeleteAsync(Guid id);
    }
}
