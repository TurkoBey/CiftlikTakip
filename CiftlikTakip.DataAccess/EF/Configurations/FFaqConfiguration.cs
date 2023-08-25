using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class FFaqConfiguration : IEntityTypeConfiguration<FFaq>
    {
        public void Configure(EntityTypeBuilder<FFaq> builder)
        {
            // Tablo adı
            builder.ToTable("FFaqs");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.Question).HasMaxLength(150);
            builder.Property(v => v.Answer).HasMaxLength(250);

            // İlişkilerin konfigürasyonu
        }
    }
}