namespace CiftlikTakip.MvcUI.Areas.admin.Models.Items
{
    public class WebsiteInfoItem
    {
        public Guid Id { get; set; }
        public string? SiteName { get; set; }
        public string? Copyright { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? GoogleMapsLink { get; set; }
        public string? Description { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
