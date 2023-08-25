namespace CiftlikTakip.MvcUI.Areas.admin.Models.Dtos.NewTaskManagementDto
{
    public class NewTaskManagementDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public DateTime? DueData { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CategoryId { get; set; }
        public string? PriorityName { get; set; }
        public DateTime? ReminderData { get; set; }
        public bool Completed { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
    }
}
