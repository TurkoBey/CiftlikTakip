using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public class Demo29FFaqs
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FFaq>().HasData(new FFaq
            {
                Id = new Guid("A89B92F0-C38D-4B6A-8CC2-2D8753495080"),
                Question = "Sistem mobil cihazlarla uyumlu mu?",
                Answer = "Ciftliksürütakip telefon, tablet, bilgisayar gibi her türlü cihazdan sorunsuz bir şekilde kullanılabilir. Yükleme gerektirmez.",
                Description = null,
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new FFaq
            {
                Id = new Guid("B89B92F0-D38D-4B6A-8CC2-2D8753495080"),
                Question = "Bulut tabanlı yazılım nedir?",
                Answer = "Ciftliksürütakip bulut tabanlı olarak çalışır. Kullancıları yaptığı güncellemeler dünyanın her yerinden anında görüntülenebilir. Program kurulumu gerektirmez.",
                Description = null,
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new FFaq
            {
                Id = new Guid("C89B92F0-D38D-4B6A-8CC2-2D8753495080"),
                Question = "Hangi bilgileri kaydedebilirim?",
                Answer = "Hayvan kimlik bilgileri, eşleşme bilgileri, padok bilgileri, yavru verim bilgileri, geçmiş ve gelecek tedaviler, aile bağları gibi bütün bilgileri kaydedebilirsiniz. Tek bir küpe okutarak hayvanın bütün geçmiş bilgilerine ulaşabilirsiniz.",
                Description = null,
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
