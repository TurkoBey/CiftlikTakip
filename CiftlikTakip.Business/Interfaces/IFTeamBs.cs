using CiftlikTakip.Model.Dtos.FTeam;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IFTeamBs
    {
        Task<ApiResponse<FTeamGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<FTeamGetDto>>> GetTeamsAsync(params string[] includeList);
        Task<ApiResponse<FTeamGetDto>> InsertAsync(FTeamPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(FTeamPutDto dto);
        Task<ApiResponse<NoData>> SDeleteAsync(Guid id);
    }
}
