using CiftlikTakip.MvcUI.Areas.admin.Models.Enum;
using CiftlikTakip.MvcUI.Areas.admin.Models.Items;

namespace CiftlikTakip.MvcUI.Areas.admin.Models.ViewModels
{
    public class AnimalView
    {
        public List<EnumItem>? enumBreedLists { get; set; }
        public List<AnimalBreedItem>? animalBreedItems { get; set; }
    }
}
