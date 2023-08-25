using CiftlikTakip.Model.Entities.Base;

namespace CiftlikTakip.Model.Entities
{
    public class BreedingRecord : BaseEntity
    {
        public string? AnimalCode { get; set; }
        public Guid StallId { get; set; }
        public Guid BreedId { get; set; }
        public byte? BreedingType { get; set; } 
        public DateTime BreedingDate { get; set; }
        public DateTime? ExpectedBirthDate { get; set; }
        public bool BreedingStatus { get; set; }
        public byte? AnimalType { get; set; }
        public decimal Cost { get; set; }
        public AnimalBreed? Breed { get; set; }
        public AnimalStall? Stall { get; set; }
        public ICollection<AnimalTreatment>? AnimalTreatments { get; set; }
    }
}
