using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.Employee
{
    public class EmployeePutDto : JsonIgnoreDto, IDto
    {
        public Guid Id { get; set; }
        public string? TCKN { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobilePhone { get; set; }
        public DateTime StartDate { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
    }
}
