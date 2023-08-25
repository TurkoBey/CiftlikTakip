using CiftlikTakip.Model.Entities.Base;

namespace CiftlikTakip.Model.Entities
{
    public class AnimalStall : BaseEntity
    {
        public string? Title { get; set; }
        public ICollection<BreedingRecord>? Breeds { get; set; }
    }
}
