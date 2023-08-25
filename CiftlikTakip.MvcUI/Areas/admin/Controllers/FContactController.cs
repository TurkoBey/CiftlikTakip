using CiftlikTakip.MvcUI.Areas.admin.Filters;
using CiftlikTakip.MvcUI.Areas.admin.HttpApiServices;
using CiftlikTakip.MvcUI.Areas.admin.Models;
using CiftlikTakip.MvcUI.Areas.admin.Models.Items;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.MvcUI.Areas.admin.Controllers
{
    [Area("Admin")]
    [SessionAspect]
    public class FContactController : Controller
    {
        private readonly IHttpApiService _httpApiService;
        public FContactController(IHttpApiService httpApiService)
        {
            _httpApiService = httpApiService;
        }
        public async Task<IActionResult> Index()
        {
            var responseW = await _httpApiService.GetData<ResponseBody<WebsiteInfoItem>>($"/WebsiteInfos/A89B92F0-C38D-4B6A-8CC2-2D8753495080");
            ViewBag.SiteName = responseW.Data.SiteName;
            ViewBag.Copyright = responseW.Data.Copyright;
            var responseF = await _httpApiService.GetData<ResponseBody<List<FContactItem>>>("/FContacts");
            return View(responseF.Data);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/FContacts/deleteS/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }

        [HttpPost]
        public async Task<IActionResult> View(Guid id)
        {
            var response = await _httpApiService.GetData<ResponseBody<Models.Items.FContactItem>>($"/FContacts/{id}");

            return Json(
                new
                {
                    FullName = response.Data.FullName,
                    Email = response.Data.Email,
                    Subject = response.Data.Subject,
                    Message = response.Data.Message
                });
        }
    }
}
