using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public class Demo32FPricings
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FPricing>().HasData(new FPricing
            {
                Id = new Guid("A89B92F0-C38D-4B6A-8CC2-2D8753495080"),
                Title = "DB Hizmetler Başlık 1",
                Price = 350,
                PriceType = "bi bi-briefcase",
                Description = "DB Hizmetler Açıklama 1",
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
