using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public class Demo18UserAccessPermissions
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccessPermission>().HasData(new UserAccessPermission
            {
                Id = new Guid("95B090B4-5ECB-4578-9D7F-33FA7161BF54"),
                Username = "bakici",
                Email = "bakici@ciftliksurutakip.com",
                Password = "e10adc3949ba59abbe56e057f20f883e",
                IPAddress = "127.0.0.1",
                LastIPAddress = "127.0.0.1",
                LastLoginDate = DateTime.Now,
                PermissionStartDate = DateTime.Parse("2023-01-01"),
                PermissionEndDate = DateTime.Parse("2023-01-01"),
                EmployeeId = new Guid("36F708B9-B2F6-4E6A-AD25-0884E97BC520"),
                Description = "Açıklama - User 1",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Parse("2023-01-01"),
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new UserAccessPermission
            {
                Id = new Guid("CB0D8605-29B6-462C-8AA6-8D5AF95D507A"),
                Username = "ciftliktakip",
                Email = "ciftliktakip@ciftliksurutakip.com",
                Password = "e10adc3949ba59abbe56e057f20f883e",
                IPAddress = "127.0.0.1",
                LastIPAddress = "127.0.0.1",
                LastLoginDate = DateTime.Now,
                PermissionStartDate = DateTime.Parse("2023-01-01"),
                PermissionEndDate = DateTime.Parse("2023-01-01"),
                EmployeeId = new Guid("ED9BB364-C933-4349-BA2F-D75D31E6F203"),
                Description = "Açıklama - User 2",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new UserAccessPermission
            {
                Id = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                Username = "admin",
                Email = "admin@ciftliksurutakip.com",
                Password = "21232f297a57a5a743894a0e4a801fc3",
                IPAddress = "127.0.0.1",
                LastIPAddress = "127.0.0.1",
                LastLoginDate = DateTime.Now,
                PermissionStartDate = DateTime.Parse("2023-01-01"),
                PermissionEndDate = DateTime.Parse("2023-01-01"),
                EmployeeId = new Guid("3B7E6156-27AA-4FBD-B222-FC090B18A78A"),
                Description = "Açıklama - User 3",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            });
        }
    }
}
