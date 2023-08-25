using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CiftlikTakip.DataAccess.EF.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Tablo adı ve şema adı özelleştirmeleri yapabiliriz (isteğe bağlı).
            builder.ToTable("Employees");

            // Özelliklerin konfigürasyonu
            builder.Property(v => v.FirstName).HasMaxLength(50);
            builder.Property(v => v.LastName).HasMaxLength(50);
            builder.Property(v => v.LastName).HasMaxLength(20);
            builder.Property(v => v.Position).HasMaxLength(20);
            builder.Property(v => v.MobilePhone).HasMaxLength(15);
            builder.Property(v => v.SalaryType).HasMaxLength(10);
            builder.Property(v => v.Image).HasMaxLength(250);
            builder.Property(v => v.Salary).HasPrecision(18, 2);
            builder.Property(v => v.PaymentStatus).HasMaxLength(8);
            builder.Property(v => v.Description).HasMaxLength(200);

            // İlişkilerin konfigürasyonu 
            builder.HasOne(v => v.User).WithOne(a => a.Employee).HasForeignKey<UserAccessPermission>(b => b.EmployeeId);
        }
    }
}
