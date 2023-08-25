using CiftlikTakip.Model.Dtos.FService;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IFServiceBs
    {
        Task<ApiResponse<FServiceGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<FServiceGetDto>>> GetServicesAsync(params string[] includeList);
        Task<ApiResponse<FServiceGetDto>> InsertAsync(FServicePostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(FServicePutDto dto);
        Task<ApiResponse<NoData>> HDeleteAsync(Guid id);
    }
}
