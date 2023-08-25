using CiftlikTakip.Model.Dtos.AnimalBreed;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface IAnimalBreedBs
    {
        Task<ApiResponse<AnimalBreedGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<AnimalBreedGetDto>>> GetBreedsAsync(params string[] includeList);
        Task<ApiResponse<List<AnimalBreedGetDto>>> GetByBreedTypeAsync(string groupId, params string[] includeList);
        Task<ApiResponse<List<AnimalBreedGetDto>>> GetByTitleAsync(string title, params string[] includeList);
        Task<ApiResponse<AnimalBreed>> InsertAsync(AnimalBreedPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(AnimalBreedPutDto dto);
        Task<ApiResponse<NoData>> SDeleteAsync(Guid id);
        Task<ApiResponse<NoData>> RDeleteAsync(Guid id);
        Task<ApiResponse<NoData>> HDeleteAsync(Guid id);
    }
}
