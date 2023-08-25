using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class FPricingConfiguration : IEntityTypeConfiguration<FPricing>
    {
        public void Configure(EntityTypeBuilder<FPricing> builder)
        {
            // Tablo adı
            builder.ToTable("FPricings");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.Title).HasMaxLength(150);
            builder.Property(v => v.Price).HasPrecision(18, 2);
            builder.Property(v => v.PriceType).HasMaxLength(50);

            // İlişkilerin konfigürasyonu
        }
    }
}
