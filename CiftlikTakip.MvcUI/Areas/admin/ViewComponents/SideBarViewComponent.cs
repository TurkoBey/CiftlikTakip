using CiftlikTakip.MvcUI.Areas.admin.Extensions;
using CiftlikTakip.MvcUI.Areas.admin.Models.Items;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace CiftlikTakip.MvcUI.Areas.admin.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            var adminUser = HttpContext.Session.GetObject<UserAccessPermissionItem>("ActiveAdminUser");
            //var adminUser = HttpContext.Session.GetObject<WebsiteInfoItem>("webInfo");

            return View(adminUser);
        }
    }
}
