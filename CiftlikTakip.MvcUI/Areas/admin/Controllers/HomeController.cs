using CiftlikTakip.MvcUI.Areas.admin.Filters;
using CiftlikTakip.MvcUI.Areas.admin.HttpApiServices;
using CiftlikTakip.MvcUI.Areas.admin.Models;
using CiftlikTakip.MvcUI.Areas.admin.Models.Enum;
using CiftlikTakip.MvcUI.Areas.admin.Models.Items;
using CiftlikTakip.MvcUI.Areas.admin.Models.ViewModels;
using CiftlikTakip.MvcUI.Utilities.EnumExtensions.Enums;
using Microsoft.AspNetCore.Mvc;

namespace CiftlikTakip.MvcUI.Areas.admin.Controllers
{
    [Area("Admin")]
    [SessionAspect]
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
            var responseW = await _httpApiService.GetData<ResponseBody<WebsiteInfoItem>>($"/WebsiteInfos/A89B92F0-C38D-4B6A-8CC2-2D8753495080");
            ViewBag.SiteName = responseW.Data.SiteName;
            ViewBag.Copyright = responseW.Data.Copyright;
            var responseB = await _httpApiService.GetData<ResponseBody<List<BreedingRecordItem>>>("/BreedingRecords");
            var responseE = await _httpApiService.GetData<ResponseBody<List<EmployeeItem>>>("/Employees");
            var responseC = await _httpApiService.GetData<ResponseBody<List<EmployeeItem>>>("/FContacts");

            var enumValues = Enum.GetValues(typeof(EnumPriorityType));
            var enumList = new List<EnumItem>();

            foreach (var value in enumValues)
            {
                if ((EnumPriorityType)value == EnumPriorityType.Null)
                {
                    continue; // Null değeri geldiyse döngüyü atla
                }
                enumList.Add(new EnumItem
                {
                    ID = (int)value,
                    Name = value.ToString()
                });
            }

            var response = new HomeView
            {
                enumPriorityLists = enumList,
                BreedingRecordItemCount = responseB.Data == null ? 0 : responseB.Data.Count,
                EmployeeItemCount = responseE.Data == null ? 0 : responseE.Data.Count,
                FContactsCount = responseC.Data == null ? 0 : responseC.Data.Count

            };
            return View(response);
        }
    }
}
