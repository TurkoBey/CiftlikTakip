using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.FService
{
    public class FServicePutDto : JsonIgnoreDto, IDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
    }
}
