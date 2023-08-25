namespace CiftlikTakip.MvcUI.Areas.admin.Models.Dtos
{
    public class NewProductFeedItemDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? FeedName { get; set; }
        public decimal Cost { get; set; }
        public decimal Quantity { get; set; }
        public string? QuantityName { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
    }
}
