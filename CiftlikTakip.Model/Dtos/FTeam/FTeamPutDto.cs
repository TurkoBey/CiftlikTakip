using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.FTeam
{
    public class FTeamPutDto : JsonIgnoreDto, IDto
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? PhotoPath { get; set; }
        public string? Role { get; set; }
        public string? Twitter { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? LinkedIn { get; set; }
        public string? Description { get; set; }
    }
}
