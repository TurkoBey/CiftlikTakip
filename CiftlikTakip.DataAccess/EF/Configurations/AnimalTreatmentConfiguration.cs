using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class AnimalTreatmentConfiguration : IEntityTypeConfiguration<AnimalTreatment>
    {
        public void Configure(EntityTypeBuilder<AnimalTreatment> builder)
        {
            // Tablo adı
            builder.ToTable("AnimalTreatments");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.RegularDose).HasMaxLength(30);
            builder.Property(v => v.SpecialDose).HasMaxLength(30);
            builder.Property(v => v.Description).HasMaxLength(200);

            // İlişkilerin konfigürasyonu 
            builder.HasOne(d => d.BreedingRecord).WithMany(c => c.AnimalTreatments).HasForeignKey(d => d.AnimalId);
        }
    }
}
