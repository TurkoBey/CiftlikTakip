using AutoMapper;
using CiftlikTakip.Business.CustomExceptions;
using CiftlikTakip.Business.Implementations.Base;
using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Business.Utilities;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Dtos.FFaq;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System.Collections;

namespace CiftlikTakip.Business.Implementations
{
    public class FFaqBs : IFFaqBs
    {
        private readonly IFFaqRepository _repo;
        private readonly IMapper _mapper;
        public FFaqBs(IFFaqRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<ApiResponse<FFaqGetDto>> InsertAsync(FFaqPostDto dto)
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
                    var taskFFaq = _mapper.Map<FFaq>(dto);
                    var insertedFFaq = await _repo.InsertAsync(taskFFaq);

                    var retCat = _mapper.Map<FFaqGetDto>(insertedFFaq);

                    return ApiResponse<FFaqGetDto>.Success(StatusCodes.Status201Created, retCat);
                }
                throw new BadRequestException("Kaydedilecek adres bilgisi yollamalısınız");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> UpdateAsync(FFaqPutDto dto)
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
                        var updateFFaq = _mapper.Map<FFaq>(dto);
                        await _repo.UpdateAsync(updateFFaq);
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
        public async Task<ApiResponse<FFaqGetDto>> GetByIdAsync(Guid id, params string[] includeList)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var result = await _repo.GetByIdAsync(id, includeList);
                if (result != null)
                {
                    var dto = _mapper.Map<FFaqGetDto>(result);
                    return ApiResponse<FFaqGetDto>.Success(StatusCodes.Status200OK, dto);
                }
                throw new NotFoundException("Aradığınız Id'ye uygun veri bulunamadı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<List<FFaqGetDto>>> GetFaqsAsync(params string[] includeList)
        {
            var result = await _repo.GetAllAsync(x => x.IsActive == true, includeList: includeList);
            if (result.Count > 0)
            {
                var returnList = _mapper.Map<List<FFaqGetDto>>(result);
                return ApiResponse<List<FFaqGetDto>>.Success(200, returnList);
            }
            throw new NotFoundException("İçerik bulanamadı...");
        }
    }
}