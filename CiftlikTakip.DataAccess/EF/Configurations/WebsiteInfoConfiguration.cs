using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class WebsiteInfoConfiguration : IEntityTypeConfiguration<WebsiteInfo>
    {
        public void Configure(EntityTypeBuilder<WebsiteInfo> builder)
        {
            // Tablo adı 
            builder.ToTable("WebsiteInfos");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.SiteName).HasMaxLength(100);
            builder.Property(v => v.Copyright).HasMaxLength(250);
            builder.Property(v => v.Email).HasMaxLength(80);
            builder.Property(v => v.PhoneNumber).HasMaxLength(15);
            builder.Property(v => v.MobileNumber).HasMaxLength(15);
            builder.Property(v => v.Address).HasMaxLength(150);
            builder.Property(v => v.Description).HasMaxLength(200);

            // İlişkilerin konfigürasyonu 
        }
    }
}
