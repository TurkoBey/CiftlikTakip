using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class UserAccessPermissionConfiguration : IEntityTypeConfiguration<UserAccessPermission>
    {
        public void Configure(EntityTypeBuilder<UserAccessPermission> builder)
        {
            // Tablo adı 
            builder.ToTable("UserAccessPermissions");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.Username).HasMaxLength(100);
            builder.Property(v => v.Email).HasMaxLength(100);
            builder.Property(v => v.Password).HasMaxLength(200);
            builder.Property(v => v.IPAddress).HasMaxLength(40);
            builder.Property(v => v.LastIPAddress).HasMaxLength(40);
            builder.Property(v => v.Description).HasMaxLength(200);

            // İlişkilerin konfigürasyonu
        }
    }
}
