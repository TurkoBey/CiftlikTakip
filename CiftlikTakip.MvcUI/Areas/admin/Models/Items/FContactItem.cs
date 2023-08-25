namespace CiftlikTakip.MvcUI.Areas.admin.Models.Items
{
    public class FContactItem
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
