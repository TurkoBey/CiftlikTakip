using System.ComponentModel.DataAnnotations.Schema;

namespace CiftlikTakip.MvcUI.Areas.admin.Models.Dtos
{
    public class NewEmployeeDto
    {
        public Guid Id { get; set; }
        public string? TCKN { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobilePhone { get; set; }
        public DateTime StartDate { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }

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
