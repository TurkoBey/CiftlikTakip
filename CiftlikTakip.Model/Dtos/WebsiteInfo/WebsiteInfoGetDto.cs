﻿using Infrastructure.Model;

namespace CiftlikTakip.Model.Dtos.WebsiteInfo
{
    public class WebsiteInfoGetDto : IDto
    {
        public Guid Id { get; set; }
        public string? SiteName { get; set; }
        public string? Copyright { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? GoogleMapsLink { get; set; }
        public string? Description { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public Guid? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public string? Version { get; set; }
    }
}
