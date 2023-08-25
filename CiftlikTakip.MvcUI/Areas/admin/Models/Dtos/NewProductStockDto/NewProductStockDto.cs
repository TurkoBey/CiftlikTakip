namespace CiftlikTakip.MvcUI.Areas.admin.Models.Dtos.NewProductStockDto
{
    public class NewProductStockDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public Guid StockId { get; set; }
        //public string? ProductName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string? WarrantyStatus { get; set; }
        public string? WarrantyDuration { get; set; }
        public DateTime WarrantyEndDate { get; set; }
        //public string? Image { get; set; }
        public string? Description { get; set; }
    }
}
