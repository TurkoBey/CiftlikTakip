using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public class Demo30FSevrices
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FService>().HasData(new FService
            {
                Id = new Guid("A89B92F0-C38D-4B6A-8CC2-2D8753495080"),
                Title = "Hayvanların detaylı bilgi ve soy ağacı",
                Icon = "bi bi-briefcase",
                Description = "Hayvanın bireysel bilgilerine ulaşabilir, yeni bilgiler ekleyebilir ya da güncelleyebilirsiniz.",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new FService
            {
                Id = new Guid("B89B92F0-C38D-4B6A-8CC2-2D8753495080"),
                Title = "Hayvanların detaylı bilgi ve soy ağacı",
                Icon = "bi bi-briefcase",
                Description = "Hayvanın bireysel bilgilerine ulaşabilir, yeni bilgiler ekleyebilir ya da güncelleyebilirsiniz. 2",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }
            );
        }
    }
}
