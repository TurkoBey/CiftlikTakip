using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public class Demo22BreedingRecords
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalStall>().HasData(new AnimalBreed
            {
                Id = new Guid("7D5BD7A9-C633-4EA5-A239-C4190CE4BD8B"),
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
                Id = new Guid("E007E2E7-01CC-4DE6-985F-0CB3FBE235AA"),
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
                Id = new Guid("3EBF451F-1F74-48FD-AC1F-BDA0E2DAA0B7"),
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
                Id = new Guid("D7CC1A6C-55B1-4BE8-B418-72D85C97D80B"),
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
                Id = new Guid("6D0F0400-4101-4A1A-8BFF-6DC86E5942F0"),
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
                Id = new Guid("6981CE02-7F74-4FBC-9669-353EAC4EC825"),
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
                Id = new Guid("8BBC5D7F-A9F2-4169-AA92-6E848F804C88"),
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
                Id = new Guid("12E61947-A7E3-4B84-B0BC-19C10EB34A40"),
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
                Id = new Guid("2C8F794F-3DEA-43B7-8F4B-481CA7F9730B"),
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
                Id = new Guid("0A826C83-6951-4C8E-A3FE-7150946ADA31"),
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
                Id = new Guid("1A0296ED-8C28-4A93-9684-D0730A2EE089"),
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
                Id = new Guid("201A4160-3A01-464B-9F3A-E726B6822346"),
                Title = "SHORTHORN SIĞIR IRKI",
                GroupId = 105,
                Description = "Des 12",
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
