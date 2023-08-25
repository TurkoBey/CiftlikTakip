using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.AnimalStall
{
    public class AnimalStallPostDto : JsonIgnoreDto, IDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
