using CiftlikTakip.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiftlikTakip.Model.Entities
{
    public class Employee : BaseEntity
    {
        public string? TCKN { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }
        public string? MobilePhone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? SalaryType { get; set; }
        public decimal? Salary { get; set; }
        public string? PaymentStatus { get; set; }
        public string? Image { get; set; }
        public Guid DistrictId { get; set; }
        public UserAccessPermission? User { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
