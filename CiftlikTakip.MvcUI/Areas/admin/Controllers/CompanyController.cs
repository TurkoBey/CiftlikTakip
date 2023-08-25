using CiftlikTakip.MvcUI.Areas.admin.Filters;
using CiftlikTakip.MvcUI.Areas.admin.HttpApiServices;
using CiftlikTakip.MvcUI.Areas.admin.Models;
using CiftlikTakip.MvcUI.Areas.admin.Models.Items;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CiftlikTakip.MvcUI.Areas.admin.Controllers
{
    [Area("Admin")]
    [SessionAspect]
    public class CompanyController : Controller
    {
        private readonly IHttpApiService _httpApiService;
        public CompanyController(IHttpApiService httpApiService)
        {
            _httpApiService = httpApiService;
        }
        public async Task<IActionResult> Index()
        {
            var responseW = await _httpApiService.GetData<ResponseBody<WebsiteInfoItem>>($"/WebsiteInfos/A89B92F0-C38D-4B6A-8CC2-2D8753495080");
            ViewBag.SiteName = responseW.Data.SiteName;
            ViewBag.Copyright = responseW.Data.Copyright;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5162/api");

                var httpResponseMessage = await client.GetAsync($"{client.BaseAddress}/Companies");

                var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

                var response = JsonSerializer.Deserialize<ResponseBody<List<CompanyItem>>>(jsonResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                return View(response.Data);
            }
        }
    }
}
