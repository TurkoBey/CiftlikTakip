namespace CiftlikTakip.MvcUI.Areas.admin.Models.Dtos
{
    public class LogInDto
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? IPAddress { get; set; }
    }
}
