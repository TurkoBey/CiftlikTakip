using Infrastructure.Model;
using System.Text.Json.Serialization;

namespace CiftlikTakip.Model.Dtos.UserAccessPermission
{
    public class UserAccessPermissionPostDto : JsonIgnoreDto, IDto
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Description { get; set; }

        [JsonIgnore]
        public string? IPAddress { get; set; }
        [JsonIgnore]
        public string? LastIPAddress { get; set; }
        [JsonIgnore]
        public DateTime? LastLoginDate { get; set; }
        [JsonIgnore]
        public DateTime? PermissionStartDate { get; set; }
        [JsonIgnore]
        public DateTime? PermissionEndDate { get; set; }
    }
}
