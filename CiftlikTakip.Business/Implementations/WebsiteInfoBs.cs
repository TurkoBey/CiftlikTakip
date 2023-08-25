using AutoMapper;
using CiftlikTakip.Business.CustomExceptions;
using CiftlikTakip.Business.Implementations.Base;
using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Business.Utilities;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Dtos.WebsiteInfo;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System.Collections;

namespace CiftlikTakip.Business.Implementations
{
    public class WebsiteInfoBs : IWebsiteInfoBs
    {
        private readonly IWebsiteInfoRepository _repo;
        private readonly IMapper _mapper;

        public WebsiteInfoBs(IWebsiteInfoRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ApiResponse<WebsiteInfoGetDto>> GetByIdAsync(Guid id, params string[] includeList)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var product = await _repo.GetByIdAsync(id, includeList);
                if (product != null)
                {
                    var dto = _mapper.Map<WebsiteInfoGetDto>(product);
                    return ApiResponse<WebsiteInfoGetDto>.Success(StatusCodes.Status200OK, dto);
                }
                throw new NotFoundException("İçerik Bulunamadı");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        //public async Task<ApiResponse<List<WebsiteInfoGetDto>>> GetWebInfosAsync(params string[] includeList)
        //{
        //    var result = await _repo.GetAllAsync(x => x.IsActive == true, includeList: includeList);
        //    if (result.Count > 0)
        //    {
        //        var returnList = _mapper.Map<List<WebsiteInfoGetDto>>(result);
        //        return ApiResponse<List<WebsiteInfoGetDto>>.Success(200, returnList);
        //    }
        //    throw new NotFoundException("İçerik bulanamadı...");
        //}
        public async Task<ApiResponse<NoData>> UpdateAsync(WebsiteInfoPutDto dto)
        {
            if (ValidationHelper<Guid>.IsGuid(dto.Id))
            {
                var repoId = await _repo.GetByIdAsync(dto.Id);
                if (repoId != null)
                {
                    if (StructuralComparisons.StructuralEqualityComparer.Equals(dto.Version, ConvertorHelper.ByteArrayToString(repoId.Version)))
                    {
                        throw new BadRequestException("Veri başka bir kullanıcı tarafından güncellenmiş. Lütfen sayfayı yenileyerek tekrar deneyin.");
                    }
                    dto.CreatedBy = repoId.CreatedBy;
                    dto.CreationDate = repoId.CreationDate;
                    dto.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    dto.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    dto.Version = BaseBs.GenerateVersionNumber();
                    dto.IsActive = true;
                    var updateAddress = _mapper.Map<WebsiteInfo>(dto);
                    await _repo.UpdateAsync(updateAddress);
                    return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                }
                throw new NotFoundException("Aradığınız veri bulunamadı, güncellemek istediğiniz verileri kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
    }
}
