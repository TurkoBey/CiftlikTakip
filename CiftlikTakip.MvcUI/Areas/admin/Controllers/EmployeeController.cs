using CiftlikTakip.MvcUI.Areas.admin.Filters;
using CiftlikTakip.MvcUI.Areas.admin.HttpApiServices;
using CiftlikTakip.MvcUI.Areas.admin.Models;
using CiftlikTakip.MvcUI.Areas.admin.Models.Dtos;
using CiftlikTakip.MvcUI.Areas.admin.Models.Items;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace CiftlikTakip.MvcUI.Areas.admin.Controllers
{
    [Area("Admin")]
    [SessionAspect]
    public class EmployeeController : Controller
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpApiService _httpApiService;
        public EmployeeController(IHttpApiService httpApiService, IWebHostEnvironment webHostEnvironment)
        {
            _httpApiService = httpApiService;
            _webHostEnvironment = webHostEnvironment;
        }
        public static string FormatPhoneNumber(string phoneNumber)
        {
            string pattern = @"(\d{2})(\d{3})(\d{3})";
            string formattedPhoneNumber = Regex.Replace(phoneNumber, pattern, "+$1 ($2) $3-");

            return formattedPhoneNumber;
        }
        public async Task<IActionResult> Index()
        {
            var responseW = await _httpApiService.GetData<ResponseBody<WebsiteInfoItem>>($"/WebsiteInfos/A89B92F0-C38D-4B6A-8CC2-2D8753495080");
            ViewBag.SiteName = responseW.Data.SiteName;
            ViewBag.Copyright = responseW.Data.Copyright;
            var response = await _httpApiService.GetData<ResponseBody<List<EmployeeItem>>>("/Employees");

            List<EmployeeItem> formattedEmployees = new List<EmployeeItem>();
            foreach (var employee in response.Data)
            {
                employee.MobilePhone = FormatPhoneNumber(employee.MobilePhone); // Önceki örnekteki FormatPhoneNumber fonksiyonunu kullanabilirsiniz
                formattedEmployees.Add(employee);
            }

            return View(formattedEmployees);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var photoPath = await _httpApiService.GetData<ResponseBody<EmployeeItem>>($"/Employees/{id}");
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/Employees/deleteS/{id}");

            if (response.StatusCode == 200)
            {
                #region EskiGörselSil

                // Eski fotoğrafı sil
                var photoPathDel = $@"{_webHostEnvironment.ContentRootPath}/wwwroot{photoPath.Data.Image}";
                if (photoPath.Data.Image != null)
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
            var response = await _httpApiService.GetData<ResponseBody<EmployeeItem>>($"/Employees/{id}");

            return Json(
                new
                {
                    TCKN = response.Data.TCKN,
                    FirstName = response.Data.FirstName,
                    LastName = response.Data.LastName,
                    MobilePhone = response.Data.MobilePhone,
                    StartDate = response.Data.StartDate,
                    Image = response.Data.Image,
                    Description = response.Data.Description
                });
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(NewEmployeeDto dto, IFormFile image)
        {
            var photoPathDel = await _httpApiService.GetData<ResponseBody<EmployeeItem>>($"/Employees/{dto.Id}");
            var TcCheck = await _httpApiService.GetData<ResponseBody<EmployeeItem>>($"/Employees/getbytckn/{dto.TCKN}");
            Guid guid = dto.Id == Guid.Empty ? Guid.NewGuid() : dto.Id;
            if (TcCheck.Data == null || dto.Id != Guid.Empty)
            {
                if (image != null)
                {
                    if (!image.ContentType.StartsWith("image/"))
                    {
                        return Json(
                            new
                            {
                                IsSuccess = false,
                                Message = "Sadece görsel dosyası seçiniz.."
                            });
                    }
                    if (image.Length > 600 * 1024)
                    {
                        return Json(
                            new
                            {
                                IsSuccess = false,
                                Message = "Görsel dosyasının maksimum boyutu 600 KB olabilir."
                            });
                    }
                    var randomFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(image.FileName)}";
                    var picturePath = $@"/assets/img/employee/{randomFileName}";
                    var uploadPath = $@"{_webHostEnvironment.ContentRootPath}/wwwroot{picturePath}";
                    using (var fs = new FileStream(uploadPath, FileMode.Create))
                    {
                        image.CopyTo(fs);
                    }
                    var postObj = new
                    {
                        Id = guid,
                        FullName = dto.FullName,
                        TCKN = dto.TCKN,
                        FirstName = dto.FirstName,
                        LastName = dto.LastName,
                        MobilePhone = dto.MobilePhone,
                        StartDate = dto.StartDate,
                        Image = picturePath,
                        Description = dto.Description
                    };

                    var response = await _httpApiService.PostOrPutData<ResponseBody<EmployeeItem>>("/Employees", JsonSerializer.Serialize(postObj), (dto.Id == Guid.Empty ? HttpMethod.Post : HttpMethod.Put));

                    if (response.StatusCode == 201 || response.StatusCode == 200)
                    {
                        var isSuccess = response.StatusCode == 201 ? true : response.StatusCode == 200 ? true : false;
                        var message = response.StatusCode == 201 ? "Personel başarılı bir şekilde eklendi." : "Personel başarılı bir şekilde güncellendi.";

                        if (response.StatusCode == 201)
                        {
                            return Json(new
                            {
                                IsSuccess = isSuccess,
                                Message = message,
                                Id = guid,
                                TCKN = response.Data.TCKN,
                                FirstName = response.Data.FirstName,
                                LastName = response.Data.LastName,
                                MobilePhone = response.Data.MobilePhone,
                                StartDate = response.Data.StartDate,
                                Image = response.Data.Image,
                                Description = response.Data.Description
                            });
                        }

                        #region EskiGörselSil

                        // Eski fotoğrafı sil
                        var pohtoPathDel = $@"{_webHostEnvironment.ContentRootPath}/wwwroot{photoPathDel.Data.Image}";
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
            else
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = "Bu Tc'ye ait personel var."
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id)
        {
            var response = await _httpApiService.GetData<ResponseBody<EmployeeItem>>($"/Employees/{id}");

            return Json(
                new
                {
                    Id = response.Data.Id,
                    TCKN = response.Data.TCKN,
                    FirstName = response.Data.FirstName,
                    LastName = response.Data.LastName,
                    MobilePhone = response.Data.MobilePhone,
                    StartDate = response.Data.StartDate,
                    Image = response.Data.Image,
                    Description = response.Data.Description
                });
        }
    }
}
