using AutoMapper;
using CiftlikTakip.Business.CustomExceptions;
using CiftlikTakip.Business.Implementations.Base;
using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Business.Utilities;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Dtos.FContact;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System.Collections;

namespace CiftlikTakip.Business.Implementations
{
    public class FContactBs : IFContactBs
    {
        private readonly IFContactRepository _repo;
        private readonly IMapper _mapper;
        public FContactBs(IFContactRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ApiResponse<FContactGetDto>> InsertAsync(FContactPostDto dto)
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
                    var taskFContact = _mapper.Map<FContact>(dto);
                    var insertedFContact = await _repo.InsertAsync(taskFContact);

                    var retCat = _mapper.Map<FContactGetDto>(insertedFContact);

                    return ApiResponse<FContactGetDto>.Success(StatusCodes.Status201Created, retCat);
                }
                throw new BadRequestException("Kaydedilecek adres bilgisi yollamalısınız");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> UpdateAsync(FContactPutDto dto)
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
                        var updateFContact = _mapper.Map<FContact>(dto);
                        await _repo.UpdateAsync(updateFContact);
                        return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                    }
                    throw new BadRequestException("Veri başka bir kullanıcı tarafından güncellenmiş. Lütfen sayfayı yenileyerek tekrar deneyin.");
                }
                throw new NotFoundException("Güncellenecek veri bulanamadı, güncellemek istediğiniz veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> SDeleteAsync(Guid id)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var taskAnimalBreedId = await _repo.GetByIdAsync(id);
                if (taskAnimalBreedId != null)
                {
                    taskAnimalBreedId.IsActive = false;
                    taskAnimalBreedId.DeleteDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    taskAnimalBreedId.DeleteBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    taskAnimalBreedId.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    taskAnimalBreedId.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    taskAnimalBreedId.Version = BaseBs.GenerateVersionNumber();
                    await _repo.UpdateAsync(taskAnimalBreedId);
                    return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                }
                throw new NotFoundException("Soft => Silinecek veri bulanamadı, silmek istediğiniz veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<FContactGetDto>> GetByIdAsync(Guid id, params string[] includeList)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var result = await _repo.GetByIdAsync(id, includeList);
                if (result != null)
                {
                    var dto = _mapper.Map<FContactGetDto>(result);
                    return ApiResponse<FContactGetDto>.Success(StatusCodes.Status200OK, dto);
                }
                throw new NotFoundException("Aradığınız Id'ye uygun veri bulunamadı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<List<FContactGetDto>>> GetContactsAsync(params string[] includeList)
        {
            var result = await _repo.GetAllAsync(x => x.IsActive == true, includeList: includeList);
            if (result.Count > 0)
            {
                var returnList = _mapper.Map<List<FContactGetDto>>(result);
                return ApiResponse<List<FContactGetDto>>.Success(200, returnList);
            }
            throw new NotFoundException("İçerik bulanamadı...");
        }
    }
}
