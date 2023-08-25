using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.BreedingRecord
{
    public class BreedingRecordGetDto : IDto
    {
        public Guid Id { get; set; }
        public string? AnimalCode { get; set; }
        public Guid StallId { get; set; }
        public Guid SpecieId { get; set; }
        public string? BreedingName { get; set; }
        public DateTime BreedingDate { get; set; }
        public DateTime? ExpectedBirthDate { get; set; }
        public bool BreedingStatus { get; set; }
        public string? AnimalTypeName { get; set; }
        public decimal Cost { get; set; }
        public string? Description { get; set; }
    }
}
