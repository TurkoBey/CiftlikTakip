using CiftlikTakip.Model.Entities.Base;

namespace CiftlikTakip.Model.Entities
{
    public class AnimalBreed : BaseEntity
    {
        public string? Title { get; set; }
        public byte? GroupId { get; set; }
        public BreedingRecord? BreedingRecord { get; set; }
    }
}
