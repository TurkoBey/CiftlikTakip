using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class FServiceConfiguration : IEntityTypeConfiguration<FService>
    {
        public void Configure(EntityTypeBuilder<FService> builder)
        {
            // Tablo adı
            builder.ToTable("FServices");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.Title).HasMaxLength(150);
            builder.Property(v => v.Description).HasMaxLength(150);
            builder.Property(v => v.Icon).HasMaxLength(150);

            // İlişkilerin konfigürasyonu
        }
    }
}
