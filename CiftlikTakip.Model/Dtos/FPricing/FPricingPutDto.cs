using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.FPricing
{
    public class FPricingPutDto : JsonIgnoreDto, IDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public decimal? Price { get; set; }
        public string? PriceType { get; set; }
    }
}
