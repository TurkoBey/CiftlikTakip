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
    public class FFaqController : Controller
    {
        private readonly IHttpApiService _httpApiService;
        public FFaqController(IHttpApiService httpApiService)
        {
            _httpApiService = httpApiService;
        }
        public async Task<IActionResult> Index()
        {
            var responseW = await _httpApiService.GetData<ResponseBody<WebsiteInfoItem>>($"/WebsiteInfos/A89B92F0-C38D-4B6A-8CC2-2D8753495080");
            ViewBag.SiteName = responseW.Data.SiteName;
            ViewBag.Copyright = responseW.Data.Copyright;
            var response = await _httpApiService.GetData<ResponseBody<List<Models.Items.FFaqItem>>>("/FFaqs");

            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/FFaqs/deleteH/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayıt Başarıyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayıt Silinemedi", ErrorMessages = response.ErrorMessages });
        }

        [HttpPost]
        public async Task<IActionResult> View(Guid id)
        {
            var response = await _httpApiService.GetData<ResponseBody<Models.Items.FFaqItem>>($"/FFaqs/{id}");

            return Json(
                new
                {
                    Question = response.Data.Question,
                    Answer = response.Data.Answer
                });
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(NewFaqDto dto)
        {
            Guid guid = dto.Id == Guid.Empty ? Guid.NewGuid() : dto.Id;
            var postObj = new
            {
                Id = guid,
                Question = dto.Question,
                Answer = dto.Answer
            };

            var response = await _httpApiService.PostOrPutData<ResponseBody<Models.Items.FFaqItem>>("/FFaqs", JsonSerializer.Serialize(postObj), (dto.Id == Guid.Empty ? HttpMethod.Post : HttpMethod.Put));

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
                        Question = response.Data.Question,
                        Answer = response.Data.Answer
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
            var response = await _httpApiService.GetData<ResponseBody<Models.Items.FFaqItem>>($"/FFaqs/{id}");

            return Json(
                new
                {
                    Id = response.Data.Id,
                    Question = response.Data.Question,
                    Answer = response.Data.Answer
                });
        }
    }
}
