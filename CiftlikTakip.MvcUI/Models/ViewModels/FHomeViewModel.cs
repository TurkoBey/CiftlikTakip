using CiftlikTakip.MvcUI.Models.Items;

namespace CiftlikTakip.MvcUI.Models.ViewModels
{
    public class FHomeViewModel
    {
        public int BreedingRecordCount { get; set; }
        public List<FFaqItem>? FFaqItems { get; set; }
        public List<FServiceItem>? FServiceItems { get; set; }
        public List<FTeamItem>? FTeamItems { get; set; }
        public WebsiteInfoItem? WebSiteInfoItems { get; set; }
    }
}
