using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.AnimalStall
{
    public class AnimalStallGetDto : IDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
