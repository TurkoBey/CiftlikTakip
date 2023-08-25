using CiftlikTakip.Model.Dtos.AnimalTreatment;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IAnimalTreatmentBs
    {
        Task<ApiResponse<AnimalTreatmentGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<AnimalTreatmentGetDto>>> GetTreatmentsAsync(params string[] includeList);
        Task<ApiResponse<AnimalTreatment>> InsertAsync(AnimalTreatmentPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(AnimalTreatmentPutDto dto);
        Task<ApiResponse<NoData>> SDeleteAsync(Guid id);
        Task<ApiResponse<NoData>> RDeleteAsync(Guid id);
    }
}
