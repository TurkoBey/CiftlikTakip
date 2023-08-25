using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public static class Demo10WebsiteInfo
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebsiteInfo>().HasData(new WebsiteInfo
            {
                Id = new Guid("A89B92F0-C38D-4B6A-8CC2-2D8753495080"),
                SiteName = "Çiftlik Sürü Takip Yazılımı",
                Copyright = "© Copyright 2000 - 2023 ciftliksurutakip.com.tr",
                PhoneNumber = "902124443322",
                MobileNumber = "905554443322",
                Email = "info@ciftliksurutakip.com.tr",
                Address = "Çiftlik Adresi",
                GoogleMapsLink = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d24478.541479040752!2d32.850114!3d39.923096!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d34f01d808af9b%3A0x6f1ffe86aa5cf7af!2zVmVrdMO2cmVsIEJpbGnFn2lt!5e0!3m2!1str!2str!4v1692436590405!5m2!1str!2str",
                Description = "Tükiyenin En İyi Büyükbaş Hayvan Takip Sistemi Hayvan şecere takibi, tedavi takibi ve alarmlar, çiftleşme takibi ve öneriler buna benzer bir çok özellikleri ile işinizi kolaylaştırıyoruz.",
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