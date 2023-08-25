using AutoMapper;
using CiftlikTakip.Business.CustomExceptions;
using CiftlikTakip.Business.Implementations.Base;
using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Business.Utilities;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Dtos.Employee;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Infrastructure.Utilities.CustomExtensions;
using Microsoft.AspNetCore.Http;
using System.Collections;

namespace CiftlikTakip.Business.Implementations
{
    public class EmployeeBs : IEmployeeBs
    {
        private readonly IEmployeeRepository _repo;
        private readonly IMapper _mapper;

        public EmployeeBs(IEmployeeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<ApiResponse<Employee>> InsertAsync(EmployeePostDto dto)
        {
            if (ValidationHelper<Guid>.IsGuid(dto.Id))
            {
                if (dto != null)
                {
                    if (dto.TCKN.TCKNKontrolEt())
                    {
                        dto.CreationDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                        dto.CreatedBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                        dto.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                        dto.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                        dto.Version = BaseBs.GenerateVersionNumber();
                        dto.IsActive = true;
                        var taskProductStock = _mapper.Map<Employee>(dto);
                        var insertedProductStock = await _repo.InsertAsync(taskProductStock);
                        return ApiResponse<Employee>.Success(StatusCodes.Status201Created, insertedProductStock);
                    }
                    throw new BadRequestException("TCKN kontrol ediniz. Kimlik numarası hatalı.");
                }
                throw new BadRequestException("Kaydedilecek adres bilgisi yollamalısınız");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> UpdateAsync(EmployeePutDto dto)
        {
            if (ValidationHelper<Guid>.IsGuid(dto.Id))
            {
                if (dto.TCKN.TCKNKontrolEt())
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
                            var updateEmployee = _mapper.Map<Employee>(dto);
                            await _repo.UpdateAsync(updateEmployee);
                            return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                        }
                        throw new BadRequestException("Veri başka bir kullanıcı tarafından güncellenmiş. Lütfen sayfayı yenileyerek tekrar deneyin.");
                    }
                    throw new NotFoundException("Güncellenecek veri bulanamadı, güncellemek istediğiniz veriyi kontrol ediniz.");
                }
                throw new BadRequestException("TCKN kontrol ediniz. Kimlik numarası hatalı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> RDeleteAsync(Guid id)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var taskEmployeeId = await _repo.GetByIdPassiveAsync(id);
                if (taskEmployeeId != null)
                {
                    taskEmployeeId.IsActive = true;
                    taskEmployeeId.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    taskEmployeeId.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    taskEmployeeId.Version = BaseBs.GenerateVersionNumber();
                    await _repo.UpdateAsync(taskEmployeeId);
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
                var taskEmployeeId = await _repo.GetByIdAsync(id);
                if (taskEmployeeId != null)
                {
                    taskEmployeeId.IsActive = false;
                    taskEmployeeId.DeleteDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    taskEmployeeId.DeleteBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    taskEmployeeId.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    taskEmployeeId.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    taskEmployeeId.Version = BaseBs.GenerateVersionNumber();
                    await _repo.UpdateAsync(taskEmployeeId);
                    return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                }
                throw new NotFoundException("Soft => Silinecek veri bulanamadı, silmek istediğiniz veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<EmployeeGetDto>> GetByIdAsync(Guid id, params string[] includeList)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var result = await _repo.GetByIdAsync(id, includeList);
                if (result != null)
                {
                    var dto = _mapper.Map<EmployeeGetDto>(result);
                    return ApiResponse<EmployeeGetDto>.Success(StatusCodes.Status200OK, dto);
                }
                throw new NotFoundException("Aradığınız Id'ye uygun veri bulunamadı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<List<EmployeeGetDto>>> GetEmployeesAsync(params string[] includeList)
        {
            var result = await _repo.GetAllAsync(x => x.IsActive == true, includeList: includeList);
            if (result.Count > 0)
            {
                var returnList = _mapper.Map<List<EmployeeGetDto>>(result);
                return ApiResponse<List<EmployeeGetDto>>.Success(200, returnList);
            }
            throw new NotFoundException("İçerik bulanamadı...");
        }
        public async Task<ApiResponse<EmployeeGetDto>> GetByTcknAsync(string tckn, params string[] includeList)
        {
            var result = await _repo.GetByTcknAsync(tckn, includeList);
            if (result != null)
            {
                var dto = _mapper.Map<EmployeeGetDto>(result);
                return ApiResponse<EmployeeGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("Aradığınız TC'ye ait veri bulunamadı.");
        }
    }
}
