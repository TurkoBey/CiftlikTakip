using CiftlikTakip.Model.Dtos.FFaq;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IFFaqBs
    {
        Task<ApiResponse<FFaqGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<FFaqGetDto>>> GetFaqsAsync(params string[] includeList);
        Task<ApiResponse<FFaqGetDto>> InsertAsync(FFaqPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(FFaqPutDto dto);
        Task<ApiResponse<NoData>> HDeleteAsync(Guid id);
    }
}