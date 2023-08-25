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
    public class WebsiteInfoController : Controller
    {
        private readonly IHttpApiService _httpApiService;
        public WebsiteInfoController(IHttpApiService httpApiService)
        {
            _httpApiService = httpApiService;
        }
        public async Task<IActionResult> Index()
        {
            var response = await _httpApiService.GetData<ResponseBody<WebsiteInfoItem>>($"/WebsiteInfos/A89B92F0-C38D-4B6A-8CC2-2D8753495080");
            ViewBag.SiteName = response.Data.SiteName;
            ViewBag.Copyright = response.Data.Copyright;
            ViewBag.MobileNumber = response.Data.MobileNumber;
            ViewBag.PhoneNumber = response.Data.PhoneNumber;
            ViewBag.Email = response.Data.Email;
            ViewBag.Address = response.Data.Address;
            ViewBag.GoogleMapsLink = response.Data.GoogleMapsLink;
            ViewBag.Id = response.Data.Id;
            return View(response.Data);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(NewWebsiteInfoDto dto)
        {
            Guid guid = dto.Id == Guid.Empty ? Guid.NewGuid() : dto.Id;
            var postObj = new
            {
                Id = guid,
                SiteName = dto.SiteName,
                Copyright = dto.Copyright,
                PhoneNumber = dto.PhoneNumber,
                MobileNumber = dto.MobileNumber,
                Email = dto.Email,
                Address = dto.Address,
                GoogleMapsLink = dto.GoogleMapsLink
            };

            var response = await _httpApiService.PostOrPutData<ResponseBody<WebsiteInfoItem>>("/WebsiteInfos", JsonSerializer.Serialize(postObj), (dto.Id == Guid.Empty ? HttpMethod.Post : HttpMethod.Put));

            if (response.StatusCode == 200)
            {
                  // Güncelleme için Json
                return Json(new
                {
                    IsSuccess = true,
                    Message = "Site ayarlarý baþarýlý bir þekilde güncellendi."
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
    }
}
