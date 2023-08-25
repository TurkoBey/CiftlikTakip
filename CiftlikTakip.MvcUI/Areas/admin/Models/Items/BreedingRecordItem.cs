namespace CiftlikTakip.MvcUI.Areas.admin.Models.Items
{
    public class BreedingRecordItem
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
        public DateTime? UpdateDate { get; set; }
    }
}
