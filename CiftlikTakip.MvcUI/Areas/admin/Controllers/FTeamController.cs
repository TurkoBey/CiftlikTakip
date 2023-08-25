using CiftlikTakip.MvcUI.Areas.admin.Filters;
using CiftlikTakip.MvcUI.Areas.admin.HttpApiServices;
using CiftlikTakip.MvcUI.Areas.admin.Models;
using CiftlikTakip.MvcUI.Areas.admin.Models.Dtos;
using CiftlikTakip.MvcUI.Areas.admin.Models.Items;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CiftlikTakip.MvcUI.Areas.admin.Controllers
{
    [Area("Admin")]
    [SessionAspect]
    public class FTeamController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpApiService _httpApiService;
        public FTeamController(IHttpApiService httpApiService, IWebHostEnvironment webHostEnvironment)
        {
            _httpApiService = httpApiService;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var responseW = await _httpApiService.GetData<ResponseBody<WebsiteInfoItem>>($"/WebsiteInfos/A89B92F0-C38D-4B6A-8CC2-2D8753495080");
            ViewBag.SiteName = responseW.Data.SiteName;
            ViewBag.Copyright = responseW.Data.Copyright;
            var response = await _httpApiService.GetData<ResponseBody<List<FTeamItem>>>("/FTeams");

            return View(response.Data);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var photoPath = await _httpApiService.GetData<ResponseBody<FTeamItem>>($"/FTeams/{id}");
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/FTeams/deleteS/{id}");

            if (response.StatusCode == 200)
            {
                #region EskiGörselSil

                // Eski fotoğrafı sil
                var photoPathDel = $@"{_webHostEnvironment.ContentRootPath}/wwwroot{photoPath.Data.PhotoPath}";
                if (photoPath.Data.PhotoPath != null)
                {
                    System.IO.File.Delete(photoPathDel);
                }

                #endregion
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });
            }
            

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }

        [HttpPost]
        public async Task<IActionResult> View(Guid id)
        {
            var response = await _httpApiService.GetData<ResponseBody<FTeamItem>>($"/FTeams/{id}");

            return Json(
                new
                {
                    FullName = response.Data.FullName,
                    PhotoPath = response.Data.PhotoPath,
                    Role = response.Data.Role,
                    Twitter = response.Data.Twitter,
                    Facebook = response.Data.Facebook,
                    Instagram = response.Data.Instagram,
                    LinkedIn = response.Data.LinkedIn
                });
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(NewFTeamDto dto, IFormFile photoPath)
        {
            var photoPathDel = await _httpApiService.GetData<ResponseBody<FTeamItem>>($"/FTeams/{dto.Id}");
            Guid guid = dto.Id == Guid.Empty ? Guid.NewGuid() : dto.Id;
            if (photoPath != null)
            {
                if (!photoPath.ContentType.StartsWith("image/"))
                {
                    return Json(
                        new
                        {
                            IsSuccess = false,
                            Message = "Sadece görsel  dosyası seçiniz.."
                        });
                }
                if (photoPath.Length > 600 * 1024)
                {
                    return Json(
                        new
                        {
                            IsSuccess = false,
                            Message = "Görsel dosyasının maksimum boyutu 600 KB olabilir."
                        });
                }
                var randomFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(photoPath.FileName)}";
                var picturePath = $@"/assets/img/team/{randomFileName}";
                var uploadPath = $@"{_webHostEnvironment.ContentRootPath}/wwwroot{picturePath}";
                using (var fs = new FileStream(uploadPath, FileMode.Create))
                {
                    photoPath.CopyTo(fs);
                }
                var postObj = new
                {
                    Id = guid,
                    FullName = dto.FullName,
                    PhotoPath = picturePath,
                    Role = dto.Role,
                    Twitter = dto.Twitter,
                    Facebook = dto.Facebook,
                    Instagram = dto.Instagram,
                    LinkedIn = dto.LinkedIn,
                    Description = dto.Description
                };

                var response = await _httpApiService.PostOrPutData<ResponseBody<FTeamItem>>("/FTeams", JsonSerializer.Serialize(postObj), (dto.Id == Guid.Empty ? HttpMethod.Post : HttpMethod.Put));

                if (response.StatusCode == 201 || response.StatusCode == 200)
                {
                    var isSuccess = response.StatusCode == 201 ? true : response.StatusCode == 200 ? true : false;
                    var message = response.StatusCode == 201 ? "Ekip üyesi başarılı bir şekilde eklendi." : "Ekip üyesi başarılı bir şekilde güncellendi.";

                    if (response.StatusCode == 201)
                    {
                        return Json(new
                        {
                            IsSuccess = isSuccess,
                            Message = message,
                            Id = guid,
                            FullName = response.Data.FullName,
                            PhotoPath = response.Data.PhotoPath,
                            Role = response.Data.Role,
                            Twitter = response.Data.Twitter,
                            Facebook = response.Data.Facebook,
                            Instagram = response.Data.Instagram,
                            LinkedIn = response.Data.LinkedIn,
                            Description = response.Data.Description
                        });
                    }

                    #region EskiGörselSil

                    // Eski fotoğrafı sil
                    var pohtoPathDel = $@"{_webHostEnvironment.ContentRootPath}/wwwroot{photoPathDel.Data.PhotoPath}";
                    if (System.IO.File.Exists(pohtoPathDel) != null)
                    {
                        System.IO.File.Delete(pohtoPathDel);
                    }

                    #endregion

                    return Json(new
                    {
                        IsSuccess = isSuccess,
                        Message = message
                    });
                }
                else
                {
                    return Json(
                        new
                        {
                            IsSuccess = false,
                            Messages = response.ErrorMessages
                        });
                }
            }
            else
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = "Görsel için dosya seçilmesi zorunludur.."
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id)
        {
            var response = await _httpApiService.GetData<ResponseBody<FTeamItem>>($"/FTeams/{id}");

            return Json(
                new
                {
                    Id = response.Data.Id,
                    FullName = response.Data.FullName,
                    PhotoPath = response.Data.PhotoPath,
                    Role = response.Data.Role,
                    Twitter = response.Data.Twitter,
                    Facebook = response.Data.Facebook,
                    Instagram = response.Data.Instagram,
                    LinkedIn = response.Data.LinkedIn,
                    Description = response.Data.Description
                });
        }
    }
}
