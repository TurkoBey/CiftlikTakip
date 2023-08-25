using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.FFaq
{
    public class FFaqPostDto : JsonIgnoreDto, IDto
    {
        public Guid Id { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
    }
}
