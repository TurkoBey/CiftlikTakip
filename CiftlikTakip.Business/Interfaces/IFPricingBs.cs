using CiftlikTakip.Model.Dtos.FPricing;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IFPricingBs
    {
        Task<ApiResponse<FPricingGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<FPricingGetDto>>> GetPricingsAsync(params string[] includeList);
        Task<ApiResponse<FPricingGetDto>> InsertAsync(FPricingPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(FPricingPutDto dto);
    }
}
