using CiftlikTakip.Model.Dtos.Company;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;

namespace CiftlikTakip.Business.Interfaces
{
    public interface ICompanyBs
    {
        Task<ApiResponse<CompanyGetDto>> GetByIdAsync(Guid id, params string[] includeList);
        Task<ApiResponse<List<CompanyGetDto>>> GetCompaniesAsync(params string[] includeList);
        Task<ApiResponse<List<CompanyGetDto>>> GetByCompanyNameAsync(string companyName);
        Task<ApiResponse<Company>> InsertAsync(CompanyPostDto dto);
        Task<ApiResponse<NoData>> UpdateAsync(CompanyPutDto dto);
        Task<ApiResponse<NoData>> SDeleteAsync(Guid id);
        Task<ApiResponse<NoData>> RDeleteAsync(Guid id);
        Task<ApiResponse<NoData>> HDeleteAsync(Guid id);
    }
}
