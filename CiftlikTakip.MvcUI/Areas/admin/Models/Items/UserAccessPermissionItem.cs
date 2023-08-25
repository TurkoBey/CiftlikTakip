namespace CiftlikTakip.MvcUI.Areas.admin.Models.Items
{
    public class UserAccessPermissionItem
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? IPAddress { get; set; }
        public string? LastIPAddress { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
