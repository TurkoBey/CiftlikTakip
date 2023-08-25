using CiftlikTakip.MvcUI.Areas.admin.Filters;
using CiftlikTakip.MvcUI.Areas.admin.HttpApiServices;
using CiftlikTakip.MvcUI.Areas.admin.Models;
using CiftlikTakip.MvcUI.Areas.admin.Models.Dtos.NewVaccinationDto;
using CiftlikTakip.MvcUI.Areas.admin.Models.Enum;
using CiftlikTakip.MvcUI.Areas.admin.Models.Items;
using CiftlikTakip.MvcUI.Areas.admin.Models.ViewModels;
using CiftlikTakip.MvcUI.Utilities.EnumExtensions.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CiftlikTakip.MvcUI.Areas.admin.Controllers
{
    [Area("Admin")]
    [SessionAspect]
    public class AnimalBreedController : Controller
    {
        private readonly IHttpApiService _httpApiService;
        public AnimalBreedController(IHttpApiService httpApiService)
        {
            _httpApiService = httpApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var responseW = await _httpApiService.GetData<ResponseBody<WebsiteInfoItem>>($"/WebsiteInfos/A89B92F0-C38D-4B6A-8CC2-2D8753495080");
            ViewBag.SiteName = responseW.Data.SiteName;
            ViewBag.Copyright = responseW.Data.Copyright;
            var responseB = await _httpApiService.GetData<ResponseBody<List<AnimalBreedItem>>>("/AnimalBreeds");
            
            var enumValues = Enum.GetValues(typeof(EnumBreedType));
            var enumList = new List<EnumItem>();

            foreach (var value in enumValues)
            {
                if ((EnumBreedType)value == EnumBreedType.Null)
                {
                    continue; // Null deðeri geldiyse döngüyü atla
                }
                enumList.Add(new EnumItem
                {
                    ID = (int)value,
                    Name = value.ToString()
                });
            }

            var response = new AnimalView
            {
                enumBreedLists = enumList,
                animalBreedItems = responseB.Data
            };
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _httpApiService.DeleteData<ResponseBody<NoData>>($"/AnimalBreeds/deleteH/{id}");

            if (response.StatusCode == 200)
                return Json(new { IsSuccess = true, Message = "Kayýt Baþarýyla Silindi" });

            return Json(new { IsSuccess = false, Message = "Kayýt Silinemedi", ErrorMessages = response.ErrorMessages });
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(NewVaccinationDto dto)
        {
            Guid guid = dto.Id == Guid.Empty ? Guid.NewGuid() : dto.Id;

            var postObj = new
            {
                Id = guid,
                VaccinationName = dto.VaccinationName,
                Dosage = dto.Dosage,
                VaccinationDuration = dto.VaccinationDuration,
                Description = dto.Description
            };

            var response = await _httpApiService.PostOrPutData<ResponseBody<AnimalBreedItem>>("/AnimalBreeds", JsonSerializer.Serialize(postObj), (dto.Id == Guid.Empty ? HttpMethod.Post : HttpMethod.Put));

            if (response.StatusCode == 201 || response.StatusCode == 200)
            {
                var isSuccess = response.StatusCode == 201 ? true : response.StatusCode == 200 ? true : false;
                var message = response.StatusCode == 201 ? "Aþý Baþarýyla Kaydedildi" : "Aþý Baþarýyla Güncellendi.";

                return Json(new
                {
                    IsSuccess = isSuccess,
                    Message = message,
                    Id = guid,
                    VaccinationName = dto.VaccinationName,
                    Dosage = dto.Dosage,
                    VaccinationDuration = dto.VaccinationDuration,
                    Description = dto.Description
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
            var response = await _httpApiService.GetData<ResponseBody<AnimalBreedItem>>($"/AnimalBreeds/{id}");

            return Json(
                new
                {
                    Title = response.Data.Title,
                    GroupName = response.Data.GroupName,
                    Description = response.Data.Description
                });
        }
    }
}
