using AutoMapper;
using CiftlikTakip.Business.CustomExceptions;
using CiftlikTakip.Business.Implementations.Base;
using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Business.Utilities;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Dtos.BreedingRecord;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System.Collections;

namespace CiftlikTakip.Business.Implementations
{
    public class BreedingRecordBs : IBreedingRecordBs
    {
        private readonly IBreedingRecordRepository _repo;
        private readonly IMapper _mapper;
        public BreedingRecordBs(IBreedingRecordRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<ApiResponse<BreedingRecord>> InsertAsync(BreedingRecordPostDto dto)
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
                    var taskBreedingRecord = _mapper.Map<BreedingRecord>(dto);
                    var insertedBreedingRecord = await _repo.InsertAsync(taskBreedingRecord);
                    return ApiResponse<BreedingRecord>.Success(StatusCodes.Status201Created, insertedBreedingRecord);

                }
                throw new BadRequestException("Kaydedilecek adres bilgisi yollamalısınız");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> UpdateAsync(BreedingRecordPutDto dto)
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
                        var updatetask = _mapper.Map<BreedingRecord>(dto);
                        await _repo.UpdateAsync(updatetask);
                        return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                    }
                    throw new BadRequestException("Veri başka bir kullanıcı tarafından güncellenmiş. Lütfen sayfayı yenileyerek tekrar deneyin.");
                }
                throw new NotFoundException("Güncellenecek veri bulanamadı, güncellemek istediğiniz veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> RDeleteAsync(Guid id)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var taskId = await _repo.GetByIdPassiveAsync(id);
                if (taskId != null)
                {
                    taskId.IsActive = true;
                    taskId.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    taskId.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    taskId.Version = BaseBs.GenerateVersionNumber();
                    await _repo.UpdateAsync(taskId);
                    return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                }
                throw new NotFoundException("Soft => Aktif edilecek veri bulanamadı, silinmiş veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> SDeleteAsync(Guid id)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var taskId = await _repo.GetByIdAsync(id);
                if (taskId != null)
                {
                    taskId.IsActive = false;
                    taskId.DeleteDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    taskId.DeleteBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    taskId.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    taskId.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    taskId.Version = BaseBs.GenerateVersionNumber();
                    await _repo.UpdateAsync(taskId);
                    return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                }
                throw new NotFoundException("Soft => Silinecek veri bulanamadı, silmek istediğiniz veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<BreedingRecordGetDto>> GetByIdAsync(Guid id, params string[] includeList)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var result = await _repo.GetByIdAsync(id, includeList);
                if (result != null)
                {
                    var dto = _mapper.Map<BreedingRecordGetDto>(result);
                    return ApiResponse<BreedingRecordGetDto>.Success(StatusCodes.Status200OK, dto);
                }
                throw new NotFoundException("Aradığınız Id'ye uygun veri bulunamadı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<List<BreedingRecordGetDto>>> GetBreedsAsync(params string[] includeList)
        {
            var result = await _repo.GetAllAsync(x => x.IsActive == true, includeList: includeList);
            if (result.Count > 0)
            {
                var returnList = _mapper.Map<List<BreedingRecordGetDto>>(result);
                return ApiResponse<List<BreedingRecordGetDto>>.Success(200, returnList);
            }
            throw new NotFoundException("İçerik bulanamadı...");
        }  
    }
}
