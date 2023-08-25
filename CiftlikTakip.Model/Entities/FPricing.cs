using CiftlikTakip.Model.Entities.Base;

namespace CiftlikTakip.Model.Entities
{
    public class FPricing : BaseEntity
    {
        public string? Title { get; set; }
        public decimal? Price { get; set; }
        public string? PriceType { get; set; }
    }
}
