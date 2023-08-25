using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public class Demo21AnimalStalls
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalStall>().HasData(new AnimalStall
            {
                Id = new Guid("FFD13DAA-6F6C-420C-8EA5-086E68B6DBEE"),
                Title = "A10011",
                Description = "Des 2",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("05E42717-6C08-4E3B-A31C-138016C5B19F"),
                Title = "K20014",
                Description = "Des 37",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("C4206A96-3689-4E6C-8458-18516EC2DF83"),
                Title = "A10015",
                Description = "Des 36",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("2C8E2DD0-1F5E-4556-8D02-1897AFF85584"),
                Title = "K20014",
                Description = "Des 11",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("2D96A598-3436-4900-A906-230117D7355E"),
                Title = "K20016",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("7F572C9A-2EA0-42AB-8496-2E9C66406096"),
                Title = "A10019",
                Description = "Des 34",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("811967C7-CBD2-4F56-A1CA-30E2D6C9872F"),
                Title = "A10013",
                Description = "Des 19",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("9FC13177-9D38-47A9-B766-3C9FD5E061F7"),
                Title = "A10016",
                Description = "Des 26",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("28825D1B-AD6A-4A30-9BF6-4A7AF732F3CE"),
                Title = "A10017",
                Description = "Des 14",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("39D356D3-1A37-4E9B-A986-4EFFACDB5BDE"),
                Title = "K20011",
                Description = "Des 4",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("E253515F-1AF6-420A-9BC3-4FB719E1DDB5"),
                Title = "K20015",
                Description = "Des 38",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("50695A0E-BC17-411F-ABA9-51AB9F8090F3"),
                Title = "K20013",
                Description = "Des 8",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("770465F9-4B85-46B0-800D-56064538F101"),
                Title = "K20016",
                Description = "Des 28",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("CCBDD3C2-3A81-43FA-B3AB-5B2B0661BE94"),
                Title = "A10018",
                Description = "Des 17",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("5589EBB0-7A1B-4CFD-A5F2-6103DDBC7F41"),
                Title = "A10019",
                Description = "Des 31",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("D0E5F1D2-3BE2-45DD-B9E0-65F6C2F50AEB"),
                Title = "A10017",
                Description = "Des 40",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("99D7EC29-5FB7-436B-A52E-6816AC316CEC"),
                Title = "K20015",
                Description = "Des 12",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("6BE62237-FBFC-4FDF-A273-6FDD9AEED5E6"),
                Title = "K20019",
                Description = "Des 33",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("BA63BF5A-4E57-4662-ACCF-7F5FA3124C18"),
                Title = "A10014",
                Description = "Des 22",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("BC15234C-7C2A-41DF-984B-812A8AAE619E"),
                Title = "K20012",
                Description = "Des 7",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("16CC0B9A-E617-4343-A3CA-890E8C55C983"),
                Title = "A10015",
                Description = "Des 10",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("AE4BC981-DFD4-49FB-A87A-8A29DB2D343F"),
                Title = "A10016",
                Description = "Des 39",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("A4C13195-0C5D-4684-9031-8D6BAFD14037"),
                Title = "A10014",
                Description = "Des 9",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("40BD033F-C4AC-4E6D-90E1-9B38C9B10ED9"),
                Title = "K20010",
                Description = "Des 3",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("D3537BAF-93C4-404A-AB80-A8C4D8308F2F"),
                Title = "K20013",
                Description = "Des 21",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("D2F5F501-FFD8-4493-943C-AA3E6DD5AD56"),
                Title = "K20014",
                Description = "Des 24",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("3EBE2E2E-F4CD-45A3-95AB-AF7B54338DC8"),
                Title = "A10014",
                Description = "Des 35",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("8407DD3F-85CF-4DEB-9B92-B4F65A22F363"),
                Title = "A10012",
                Description = "Des 18",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("8706DFE8-B385-49AF-9B01-B9B9E1645C5B"),
                Title = "A10010",
                Description = "Des 1",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("2FCAAE64-2059-4CAA-9351-BE0F0E6A9A2A"),
                Title = "K20012",
                Description = "Des 20",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("62974800-9F92-4F6E-81D5-BF32EFD7623B"),
                Title = "A10017",
                Description = "Des 27",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("082284CF-3222-4100-9862-C20227BD1A48"),
                Title = "A10012",
                Description = "Des 5",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("A181532F-42AF-46E9-8699-C3A78EF6F19A"),
                Title = "A10015",
                Description = "Des 23",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("2DF88A33-5289-4D0E-A15A-CBDF6F54B69B"),
                Title = "A10016",
                Description = "Des 13",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("E0F6D7BA-AFF8-4175-91D1-D3639E5F8A59"),
                Title = "K20017",
                Description = "Des 29",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("C79802DC-2BAF-41E1-8061-E51B8FEADD70"),
                Title = "A10018",
                Description = "Des 30",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("CD9642F0-DEBB-4A3C-A6EE-E90EC3BA2F19"),
                Title = "K20017",
                Description = "Des 16",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("07BF7A77-013F-4F2D-858A-F14E94D50594"),
                Title = "K20018",
                Description = "Des 32",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("3628D10A-E6B5-4E62-A58B-F2DD7379D83E"),
                Title = "K20015",
                Description = "Des 25",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new AnimalStall
            {
                Id = new Guid("02787BA3-D844-4396-9CBF-FCA397B810A0"),
                Title = "A10013",
                Description = "Des 6",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01 00:00:00.0000000"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }
            );
        }
    }
}
