using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.FContact
{
    public class FContactPostDto :JsonIgnoreDto, IDto
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
    }
}
