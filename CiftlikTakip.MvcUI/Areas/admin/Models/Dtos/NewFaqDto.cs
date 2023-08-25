namespace CiftlikTakip.MvcUI.Areas.admin.Models.Dtos
{
    public class NewFaqDto
    {
        public Guid Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
    }
}
