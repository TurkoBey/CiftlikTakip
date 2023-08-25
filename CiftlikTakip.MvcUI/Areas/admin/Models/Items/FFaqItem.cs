namespace CiftlikTakip.MvcUI.Areas.admin.Models.Items
{
    public class FFaqItem
    {
        public Guid Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
