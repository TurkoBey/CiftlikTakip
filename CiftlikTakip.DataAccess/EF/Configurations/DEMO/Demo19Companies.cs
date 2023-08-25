using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public class Demo19Companies
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = new Guid("8C733763-EEE1-49BE-864C-DDEF6A34C2C5"),
                CompanyName = "Company 1",
                FullName = "Name Surname 1",
                Email = "info@company1.com",
                PhoneNumber = "905554443322",
                MobileNumber = "902122222222",
                Address = "Bla bla Mah. Güneş Caddesi Elma Sok. 5/4",
                Description = "Açıklama - 1",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Company
            {
                Id = new Guid("837109A8-35BB-42A3-9D52-B616037F78EE"),
                CompanyName = "Company 2",
                FullName = "Name Surname 2",
                Email = "info@company2.com",
                PhoneNumber = "905554449988",
                MobileNumber = "902123333333",
                Address = "Bla bla Mah. Güneş Caddesi Elma Sok. 5/2",
                Description = "Açıklama - 2",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Company
            {
                Id = new Guid("01C6229C-5234-4932-9098-90E086C90C8C"),
                CompanyName = "Company 3",
                FullName = "Name Surname 3",
                Email = "info@company3.com",
                PhoneNumber = "905554448877",
                MobileNumber = "902124444444",
                Address = "Bla bla Mah. Güneş Caddesi Elma Sok. 5/1",
                Description = "Açıklama - 3",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            });
        }
    }
}
