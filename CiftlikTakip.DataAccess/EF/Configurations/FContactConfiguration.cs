using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class FContactConfiguration : IEntityTypeConfiguration<FContact>
    {
        public void Configure(EntityTypeBuilder<FContact> builder)
        {
            // Tablo adı
            builder.ToTable("FContacts");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.FullName).HasMaxLength(150);
            builder.Property(v => v.Email).HasMaxLength(50);
            builder.Property(v => v.Subject).HasMaxLength(50);
            builder.Property(v => v.Message).HasMaxLength(250);

            // İlişkilerin konfigürasyonu
        }
    }
}
