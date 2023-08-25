namespace CiftlikTakip.MvcUI.Areas.admin.Models.Dtos.NewVaccinationDto
{
    public class NewVaccinationDto
    {
        public Guid Id { get; set; }
        public string? VaccinationName { get; set; }
        public string? Dosage { get; set; }
        public string? VaccinationDuration { get; set; }
        public string? Description { get; set; }
    }
}
