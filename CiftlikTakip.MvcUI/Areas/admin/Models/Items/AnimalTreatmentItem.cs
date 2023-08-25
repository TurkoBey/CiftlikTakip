namespace CiftlikTakip.MvcUI.Areas.admin.Models.Items
{
    public class AnimalTreatmentItem
    {
        public Guid Id { get; set; }
        public string? AnimalId { get; set; }
        public string? EmployeeName { get; set; }
        public DateTime IdentificationDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime MonitoringDate { get; set; }
        public string? RegularDose { get; set; }
        public string? SpecialDose { get; set; }
        public string? Description { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
