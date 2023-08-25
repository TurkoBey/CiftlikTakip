using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.BreedingRecord
{
    public class BreedingRecordPutDto : JsonIgnoreDto, IDto
    {
        public Guid Id { get; set; }
        public string? AnimalCode { get; set; }
        public Guid StallId { get; set; }
        public Guid SpecieId { get; set; }
        public byte? BreedingType { get; set; } // BAŞLIKLARI ENUM OLARAK TUTACAM, ID'lerini tabloya eklecem.. => Suni - Doğal
        public string? BreedingName { get; set; }
        public DateTime BreedingDate { get; set; }
        public DateTime? ExpectedBirthDate { get; set; }
        public bool BreedingStatus { get; set; }
        public byte? AnimalType { get; set; }
        public string? AnimalTypeName { get; set; }
        public decimal Cost { get; set; }
        public string? Description { get; set; }
    }
}
