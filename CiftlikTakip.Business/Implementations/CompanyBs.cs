using AutoMapper;
using CiftlikTakip.Business.CustomExceptions;
using CiftlikTakip.Business.Implementations.Base;
using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Business.Utilities;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Dtos.Company;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System.Collections;

namespace CiftlikTakip.Business.Implementations
{
    public class CompanyBs : ICompanyBs
    {
        private readonly ICompanyRepository _repo;
        private readonly IMapper _mapper;
        public CompanyBs(ICompanyRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<ApiResponse<Company>> InsertAsync(CompanyPostDto dto)
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
                    var company = _mapper.Map<Company>(dto);
                    var insertedCompany = await _repo.InsertAsync(company);
                    return ApiResponse<Company>.Success(StatusCodes.Status201Created, insertedCompany);
                }
                throw new BadRequestException("Kaydedilecek adres bilgisi yollamalısınız");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> RDeleteAsync(Guid id)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var companyId = await _repo.GetByIdAsync(id);
                if (companyId != null)
                {
                    companyId.IsActive = true;
                    companyId.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    companyId.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    companyId.Version = BaseBs.GenerateVersionNumber();
                    await _repo.UpdateAsync(companyId);
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
                var companyId = await _repo.GetByIdIsActiveAsync(id);
                if (companyId != null)
                {
                    companyId.IsActive = false;
                    companyId.DeleteDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    companyId.DeleteBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    companyId.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    companyId.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    companyId.Version = BaseBs.GenerateVersionNumber();
                    await _repo.UpdateAsync(companyId);
                    return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                }
                throw new NotFoundException("Soft => Silinecek veri bulanamadı, silmek istediğiniz veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> HDeleteAsync(Guid id)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var result = await _repo.GetByIdIsActiveAsync(id);
                if (result != null)
                {
                    await _repo.DeleteAsync(result);
                    return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                }
                throw new BadRequestException("Girilen id'ye göre uygun bir içerik bulunamadı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> UpdateAsync(CompanyPutDto dto)
        {
            if (ValidationHelper<Guid>.IsGuid(dto.Id))
            {
                var companyId = await _repo.GetByIdAsync(dto.Id);
                if (StructuralComparisons.StructuralEqualityComparer.Equals(dto.Version, ConvertorHelper.ByteArrayToString(companyId.Version)))
                {
                    throw new BadRequestException("Veri başka bir kullanıcı tarafından güncellenmiş. Lütfen sayfayı yenileyerek tekrar deneyin.");
                }
                dto.CreatedBy = companyId.CreatedBy;
                dto.CreationDate = companyId.CreationDate;
                dto.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                dto.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                dto.Version = BaseBs.GenerateVersionNumber();
                dto.IsActive = true;
                var updateAddress = _mapper.Map<Company>(dto);
                await _repo.UpdateAsync(updateAddress);
                return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<CompanyGetDto>> GetByIdAsync(Guid id, params string[] includeList)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var result = await _repo.GetByIdIsActiveAsync(id, includeList);
                if (result != null)
                {
                    var dto = _mapper.Map<CompanyGetDto>(result);
                    return ApiResponse<CompanyGetDto>.Success(StatusCodes.Status200OK, dto);
                }
                throw new NotFoundException("Aradığınız Id'ye uygun veri bulunamadı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<List<CompanyGetDto>>> GetCompaniesAsync(params string[] includeList)
        {
            var result = await _repo.GetAllAsync(x => x.IsActive == true, includeList: includeList);
            if (result.Count > 0)
            {
                var returnList = _mapper.Map<List<CompanyGetDto>>(result);
                return ApiResponse<List<CompanyGetDto>>.Success(200, returnList);
            }
            throw new NotFoundException("İçerik bulanamadı...");
        }
        public async Task<ApiResponse<List<CompanyGetDto>>> GetByCompanyNameAsync(string companyName)
        {
            var result = await _repo.GetAllAsync(x => x.IsActive == true && x.CompanyName == companyName);
            if (result.Count > 0)
            {
                var returnList = _mapper.Map<List<CompanyGetDto>>(result);
                return ApiResponse<List<CompanyGetDto>>.Success(200, returnList);
            }
            throw new NotFoundException("İçerik bulanamadı...");
        }
    }
}
