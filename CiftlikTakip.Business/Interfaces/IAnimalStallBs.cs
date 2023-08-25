using CiftlikTakip.Model.Dtos.AnimalStall;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IAnimalStallBs
    {
        Task<ApiResponse<AnimalStallGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<AnimalStallGetDto>>> GetStallsAsync(params string[] includeList);
        Task<ApiResponse<AnimalStall>> InsertAsync(AnimalStallPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(AnimalStallPutDto dto);
        Task<ApiResponse<NoData>> SDeleteAsync(Guid id);
        Task<ApiResponse<NoData>> RDeleteAsync(Guid id);
    }
}
