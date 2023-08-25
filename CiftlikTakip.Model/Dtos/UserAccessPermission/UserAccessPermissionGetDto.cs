using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.UserAccessPermission
{
    public class UserAccessPermissionGetDto : IDto
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? IPAddress { get; set; }
        public string? LastIPAddress { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? PermissionStartDate { get; set; }
        public DateTime? PermissionEndDate { get; set; }
        public string? EmployeeName { get; set; }
        public string? Description { get; set; }
    }
}
