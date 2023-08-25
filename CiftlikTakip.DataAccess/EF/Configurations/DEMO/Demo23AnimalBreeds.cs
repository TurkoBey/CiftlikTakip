using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public class Demo23AnimalBreeds
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalBreed>().HasData(new AnimalBreed
            {
                Id = new Guid("E6EFA4EA-07DC-4A01-8D66-D7CDE7EC8F29"),
                Title = "ZAVOT SIĞIRI",
                GroupId = 100,
                Description = "Des 1",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("D58DEAFE-527A-4DFE-9379-32713B47AF6E"),
                Title = "BOZ IRK SIĞIRI",
                GroupId = 101,
                Description = "Des 2",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("32A66FC3-433A-4B41-A617-72BE38A717D5"),
                Title = "JERSEY SIĞIR IRKI",
                GroupId = 102,
                Description = "Des 3",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("111408A0-E69D-443E-BA7F-81F57CC3B3DB"),
                Title = "YERLİ KARA SIĞIRI",
                GroupId = 103,
                Description = "Des 4",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("5EC3BD17-203C-4132-A897-3A039DED23D5"),
                Title = "GUERNSEY SIĞIR IRKI",
                GroupId = 104,
                Description = "Des 5",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("024789B5-BEA8-46DF-B51C-A8A4EE6FB5F6"),
                Title = "SHORTHORN SIĞIR IRKI",
                GroupId = 105,
                Description = "Des 6",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("2D08EC4D-2A41-4C5B-8DBC-5B7473B58AF5"),
                Title = "ZAVOT SIĞIRI",
                GroupId = 100,
                Description = "Des 7",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("DDCE486D-87D3-42F2-9353-2FD48F23B403"),
                Title = "BOZ IRK SIĞIRI",
                GroupId = 101,
                Description = "Des 8",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("9717405A-4E0E-4F74-A032-3E9F7A1D85E2"),
                Title = "JERSEY SIĞIR IRKI",
                GroupId = 102,
                Description = "Des 9",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("14DE44D4-694B-4329-83DD-6896E6D14CD6"),
                Title = "YERLİ KARA SIĞIRI",
                GroupId = 103,
                Description = "Des 10",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("B427AED9-58A1-4CE7-9402-D5A87B5F39C7"),
                Title = "GUERNSEY SIĞIR IRKI",
                GroupId = 104,
                Description = "Des 11",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("94287385-B963-477D-A757-B5D818F7BDD4"),
                Title = "SHORTHORN SIĞIR IRKI",
                GroupId = 105,
                Description = "Des 12",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("D3AE627F-074C-4D4E-8D17-198C0116FB2D"),
                Title = "ZAVOT SIĞIRI",
                GroupId = 102,
                Description = "Des 13",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("DA47DE14-1C11-41CE-937A-64BE4561D1E7"),
                Title = "BOZ IRK SIĞIRI",
                GroupId = 103,
                Description = "Des 14",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("B45EB8B8-CB92-47EA-8733-9CF3E2B56A66"),
                Title = "JERSEY SIĞIR IRKI",
                GroupId = 104,
                Description = "Des 15",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("8E92618F-BDC0-4B78-A318-804A05E1CF24"),
                Title = "YERLİ KARA SIĞIRI",
                GroupId = 105,
                Description = "Des 16",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("7811E519-35C1-43CA-AE14-484DA3626F25"),
                Title = "GUERNSEY SIĞIR IRKI",
                GroupId = 102,
                Description = "Des 17",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("60A493BF-71B9-47D6-B380-26FD210786C4"),
                Title = "SHORTHORN SIĞIR IRKI",
                GroupId = 103,
                Description = "Des 18",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("1D02BAA3-F717-499B-B4C2-0382EC490B2C"),
                Title = "ZAVOT SIĞIRI",
                GroupId = 104,
                Description = "Des 19",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("E762B2AC-0B95-4C92-8552-1D3255359462"),
                Title = "BOZ IRK SIĞIRI",
                GroupId = 105,
                Description = "Des 20",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("3DC9A4BF-2075-4A0E-BB1D-3437C4604460"),
                Title = "JERSEY SIĞIR IRKI",
                GroupId = 102,
                Description = "Des 21",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("31798234-B9F7-41FB-BB90-08ED320A104C"),
                Title = "YERLİ KARA SIĞIRI",
                GroupId = 103,
                Description = "Des 22",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("C65D7C9B-B1AD-49CD-909C-E8A9CC293E20"),
                Title = "GUERNSEY SIĞIR IRKI",
                GroupId = 104,
                Description = "Des 23",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("057B6C4F-B4D5-453F-9B12-7C3FEC96BB56"),
                Title = "SHORTHORN SIĞIR IRKI",
                GroupId = 105,
                Description = "Des 24",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("2719F414-C3F0-4E63-A188-BB5A0411C4A0"),
                Title = "ZAVOT SIĞIRI",
                GroupId = 102,
                Description = "Des 25",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("E387571F-7563-4164-8D0D-D08C051AEC3A"),
                Title = "BOZ IRK SIĞIRI",
                GroupId = 103,
                Description = "Des 26",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("F2B14DCA-3909-455F-B951-FBBBE1A94B85"),
                Title = "JERSEY SIĞIR IRKI",
                GroupId = 104,
                Description = "Des 27",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("93CC36D5-E829-43DC-92C4-1A5CBF110C24"),
                Title = "YERLİ KARA SIĞIRI",
                GroupId = 105,
                Description = "Des 28",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("17C1F020-5420-4072-9EB7-5BA713484500"),
                Title = "GUERNSEY SIĞIR IRKI",
                GroupId = 102,
                Description = "Des 29",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("CDE18D0D-C8D1-40E0-9EB8-8B6F9F84F77D"),
                Title = "SHORTHORN SIĞIR IRKI",
                GroupId = 103,
                Description = "Des 30",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("7DAA5E9D-B207-4DBF-A1E4-4CB99B7261F1"),
                Title = "ZAVOT SIĞIRI",
                GroupId = 104,
                Description = "Des 31",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("8A6E6FCE-D1EF-4ADB-AC47-E47040A1FAF8"),
                Title = "BOZ IRK SIĞIRI",
                GroupId = 105,
                Description = "Des 32",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("FC9A9C48-48D6-4D96-98C9-BBDFBE1C43E6"),
                Title = "JERSEY SIĞIR IRKI",
                GroupId = 102,
                Description = "Des 33",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("35ED99D4-9BC7-4CF4-955A-629B78B72364"),
                Title = "YERLİ KARA SIĞIRI",
                GroupId = 103,
                Description = "Des 34",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("EB7C258F-582F-4E7D-B39D-ECBD1762C25D"),
                Title = "GUERNSEY SIĞIR IRKI",
                GroupId = 104,
                Description = "Des 35",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("30CC0E18-AAB1-4F1E-A6D1-007C1E884C19"),
                Title = "SHORTHORN SIĞIR IRKI",
                GroupId = 105,
                Description = "Des 36",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("24799A97-912A-4DFA-8A5A-5EC3478DA3EB"),
                Title = "ZAVOT SIĞIRI",
                GroupId = 102,
                Description = "Des 37",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("5A278165-8B87-4F7F-A0F0-7A27D371D463"),
                Title = "BOZ IRK SIĞIRI",
                GroupId = 103,
                Description = "Des 38",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("3F18FFA5-1C73-49F0-A69D-8EAB3F290893"),
                Title = "JERSEY SIĞIR IRKI",
                GroupId = 104,
                Description = "Des 39",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalBreed
            {
                Id = new Guid("463FCD5E-5D38-4A33-9981-C54020ADB26D"),
                Title = "YERLİ KARA SIĞIRI",
                GroupId = 105,
                Description = "Des 40",
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
