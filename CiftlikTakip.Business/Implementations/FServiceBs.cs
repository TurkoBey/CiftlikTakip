using AutoMapper;
using CiftlikTakip.Business.CustomExceptions;
using CiftlikTakip.Business.Implementations.Base;
using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Business.Utilities;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Dtos.FService;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System.Collections;

namespace CiftlikTakip.Business.Implementations
{
    public class FServiceBs : IFServiceBs
    {
        private readonly IFServiceRepository _repo;
        private readonly IMapper _mapper;
        public FServiceBs(IFServiceRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ApiResponse<FServiceGetDto>> InsertAsync(FServicePostDto dto)
        {
            if (ValidationHelper<Guid>.IsGuid(dto.Id))
            {
                if (dto != null)
                {
                    dto.CreationDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    dto.CreatedBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    dto.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    dto.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    dto.Version = BaseBs.GenerateVersionNumber();
                    dto.IsActive = true;
                    var taskFService = _mapper.Map<FService>(dto);
                    var insertedFService = await _repo.InsertAsync(taskFService);

                    var retCat = _mapper.Map<FServiceGetDto>(insertedFService);

                    return ApiResponse<FServiceGetDto>.Success(StatusCodes.Status201Created, retCat);
                }
                throw new BadRequestException("Kaydedilecek adres bilgisi yollamalısınız");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> UpdateAsync(FServicePutDto dto)
        {
            if (ValidationHelper<Guid>.IsGuid(dto.Id))
            {
                var itemId = await _repo.GetByIdAsync(dto.Id);
                if (itemId != null)
                {
                    if (!StructuralComparisons.StructuralEqualityComparer.Equals(dto.Version, ConvertorHelper.ByteArrayToString(itemId.Version)))
                    {
                        dto.CreatedBy = itemId.CreatedBy;
                        dto.CreationDate = itemId.CreationDate;
                        dto.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                        dto.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                        dto.Version = BaseBs.GenerateVersionNumber();
                        dto.IsActive = true;
                        var updateFService = _mapper.Map<FService>(dto);
                        await _repo.UpdateAsync(updateFService);
                        return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                    }
                    throw new BadRequestException("Veri başka bir kullanıcı tarafından güncellenmiş. Lütfen sayfayı yenileyerek tekrar deneyin.");
                }
                throw new NotFoundException("Güncellenecek veri bulanamadı, güncellemek istediğiniz veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> HDeleteAsync(Guid id)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var result = await _repo.GetByIdAsync(id);
                if (result != null)
                {
                    await _repo.DeleteAsync(result);
                    return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                }
                throw new BadRequestException("Girilen id'ye göre uygun bir içerik bulunamadı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<FServiceGetDto>> GetByIdAsync(Guid id, params string[] includeList)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var result = await _repo.GetByIdAsync(id, includeList);
                if (result != null)
                {
                    var dto = _mapper.Map<FServiceGetDto>(result);
                    return ApiResponse<FServiceGetDto>.Success(StatusCodes.Status200OK, dto);
                }
                throw new NotFoundException("Aradığınız Id'ye uygun veri bulunamadı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<List<FServiceGetDto>>> GetServicesAsync(params string[] includeList)
        {
            var result = await _repo.GetAllAsync(x => x.IsActive == true, includeList: includeList);
            if (result.Count > 0)
            {
                var returnList = _mapper.Map<List<FServiceGetDto>>(result);
                return ApiResponse<List<FServiceGetDto>>.Success(200, returnList);
            }
            throw new NotFoundException("İçerik bulanamadı...");
        }
       
    }
}
