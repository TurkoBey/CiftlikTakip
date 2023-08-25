using AutoMapper;
using CiftlikTakip.Business.CustomExceptions;
using CiftlikTakip.Business.Implementations.Base;
using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Business.Utilities;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Dtos.AnimalBreed;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Infrastructure.Utilities.CustomExtensions;
using Infrastructure.Utilities.EnumUtilities;
using Microsoft.AspNetCore.Http;
using System.Collections;

namespace CiftlikTakip.Business.Implementations
{
    public class AnimalBreedBs : IAnimalBreedBs
    {
        private readonly IAnimalBreedRepository _repo;
        private readonly IMapper _mapper;

        public AnimalBreedBs(IAnimalBreedRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<ApiResponse<AnimalBreed>> InsertAsync(AnimalBreedPostDto dto)
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
                    var taskAnimalBreed = _mapper.Map<AnimalBreed>(dto);
                    var insertedAnimalBreed = await _repo.InsertAsync(taskAnimalBreed);
                    return ApiResponse<AnimalBreed>.Success(StatusCodes.Status201Created, insertedAnimalBreed);

                }
                throw new BadRequestException("Kaydedilecek adres bilgisi yollamalısınız");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> UpdateAsync(AnimalBreedPutDto dto)
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
                        var updateAnimalBreed = _mapper.Map<AnimalBreed>(dto);
                        await _repo.UpdateAsync(updateAnimalBreed);
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
        public async Task<ApiResponse<NoData>> RDeleteAsync(Guid id)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var taskAnimalBreedId = await _repo.GetByIdPassiveAsync(id);
                if (taskAnimalBreedId != null)
                {
                    taskAnimalBreedId.IsActive = true;
                    taskAnimalBreedId.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    taskAnimalBreedId.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    taskAnimalBreedId.Version = BaseBs.GenerateVersionNumber();
                    await _repo.UpdateAsync(taskAnimalBreedId);
                    return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                }
                throw new NotFoundException("Soft => Aktif edilecek veri bulanamadı, silinmiş veriyi kontrol ediniz.");
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
        public async Task<ApiResponse<AnimalBreedGetDto>> GetByIdAsync(Guid id, params string[] includeList)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var result = await _repo.GetByIdAsync(id, includeList);
                if (result != null)
                {
                    var dto = _mapper.Map<AnimalBreedGetDto>(result);
                    return ApiResponse<AnimalBreedGetDto>.Success(StatusCodes.Status200OK, dto);
                }
                throw new NotFoundException("Aradığınız Id'ye uygun veri bulunamadı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<List<AnimalBreedGetDto>>> GetBreedsAsync(params string[] includeList)
        {
            var result = await _repo.GetAllAsync(x => x.IsActive == true, includeList: includeList);
            if (result.Count > 0)
            {
                var returnList = _mapper.Map<List<AnimalBreedGetDto>>(result);
                return ApiResponse<List<AnimalBreedGetDto>>.Success(200, returnList);
            }
            throw new NotFoundException("İçerik bulanamadı...");
        }
        public async Task<ApiResponse<List<AnimalBreedGetDto>>> GetByBreedTypeAsync(string groupId, params string[] includeList)
        {
            var groupID = LocationTypeExtensions.ConvertToString(groupId.BasHarflerBuyukYap());

            var results = await _repo.GetByBreedTypeNameAsync(groupID);

            if (results != null || results?.Count > 0)
            {
                var returnList = _mapper.Map<List<AnimalBreedGetDto>>(results);
                return ApiResponse<List<AnimalBreedGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik bulunamadı..");
        }
        public async Task<ApiResponse<List<AnimalBreedGetDto>>> GetByTitleAsync(string title, params string[] includeList)
        {
            var results = await _repo.GetByTitleAsync(title.BasHarflerBuyukYap());

            if (results != null || results?.Count > 0)
            {
                var returnList = _mapper.Map<List<AnimalBreedGetDto>>(results);
                return ApiResponse<List<AnimalBreedGetDto>>.Success(StatusCodes.Status200OK, returnList);
            }
            throw new NotFoundException("İçerik bulunamadı..");
        }
    }
}
