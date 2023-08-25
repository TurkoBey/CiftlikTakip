﻿namespace CiftlikTakip.MvcUI.Areas.admin.Models.Items
{
    public class CompanyItem
    {
        public Guid Id { get; set; }
        public string? CompanyName { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? MobileNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public Guid DistrictId { get; set; }
        public string? Description { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
