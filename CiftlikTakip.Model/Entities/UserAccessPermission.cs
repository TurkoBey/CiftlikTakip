using CiftlikTakip.Model.Entities.Base;

namespace CiftlikTakip.Model.Entities
{
    public class UserAccessPermission : BaseEntity
    {
        public Guid EmployeeId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? IPAddress { get; set; }
        public string? LastIPAddress { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? PermissionStartDate { get; set; }
        public DateTime? PermissionEndDate { get; set; }
        public Employee? Employee { get; set; }
    }
}
