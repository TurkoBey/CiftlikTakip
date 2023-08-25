using CiftlikTakip.Model.Entities.Base;

namespace CiftlikTakip.Model.Entities
{
    public class FTeam : BaseEntity
    {
        public string? FullName { get; set; }
        public string? PhotoPath { get; set; }
        public string? Role { get; set; }
        public string? Twitter { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? LinkedIn { get; set; }
    }
}
