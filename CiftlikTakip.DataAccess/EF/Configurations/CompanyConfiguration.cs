using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            // Tablo adı
            builder.ToTable("Companies");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.CompanyName).HasMaxLength(120);
            builder.Property(v => v.FullName).HasMaxLength(150);
            builder.Property(v => v.MobileNumber).HasMaxLength(15);
            builder.Property(v => v.PhoneNumber).HasMaxLength(15);
            builder.Property(v => v.Email).HasMaxLength(80);
            builder.Property(v => v.Address).HasMaxLength(150);
            builder.Property(v => v.Description).HasMaxLength(200);
        }
    }
}
