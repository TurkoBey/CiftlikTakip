using CiftlikTakip.Model.Dtos.BreedingRecord;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IBreedingRecordBs
    {
        Task<ApiResponse<BreedingRecordGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<BreedingRecordGetDto>>> GetBreedsAsync(params string[] includeList);
        Task<ApiResponse<BreedingRecord>> InsertAsync(BreedingRecordPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(BreedingRecordPutDto dto);
        Task<ApiResponse<NoData>> SDeleteAsync(Guid id);
        Task<ApiResponse<NoData>> RDeleteAsync(Guid id);
    }
}
