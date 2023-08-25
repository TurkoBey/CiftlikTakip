using CiftlikTakip.MvcUI.Areas.admin.Models.Items;

namespace CiftlikTakip.MvcUI.Areas.admin.Models.ViewModels
{
    public class EmployeeView
    {
        public List<EmployeeItem>? employeeItems { get; set; }
        public List<UserAccessPermissionItem>? userAccessPermissionItems { get; set; }
    }
}
