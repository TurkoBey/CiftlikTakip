﻿using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public class Demo25BreedingRecords
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BreedingRecord>().HasData(new BreedingRecord
            {
                Id = new Guid("D144C0AB-A607-4299-888E-2FE52162731C"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("8706DFE8-B385-49AF-9B01-B9B9E1645C5B"),
                BreedId = new Guid("E6EFA4EA-07DC-4A01-8D66-D7CDE7EC8F29"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2020-01-01"),
                ExpectedBirthDate = DateTime.Parse("2020-09-30"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 24889,
                Description = "Des 1",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("C4C0D9F2-C9B7-42F9-9C85-2FB1AE7CA38D"),
                AnimalCode = "TR051000000001",
                StallId = new Guid("FFD13DAA-6F6C-420C-8EA5-086E68B6DBEE"),
                BreedId = new Guid("D58DEAFE-527A-4DFE-9379-32713B47AF6E"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2021-02-01"),
                ExpectedBirthDate = DateTime.Parse("2021-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 29316,
                Description = "Des 2",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("9DBCEF82-207C-4CB4-8786-D70B0C49F7F8"),
                AnimalCode = "TR161002684601",
                StallId = new Guid("40BD033F-C4AC-4E6D-90E1-9B38C9B10ED9"),
                BreedId = new Guid("32A66FC3-433A-4B41-A617-72BE38A717D5"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 20293,
                Description = "Des 3",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("32E8C0BA-D674-430E-B88C-1D5F5612F781"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("39D356D3-1A37-4E9B-A986-4EFFACDB5BDE"),
                BreedId = new Guid("111408A0-E69D-443E-BA7F-81F57CC3B3DB"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 24680,
                Description = "Des 4",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("206AAA0A-A3B5-418D-B15A-0DE5A75780A8"),
                AnimalCode = "TR051000000001",
                StallId = new Guid("082284CF-3222-4100-9862-C20227BD1A48"),
                BreedId = new Guid("5EC3BD17-203C-4132-A897-3A039DED23D5"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2020-01-01"),
                ExpectedBirthDate = DateTime.Parse("2020-09-30"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 39836,
                Description = "Des 5",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("A02AC11B-CFE2-4AB6-9823-1EC583B4310C"),
                AnimalCode = "TR161002684601",
                StallId = new Guid("02787BA3-D844-4396-9CBF-FCA397B810A0"),
                BreedId = new Guid("024789B5-BEA8-46DF-B51C-A8A4EE6FB5F6"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2021-02-01"),
                ExpectedBirthDate = DateTime.Parse("2021-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 49227,
                Description = "Des 6",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("63627264-E111-4B2C-9CD0-6D521612512D"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("BC15234C-7C2A-41DF-984B-812A8AAE619E"),
                BreedId = new Guid("2D08EC4D-2A41-4C5B-8DBC-5B7473B58AF5"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 25529,
                Description = "Des 7",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("A3E2D751-9BA0-4F01-B31E-6409C3F17CBA"),
                AnimalCode = "TR051000000001",
                StallId = new Guid("50695A0E-BC17-411F-ABA9-51AB9F8090F3"),
                BreedId = new Guid("DDCE486D-87D3-42F2-9353-2FD48F23B403"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 37571,
                Description = "Des 8",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("64C29812-405C-4C0D-859F-B75C1889588D"),
                AnimalCode = "TR161002684601",
                StallId = new Guid("A4C13195-0C5D-4684-9031-8D6BAFD14037"),
                BreedId = new Guid("9717405A-4E0E-4F74-A032-3E9F7A1D85E2"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2020-01-01"),
                ExpectedBirthDate = DateTime.Parse("2020-09-30"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 18346,
                Description = "Des 9",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("0B490220-3E78-443E-B42E-6418688152DA"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("16CC0B9A-E617-4343-A3CA-890E8C55C983"),
                BreedId = new Guid("14DE44D4-694B-4329-83DD-6896E6D14CD6"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2021-02-01"),
                ExpectedBirthDate = DateTime.Parse("2021-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 14704,
                Description = "Des 10",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("81C506F7-72E8-4D6E-B325-185DD0440D99"),
                AnimalCode = "TR051000000001",
                StallId = new Guid("2C8E2DD0-1F5E-4556-8D02-1897AFF85584"),
                BreedId = new Guid("B427AED9-58A1-4CE7-9402-D5A87B5F39C7"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 47203,
                Description = "Des 11",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("A712B16B-3F5C-4044-A5A0-CCD4D19A989B"),
                AnimalCode = "TR161002684601",
                StallId = new Guid("99D7EC29-5FB7-436B-A52E-6816AC316CEC"),
                BreedId = new Guid("94287385-B963-477D-A757-B5D818F7BDD4"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 33458,
                Description = "Des 12",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("E5B8BC5D-1DB9-4B80-ADF8-0B85F4B77568"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("2DF88A33-5289-4D0E-A15A-CBDF6F54B69B"),
                BreedId = new Guid("D3AE627F-074C-4D4E-8D17-198C0116FB2D"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2020-01-01"),
                ExpectedBirthDate = DateTime.Parse("2020-09-30"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 38832,
                Description = "Des 13",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("9BDAF1C4-7387-478F-81D7-B43D980434CF"),
                AnimalCode = "TR051000000001",
                StallId = new Guid("28825D1B-AD6A-4A30-9BF6-4A7AF732F3CE"),
                BreedId = new Guid("DA47DE14-1C11-41CE-937A-64BE4561D1E7"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2021-02-01"),
                ExpectedBirthDate = DateTime.Parse("2021-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 34836,
                Description = "Des 14",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("763BD6EF-866A-4131-803E-1851BFAE2570"),
                AnimalCode = "TR161002684601",
                StallId = new Guid("2D96A598-3436-4900-A906-230117D7355E"),
                BreedId = new Guid("B45EB8B8-CB92-47EA-8733-9CF3E2B56A66"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 18814,
                Description = "Des 15",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("31DAE6DC-624B-4888-A38B-A89647C09006"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("CD9642F0-DEBB-4A3C-A6EE-E90EC3BA2F19"),
                BreedId = new Guid("8E92618F-BDC0-4B78-A318-804A05E1CF24"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 42026,
                Description = "Des 16",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("13E205C1-EE28-47B6-BD87-07D802E0D340"),
                AnimalCode = "TR051000000001",
                StallId = new Guid("CCBDD3C2-3A81-43FA-B3AB-5B2B0661BE94"),
                BreedId = new Guid("7811E519-35C1-43CA-AE14-484DA3626F25"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2020-01-01"),
                ExpectedBirthDate = DateTime.Parse("2020-09-30"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 24393,
                Description = "Des 17",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("F08E8FC1-4518-4AD5-A556-9ADB009E4264"),
                AnimalCode = "TR161002684601",
                StallId = new Guid("8407DD3F-85CF-4DEB-9B92-B4F65A22F363"),
                BreedId = new Guid("60A493BF-71B9-47D6-B380-26FD210786C4"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2021-02-01"),
                ExpectedBirthDate = DateTime.Parse("2021-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 34815,
                Description = "Des 18",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("01634C19-C918-4A47-94EF-F6E2D05CB5BC"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("811967C7-CBD2-4F56-A1CA-30E2D6C9872F"),
                BreedId = new Guid("1D02BAA3-F717-499B-B4C2-0382EC490B2C"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 46544,
                Description = "Des 19",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("E1274E29-C86C-49C7-AB12-4704B8708CA5"),
                AnimalCode = "TR051000000001",
                StallId = new Guid("2FCAAE64-2059-4CAA-9351-BE0F0E6A9A2A"),
                BreedId = new Guid("E762B2AC-0B95-4C92-8552-1D3255359462"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 40772,
                Description = "Des 20",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("D739AC8A-0C42-4C22-8102-2EBAB151B0B0"),
                AnimalCode = "TR161002684601",
                StallId = new Guid("D3537BAF-93C4-404A-AB80-A8C4D8308F2F"),
                BreedId = new Guid("3DC9A4BF-2075-4A0E-BB1D-3437C4604460"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2020-01-01"),
                ExpectedBirthDate = DateTime.Parse("2020-09-30"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 45567,
                Description = "Des 21",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("8ACC5C0F-0044-4335-B934-74C5BD5AE2EE"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("BA63BF5A-4E57-4662-ACCF-7F5FA3124C18"),
                BreedId = new Guid("31798234-B9F7-41FB-BB90-08ED320A104C"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2021-02-01"),
                ExpectedBirthDate = DateTime.Parse("2021-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 35759,
                Description = "Des 22",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("F5BEDC15-DD9C-45CC-84A1-D5BEE2F90B2A"),
                AnimalCode = "TR051000000001",
                StallId = new Guid("A181532F-42AF-46E9-8699-C3A78EF6F19A"),
                BreedId = new Guid("C65D7C9B-B1AD-49CD-909C-E8A9CC293E20"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 18771,
                Description = "Des 23",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("DE0FFA67-76B7-4322-A89B-60243984F62F"),
                AnimalCode = "TR191002684601",
                StallId = new Guid("D2F5F501-FFD8-4493-943C-AA3E6DD5AD56"),
                BreedId = new Guid("057B6C4F-B4D5-453F-9B12-7C3FEC96BB56"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 23737,
                Description = "Des 24",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("BEC09BBF-563A-42FC-9CCE-6D3DC81BFC56"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("3628D10A-E6B5-4E62-A58B-F2DD7379D83E"),
                BreedId = new Guid("2719F414-C3F0-4E63-A188-BB5A0411C4A0"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2020-01-01"),
                ExpectedBirthDate = DateTime.Parse("2020-09-30"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 42433,
                Description = "Des 25",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("67A70FE7-5FD0-431F-B61E-AD844D1EAC56"),
                AnimalCode = "TR051000000001",
                StallId = new Guid("9FC13177-9D38-47A9-B766-3C9FD5E061F7"),
                BreedId = new Guid("E387571F-7563-4164-8D0D-D08C051AEC3A"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2021-02-01"),
                ExpectedBirthDate = DateTime.Parse("2021-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 28744,
                Description = "Des 26",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("CAF20BDB-23F5-433C-A348-0AEDB31380A5"),
                AnimalCode = "TR111002684601",
                StallId = new Guid("62974800-9F92-4F6E-81D5-BF32EFD7623B"),
                BreedId = new Guid("F2B14DCA-3909-455F-B951-FBBBE1A94B85"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 25419,
                Description = "Des 27",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("30C3A51F-DD8F-4DB4-96F3-58AA7836F281"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("770465F9-4B85-46B0-800D-56064538F101"),
                BreedId = new Guid("93CC36D5-E829-43DC-92C4-1A5CBF110C24"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 49153,
                Description = "Des 28",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("35D948ED-791F-422A-B25E-C8D10A9EA9F8"),
                AnimalCode = "TR081000000001",
                StallId = new Guid("E0F6D7BA-AFF8-4175-91D1-D3639E5F8A59"),
                BreedId = new Guid("17C1F020-5420-4072-9EB7-5BA713484500"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2020-01-01"),
                ExpectedBirthDate = DateTime.Parse("2020-09-30"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 18341,
                Description = "Des 29",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("53048F51-EA57-4BFB-948E-0FD36580F4D0"),
                AnimalCode = "TR631002684601",
                StallId = new Guid("C79802DC-2BAF-41E1-8061-E51B8FEADD70"),
                BreedId = new Guid("CDE18D0D-C8D1-40E0-9EB8-8B6F9F84F77D"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2021-02-01"),
                ExpectedBirthDate = DateTime.Parse("2021-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 44012,
                Description = "Des 30",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("4C012B53-853A-4117-8ADC-CFF251AD0DF8"),
                AnimalCode = "TR011234567891",
                StallId = new Guid("5589EBB0-7A1B-4CFD-A5F2-6103DDBC7F41"),
                BreedId = new Guid("7DAA5E9D-B207-4DBF-A1E4-4CB99B7261F1"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 11464,
                Description = "Des 31",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("81F60EE5-C319-44D1-8B26-27C075AAC686"),
                AnimalCode = "TR051000000001",
                StallId = new Guid("07BF7A77-013F-4F2D-858A-F14E94D50594"),
                BreedId = new Guid("8A6E6FCE-D1EF-4ADB-AC47-E47040A1FAF8"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 32106,
                Description = "Des 32",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("BB7EE355-F1C6-4EB2-AC26-0E03264BD64C"),
                AnimalCode = "TR181002684601",
                StallId = new Guid("6BE62237-FBFC-4FDF-A273-6FDD9AEED5E6"),
                BreedId = new Guid("FC9A9C48-48D6-4D96-98C9-BBDFBE1C43E6"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2020-01-01"),
                ExpectedBirthDate = DateTime.Parse("2020-09-30"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 13316,
                Description = "Des 33",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("36C05022-0FAC-4A70-A13C-BF384E7C286A"),
                AnimalCode = "TR711234567891",
                StallId = new Guid("7F572C9A-2EA0-42AB-8496-2E9C66406096"),
                BreedId = new Guid("35ED99D4-9BC7-4CF4-955A-629B78B72364"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2021-02-01"),
                ExpectedBirthDate = DateTime.Parse("2021-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 21633,
                Description = "Des 34",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("D4EACAF7-83FA-4CED-A99E-B440CCBAC0E9"),
                AnimalCode = "TR651000000001",
                StallId = new Guid("3EBE2E2E-F4CD-45A3-95AB-AF7B54338DC8"),
                BreedId = new Guid("EB7C258F-582F-4E7D-B39D-ECBD1762C25D"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 19103,
                Description = "Des 35",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("F90CC058-218B-486A-9FD2-9F18825BC638"),
                AnimalCode = "TR361002684601",
                StallId = new Guid("C4206A96-3689-4E6C-8458-18516EC2DF83"),
                BreedId = new Guid("30CC0E18-AAB1-4F1E-A6D1-007C1E884C19"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 13872,
                Description = "Des 36",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("02838971-17CF-4505-A4AB-984605770CBC"),
                AnimalCode = "TR511234567891",
                StallId = new Guid("05E42717-6C08-4E3B-A31C-138016C5B19F"),
                BreedId = new Guid("24799A97-912A-4DFA-8A5A-5EC3478DA3EB"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2020-01-01"),
                ExpectedBirthDate = DateTime.Parse("2020-09-30"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 45507,
                Description = "Des 37",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("74350261-5437-4B2B-8BA0-F69BFBF03D6B"),
                AnimalCode = "TR451000000001",
                StallId = new Guid("E253515F-1AF6-420A-9BC3-4FB719E1DDB5"),
                BreedId = new Guid("5A278165-8B87-4F7F-A0F0-7A27D371D463"),
                BreedingType = 100,
                BreedingDate = DateTime.Parse("2021-02-01"),
                ExpectedBirthDate = DateTime.Parse("2021-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 20348,
                Description = "Des 38",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("96F5B320-5C4E-4A15-9F30-2FE367FC1496"),
                AnimalCode = "TR211002684601",
                StallId = new Guid("AE4BC981-DFD4-49FB-A87A-8A29DB2D343F"),
                BreedId = new Guid("3F18FFA5-1C73-49F0-A69D-8EAB3F290893"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 32262,
                Description = "Des 39",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Parse("2023-01-01"),
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new BreedingRecord
            {
                Id = new Guid("9FE6F0A0-40D2-4746-96EE-7D9667A0FE6D"),
                AnimalCode = "TR311234567891",
                StallId = new Guid("D0E5F1D2-3BE2-45DD-B9E0-65F6C2F50AEB"),
                BreedId = new Guid("463FCD5E-5D38-4A33-9981-C54020ADB26D"),
                BreedingType = 101,
                BreedingDate = DateTime.Parse("2022-02-01"),
                ExpectedBirthDate = DateTime.Parse("2022-11-01"),
                BreedingStatus = true,
                AnimalType = 100,
                Cost = 18474,
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
