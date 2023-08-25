using CiftlikTakip.Model.Entities.Base;

namespace CiftlikTakip.Model.Entities
{
    public class Company : BaseEntity
    {
        public string? CompanyName { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? MobileNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}
