using CiftlikTakip.MvcUI.Areas.admin.Models.Enum;

namespace CiftlikTakip.MvcUI.Areas.admin.Models.ViewModels
{
    public class HomeView
    {
        public int BreedingRecordItemCount { get; set; }
        public int EmployeeItemCount { get; set; }
        public int ProductStockCount { get; set; }
        public int FContactsCount { get; set; }
        public List<EnumItem>? enumPriorityLists { get; set; }
    }
}
