namespace CiftlikTakip.MvcUI.Areas.admin.Models.Dtos
{
    public class NewWebsiteInfoDto
    {
        public Guid Id { get; set; }
        public string? SiteName { get; set; }
        public string? Copyright { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? GoogleMapsLink { get; set; }
    }
}
