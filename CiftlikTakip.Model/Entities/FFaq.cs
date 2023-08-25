using CiftlikTakip.Model.Entities.Base;

namespace CiftlikTakip.Model.Entities
{
    public class FFaq : BaseEntity
    {
        public string? Question { get; set; }
        public string? Answer { get; set; }
    }
}
