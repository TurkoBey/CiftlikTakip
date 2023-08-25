using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class BreedingRecordConfiguration : IEntityTypeConfiguration<BreedingRecord>
    {
        public void Configure(EntityTypeBuilder<BreedingRecord> builder)
        {
            // Tablo adı
            builder.ToTable("BreedingRecords");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.AnimalCode).HasMaxLength(14);
            builder.Property(v => v.Description).HasMaxLength(200);
            // builder.Property(v => v.AnimalCode).HasMaxLength(14).IsRequired(); // Zorunlu Grekli NULL geçilemez hale gelir.
            builder.Property(v => v.Cost).HasColumnType("decimal(18, 2)");

            // İlişkilerin konfigürasyonu 
        }
    }
}
