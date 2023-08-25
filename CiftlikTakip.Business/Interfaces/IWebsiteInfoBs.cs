using CiftlikTakip.Model.Dtos.WebsiteInfo;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IWebsiteInfoBs
    {
        Task<ApiResponse<WebsiteInfoGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<NoData>> UpdateAsync(WebsiteInfoPutDto dto);
    }
}
