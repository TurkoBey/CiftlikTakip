using AutoMapper;
using CiftlikTakip.Business.CustomExceptions;
using CiftlikTakip.Business.Implementations.Base;
using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Business.Utilities;
using CiftlikTakip.DataAccess.Interfaces;
using CiftlikTakip.Model.Dtos.UserAccessPermission;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.ApiResponses;
using Microsoft.AspNetCore.Http;
using System.Collections;

namespace CiftlikTakip.Business.Implementations
{
    public class UserAccessPermissionBs : IUserAccessPermissionBs
    {
        private readonly IUserAccessPermissionRepository _repo;
        private readonly IEmployeeRepository _employeedrepo;
        private readonly IMapper _mapper;

        public UserAccessPermissionBs(IUserAccessPermissionRepository repo, IMapper mapper, IEmployeeRepository employeedrepo)
        {
            _repo = repo;
            _mapper = mapper;
            _employeedrepo = employeedrepo;
        }
        public async Task<ApiResponse<UserAccessPermission>> InsertAsync(UserAccessPermissionPostDto dto)
        {
            TimeSpan timeout = TimeSpan.FromSeconds(10);
            var employeeId = await _employeedrepo.GetByEmployeesAsync(dto.EmployeeId);
            if (ValidationHelper<Guid>.IsGuid(dto.Id))
            {
                if (dto != null)
                {
                    if (employeeId.Count > 0)
                    {
                        dto.Password = MD5HashHelper.CalculateMD5Hash(dto.Password);
                        dto.CreationDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                        dto.CreatedBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                        dto.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                        dto.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                        dto.Version = BaseBs.GenerateVersionNumber();
                        dto.IsActive = true;
                        dto.IPAddress = await IPHelper.GetPublicIPAddressAsync(timeout);
                        dto.LastIPAddress = await IPHelper.GetPublicIPAddressAsync(timeout);
                        dto.PermissionStartDate = DateTime.Now;
                        dto.PermissionEndDate = dto.PermissionEndDate;
                        var address = _mapper.Map<UserAccessPermission>(dto);
                        var insertedProduct = await _repo.InsertAsync(address);
                        return ApiResponse<UserAccessPermission>.Success(StatusCodes.Status201Created, insertedProduct);
                    }
                    throw new NotFoundException("Eklenecek veride iletişim bilgisine ait veri bulunamadı, eklemek istediğiniz id'yi kontrol ediniz.");
                }
                throw new NotFoundException("Güncellenecek personel verisi bulanamadı, güncellemek istediğiniz veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> UpdateAsync(UserAccessPermissionPutDto dto)
        {
            TimeSpan timeout = TimeSpan.FromSeconds(10);
            if (ValidationHelper<Guid>.IsGuid(dto.Id))
            {
                var repoId = await _repo.GetByIdAsync(dto.Id);
                var employeeId = await _employeedrepo.GetByEmployeesAsync(dto.EmployeeId);

                if (dto != null)
                {
                    if (employeeId.Count > 0)
                    {
                        if (StructuralComparisons.StructuralEqualityComparer.Equals(dto.Version, ConvertorHelper.ByteArrayToString(repoId.Version)))
                        {
                            throw new BadRequestException("Veri başka bir kullanıcı tarafından güncellenmiş. Lütfen sayfayı yenileyerek tekrar deneyin.");
                        }
                        dto.Password = MD5HashHelper.CalculateMD5Hash(dto.Password);
                        dto.CreatedBy = repoId.CreatedBy;
                        dto.CreationDate = repoId.CreationDate;
                        dto.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                        dto.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                        dto.Version = BaseBs.GenerateVersionNumber();
                        dto.IsActive = true;
                        dto.IPAddress = await IPHelper.GetPublicIPAddressAsync(timeout);
                        dto.LastIPAddress = dto.LastIPAddress;
                        dto.PermissionStartDate = dto.PermissionStartDate;
                        dto.PermissionEndDate = dto.PermissionEndDate;
                        var updateAddress = _mapper.Map<UserAccessPermission>(dto);
                        await _repo.UpdateAsync(updateAddress);
                        return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                    }
                    throw new NotFoundException("Güncellenecek personel verisi bulanamadı, güncellemek istediğiniz veriyi kontrol ediniz.");
                }
                throw new NotFoundException("Güncellenecek veri bulanamadı, güncellemek istediğiniz veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<NoData>> SDeleteAsync(Guid id)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var repoId = await _repo.GetByIdAsync(id);
                if (repoId != null)
                {
                    repoId.CreatedBy = repoId.CreatedBy;
                    repoId.CreationDate = repoId.CreationDate;
                    repoId.IsActive = false;
                    repoId.DeleteDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    repoId.DeleteBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    repoId.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    repoId.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    repoId.Version = BaseBs.GenerateVersionNumber();
                    await _repo.UpdateAsync(repoId);
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
                var repoId = await _repo.GetByIdPassiveAsync(id);
                if (repoId != null)
                {
                    repoId.IsActive = true;
                    repoId.UpdateBy = new Guid("17f0db84-da65-4ee1-b23c-a590dde9903c");
                    repoId.UpdateDate = BaseBs.ConvertToTurkeyTimeZone(DateTime.UtcNow);
                    repoId.Version = BaseBs.GenerateVersionNumber();
                    await _repo.UpdateAsync(repoId);
                    return ApiResponse<NoData>.Success(StatusCodes.Status200OK);
                }
                throw new NotFoundException("Soft => Aktif edilecek veri bulanamadı, silinmiş veriyi kontrol ediniz.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<UserAccessPermissionGetDto>> GetByIdAsync(Guid id, params string[] includeList)
        {
            if (ValidationHelper<Guid>.IsGuid(id))
            {
                var result = await _repo.GetByIdAsync(id, includeList: includeList);
                if (result != null)
                {
                    var dto = _mapper.Map<UserAccessPermissionGetDto>(result);
                    return ApiResponse<UserAccessPermissionGetDto>.Success(StatusCodes.Status200OK, dto);
                }
                throw new NotFoundException("Aradığınız Id'ye uygun veri bulunamadı.");
            }
            throw new BadRequestException("Id değeri hatalı,");
        }
        public async Task<ApiResponse<List<UserAccessPermissionGetDto>>> GetUsersAsync(params string[] includeList)
        {
            var result = await _repo.GetAllAsync(includeList: includeList);
            if (result.Count > 0)
            {
                var returnList = _mapper.Map<List<UserAccessPermissionGetDto>>(result);
                return ApiResponse<List<UserAccessPermissionGetDto>>.Success(200, returnList);
            }
            throw new NotFoundException("İçerik bulanamadı...");
        }
        public async Task<ApiResponse<UserAccessPermissionGetDto>> LogIn(string email, string password, params string[] includeList)
        {
            TimeSpan timeout = TimeSpan.FromSeconds(10);
            if (string.IsNullOrEmpty(email))
            {
                throw new BadRequestException("Kullanıcı Adı Boş Bırakılamaz.");
            }

            if (email.Length <= 2)
            {
                throw new BadRequestException("Kullanıcı Adı en az 3 karakter olmalıdır.");
            }

            password = password.Trim();
            if (string.IsNullOrEmpty(password))
            {
                throw new BadRequestException("Şifre Boş Bırakılamaz.");
            }
            var adminUser = await _repo.GetByMailPassAsync(email, MD5HashHelper.CalculateMD5Hash(password), includeList);

            if (adminUser != null)
            {
                adminUser.IPAddress = await IPHelper.GetPublicIPAddressAsync(timeout);
                adminUser.LastIPAddress = await IPHelper.GetPublicIPAddressAsync(timeout);
                var dto = _mapper.Map<UserAccessPermissionGetDto>(adminUser);
                return ApiResponse<UserAccessPermissionGetDto>.Success(StatusCodes.Status200OK, dto);
            }
            throw new NotFoundException("İçerik Bulunamadı.");

        }
    }
}
