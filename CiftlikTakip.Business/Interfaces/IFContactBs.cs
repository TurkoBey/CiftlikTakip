using CiftlikTakip.Model.Dtos.FContact;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IFContactBs
    {
        Task<ApiResponse<FContactGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<FContactGetDto>>> GetContactsAsync(params string[] includeList);
        Task<ApiResponse<FContactGetDto>> InsertAsync(FContactPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(FContactPutDto dto);
        Task<ApiResponse<NoData>> SDeleteAsync(Guid id);
    }
}
