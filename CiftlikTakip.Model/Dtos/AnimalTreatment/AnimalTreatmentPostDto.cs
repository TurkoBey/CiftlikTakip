using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.AnimalTreatment
{
    public class AnimalTreatmentPostDto : JsonIgnoreDto, IDto
    {
        public Guid Id { get; set; }
        public Guid AnimalId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime IdentificationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime MonitoringDate { get; set; }
        public string? RegularDose { get; set; }
        public string? SpecialDose { get; set; }
        public string? Description { get; set; }
    }
}
