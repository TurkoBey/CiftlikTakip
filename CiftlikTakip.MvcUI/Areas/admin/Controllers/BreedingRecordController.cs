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
    public class BreedingRecordController : Controller
    {
        private readonly IHttpApiService _httpApiService;
        public BreedingRecordController(IHttpApiService httpApiService)
        {
            _httpApiService = httpApiService;
        }
        public async Task<IActionResult> Index()
        {
            var responseW = await _httpApiService.GetData<ResponseBody<WebsiteInfoItem>>($"/WebsiteInfos/A89B92F0-C38D-4B6A-8CC2-2D8753495080");
            ViewBag.SiteName = responseW.Data.SiteName;
            ViewBag.Copyright = responseW.Data.Copyright;

            var responseB = await _httpApiService.GetData<ResponseBody<List<BreedingRecordItem>>>("/BreedingRecords");

            return View(responseB.Data);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/BreedingRecords/deleteS/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayýt Baþarýyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayýt Silinemedi", ErrorMessages = response.ErrorMessages });
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(NewBreedingRecordlDto dto)
        {
            Guid guid = dto.Id == Guid.Empty ? Guid.NewGuid() : dto.Id;

            var postObj = new
            {
                Id = guid,
                AnimalCode = dto.AnimalCode,
                BreedingName = dto.BreedingName,
                Description = dto.Description
            };

            var response = await _httpApiService.PostOrPutData<ResponseBody<BreedingRecordItem>>("/BreedingRecords", JsonSerializer.Serialize(postObj), (dto.Id == Guid.Empty ? HttpMethod.Post : HttpMethod.Put));

            if (response.StatusCode == 201 || response.StatusCode == 200)
            {
                var isSuccess = response.StatusCode == 201 ? true : response.StatusCode == 200 ? true : false;
                var message = response.StatusCode == 201 ? "Padok Baþarýyla Kaydedildi" : "Padok Baþarýyla Güncellendi.";

                // Ekleme için Json
                if (response.StatusCode == 201)
                {
                    return Json(new
                    {
                        IsSuccess = isSuccess,
                        Message = message,
                        Id = guid,
                        AnimalCode = response.Data.AnimalCode,
                        BreedingName = response.Data.BreedingName,
                        Description = response.Data.Description
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
                return Json(new { IsSuccess = false, Messages = response.ErrorMessages });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id)
        {
            var response = await _httpApiService.GetData<ResponseBody<BreedingRecordItem>>($"/BreedingRecords/{id}");

            return Json(
                new
                {
                    AnimalCode = response.Data.AnimalCode,
                    BreedingName = response.Data.BreedingName,
                    Description = response.Data.Description
                });
        }
        [HttpPost]
        public async Task<IActionResult> View(Guid id)
        {
            var response = await _httpApiService.GetData<ResponseBody<BreedingRecordItem>>($"/BreedingRecords/{id}");

            return Json(
                new
                {
                    AnimalCode = response.Data.AnimalCode,
                    BreedingName = response.Data.BreedingName,
                    Description = response.Data.Description
                });
        }
    }
}
