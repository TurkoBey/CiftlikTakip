namespace CiftlikTakip.MvcUI.Areas.admin.Models.Dtos
{
    public class NewServiceDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
