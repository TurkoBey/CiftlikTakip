using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class FTeamConfiguration : IEntityTypeConfiguration<FTeam>
    {
        public void Configure(EntityTypeBuilder<FTeam> builder)
        {
            // Tablo adı
            builder.ToTable("FTeams");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.FullName).HasMaxLength(50);
            builder.Property(v => v.Role).HasMaxLength(50);
            builder.Property(v => v.Twitter).HasMaxLength(50);
            builder.Property(v => v.Facebook).HasMaxLength(50);
            builder.Property(v => v.Instagram).HasMaxLength(50);
            builder.Property(v => v.LinkedIn).HasMaxLength(50);

            // İlişkilerin konfigürasyonu
        }
    }
}