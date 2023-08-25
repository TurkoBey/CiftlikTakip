using CiftlikTakip.Model.Entities.Base;

namespace CiftlikTakip.Model.Entities
{
    public class AnimalTreatment : BaseEntity
    {
        public Guid AnimalId { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime IdentificationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime MonitoringDate { get; set; }
        public string? RegularDose { get; set; }
        public string? SpecialDose { get; set; }
        public BreedingRecord? BreedingRecord { get; set; }
    }
}
