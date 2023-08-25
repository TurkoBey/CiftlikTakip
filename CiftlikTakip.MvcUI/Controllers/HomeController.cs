using CiftlikTakip.Model.Dtos.FContact;
using CiftlikTakip.MvcUI.Areas.admin.HttpApiServices;
using CiftlikTakip.MvcUI.Areas.admin.Models;
using CiftlikTakip.MvcUI.Models.Items;
using CiftlikTakip.MvcUI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CiftlikTakip.MvcUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpApiService _httpApiService;
        public HomeController(IHttpApiService httpApiService)
        {
            _httpApiService = httpApiService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var responseB = await _httpApiService.GetData<ResponseBody<List<BreedingRecordItem>>>("/BreedingRecords");
            var responseF = await _httpApiService.GetData<ResponseBody<List<FFaqItem>>>("/FFaqs");
            var responseT = await _httpApiService.GetData<ResponseBody<List<FTeamItem>>>("/FTeams");
            var responseS = await _httpApiService.GetData<ResponseBody<List<FServiceItem>>>("/FServices");
            var responseW = await _httpApiService.GetData<ResponseBody<WebsiteInfoItem>>("/WebsiteInfos/A89B92F0-C38D-4B6A-8CC2-2D8753495080");
            var response = new FHomeViewModel()
            {
                BreedingRecordCount = responseB.Data.Count,
                FFaqItems = responseF.Data,
                FTeamItems = responseT.Data,
                FServiceItems = responseS.Data,
                WebSiteInfoItems = responseW.Data
            };
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Save(FContactDto dto)
        {
            Guid guid = Guid.NewGuid();
            var postObj = new
            {
                Id = guid,
                FullName = dto.FullName,
                Email = dto.Email,
                Subject = dto.Subject,
                Message = dto.Messages
            };
            var response = await _httpApiService.PostData<ResponseBody<FContactItem>>("/FContacts", JsonSerializer.Serialize(postObj));
            if (response.StatusCode == 201)
            {
                return Json(
                  new
                  {
                      IsSuccess = true,
                      Message = "Mesajınız başarıyla gönderildi",
                      Id = guid,
                      FullName = dto.FullName,
                      Email = dto.Email,
                      Subject = dto.Subject,
                      Messages = dto.Messages
                  });
            }
            else
            {
                return Json(new { IsSuccess = false, Messages = response.ErrorMessages });
            }
        }
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                ViewBag.ErrorMessage = "404";
            }
            return View("Error");
        }
    }
}
