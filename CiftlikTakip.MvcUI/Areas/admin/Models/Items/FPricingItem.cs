namespace CiftlikTakip.MvcUI.Areas.admin.Models.Items
{
    public class FPricingItem
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public decimal? Price { get; set; }
        public string? PriceType { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
