using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.WebsiteInfo
{
    public class WebsiteInfoPostDto : JsonIgnoreDto, IDto
    {
        public string? SiteName { get; set; }
        public string? Copyright { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? GoogleMapsLink { get; set; }
    }
}
