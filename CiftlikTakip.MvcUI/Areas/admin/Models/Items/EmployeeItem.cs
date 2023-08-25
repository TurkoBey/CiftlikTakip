namespace CiftlikTakip.MvcUI.Areas.admin.Models.Items
{
    public class EmployeeItem
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
