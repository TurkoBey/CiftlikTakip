using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class AnimalStallConfiguration : IEntityTypeConfiguration<AnimalStall>
    {
        public void Configure(EntityTypeBuilder<AnimalStall> builder)
        {
            // Tablo adı
            builder.ToTable("AnimalStalls");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.Title).HasMaxLength(150);
            builder.Property(v => v.Description).HasMaxLength(200);

            // İlişkilerin konfigürasyonu
        }
    }
}