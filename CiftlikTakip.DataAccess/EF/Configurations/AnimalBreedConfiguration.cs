using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class AnimalBreedConfiguration : IEntityTypeConfiguration<AnimalBreed>
    {
        public void Configure(EntityTypeBuilder<AnimalBreed> builder)
        {
            // Tablo adı
            builder.ToTable("AnimalBreeds");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.Title).HasMaxLength(150);
            builder.Property(v => v.GroupId).HasMaxLength(50);
            builder.Property(v => v.Description).HasMaxLength(200);

            // İlişkilerin konfigürasyonu
            builder.HasOne(d => d.BreedingRecord).WithOne(c => c.Breed).HasForeignKey<BreedingRecord>(b => b.BreedId);
        }
    }
}
