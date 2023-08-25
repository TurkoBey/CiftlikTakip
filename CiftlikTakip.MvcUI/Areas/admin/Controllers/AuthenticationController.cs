using CiftlikTakip.MvcUI.Areas.admin.Extensions;
using CiftlikTakip.MvcUI.Areas.admin.HttpApiServices;
using CiftlikTakip.MvcUI.Areas.admin.Models;
using CiftlikTakip.MvcUI.Areas.admin.Models.Dtos;
using CiftlikTakip.MvcUI.Areas.admin.Models.Items;
using CiftlikTakip.MvcUI.Areas.admin.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CiftlikTakip.MvcUI.Areas.admin.Controllers
{
    [Area("Admin")]
    public class AuthenticationController : Controller
    {
        private readonly IHttpApiService _httpApiService;
        public Guid guid { get; set; }
        public AuthenticationController(IHttpApiService httpApiService)
        {
            _httpApiService = httpApiService;
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(LogInDto dto)
        {
            var response = await _httpApiService.GetData<ResponseBody<UserAccessPermissionItem>>($"/Authentication/logIn?email={dto.Email}&password={dto.Password}");

            if (response.ErrorMessages == null || response.ErrorMessages.Count == 0)
            {
                if (string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Password))
                {
                    return Json(new { IsSuccess = false, Messages = response.ErrorMessages });
                }

                HttpContext.Session.SetObject("ActiveAdminUser", response.Data);
                return Json(new { IsSuccess = true, Messages = "Kullanıcı Bulundu" });
            }
            else
            {
                return Json(new { IsSuccess = false, Messages = response.ErrorMessages });
            }
        }
        public IActionResult ForgorPasword()
        {
            return View();
        }
        public IActionResult Logout()
        {
            try
            {
                // Kullanıcı oturum değişkenini kaldır
                HttpContext.Session.Remove("ActiveAdminUser");

                // Çıkış yapıldıktan sonra başarılı JSON yanıtı döndür
                return Json(new { IsSuccess = true, Message = "Çıkış işlemi başarılı." });
            }
            catch (Exception ex)
            {
                // Hata durumunda hata JSON yanıtı döndür
                return Json(new { IsSuccess = false, Message = "Çıkış işlemi sırasında bir hata oluştu: " + ex.Message });
            }
        }
        public async Task<IActionResult> Index()
        {
            //var responseU = await _httpApiService.GetData<ResponseBody<List<UserAccessPermissionItem>>>("/Authentication");
            //return View(responseU.Data);
            var responseU = await _httpApiService.GetData<ResponseBody<List<UserAccessPermissionItem>>>("/Authentication");
            var responseE = await _httpApiService.GetData<ResponseBody<List<EmployeeItem>>>("/Employees");


            var relatedInfoStockName = new Dictionary<Guid, Tuple<string, Guid>>();
            var relatedInfoStockImage = new Dictionary<Guid, Tuple<string, Guid>>();

            var response = new EmployeeView
            {
                userAccessPermissionItems = responseU.Data,
                employeeItems = responseE.Data
            };

            foreach (var item in response.userAccessPermissionItems)
            {
                var relatedImage = response.employeeItems.FirstOrDefault(p => p.Id == item.EmployeeId);

                if (relatedImage != null)
                {
                    relatedInfoStockImage[item.Id] = Tuple.Create(relatedImage.Image, relatedImage.Id);
                }
                else
                {
                    // Eğer relatedImage null ise, bir varsayılan değer atanır.
                    relatedInfoStockImage[item.Id] = Tuple.Create("/admin/dist/img/noimage.jpg", new Guid("00000000-0000-0000-0000-000000000000"));
                }
            }
            ViewBag.RelatedInfo = relatedInfoStockImage;
            return View(response);
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/Authentication/deleteH/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }

        [HttpPost]
        public async Task<IActionResult> View(Guid id)
        {
            var response = await _httpApiService.GetData<ResponseBody<UserAccessPermissionItem>>($"/Authentication/{id}");

            return Json(
                new
                {
                    Username = response.Data.Username,
                    Email = response.Data.Email,
                    Password = response.Data.Password,
                    IPAddress = response.Data.IPAddress,
                    LastIPAddress = response.Data.LastIPAddress
                });
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(NewUserDto dto)
        {
            Guid guid = dto.Id == Guid.Empty ? Guid.NewGuid() : dto.Id;
            var postObj = new
            {
                Id = guid,
                Username = dto.Username,
                Email = dto.Email,
                Password = dto.Password,
                IPAddress = dto.IPAddress,
                LastIPAddress = dto.LastIPAddress
            };

            var response = await _httpApiService.PostOrPutData<ResponseBody<UserAccessPermissionItem>>("/Authentication", JsonSerializer.Serialize(postObj), (dto.Id == Guid.Empty ? HttpMethod.Post : HttpMethod.Put));

            if (response.StatusCode == 201 || response.StatusCode == 200)
            {
                var isSuccess = response.StatusCode == 201 ? true : response.StatusCode == 200 ? true : false;
                var message = response.StatusCode == 201 ? "SSS başarılı bir şekilde eklendi." : "SSS başarılı bir şekilde güncellendi.";

                // Ekleme için Json
                if (response.StatusCode == 201)
                {
                    return Json(new
                    {
                        IsSuccess = isSuccess,
                        Message = message,
                        Id = guid,
                        Username = response.Data.Username,
                        Email = response.Data.Email,
                        Password = response.Data.Password,
                        IPAddress = response.Data.IPAddress,
                        LastIPAddress = response.Data.LastIPAddress
                    });
                }

                // Güncelleme için Json
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

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id)
        {
            var response = await _httpApiService.GetData<ResponseBody<UserAccessPermissionItem>>($"/Authentication/{id}");

            return Json(
                new
                {
                    Id = response.Data.Id,
                    Username = response.Data.Username,
                    Email = response.Data.Email,
                    Password = response.Data.Password,
                    IPAddress = response.Data.IPAddress,
                    LastIPAddress = response.Data.LastIPAddress
                });
        }
    }
}
