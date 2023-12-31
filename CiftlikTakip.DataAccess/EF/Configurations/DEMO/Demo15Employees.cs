﻿using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Configurations.DEMO
{
    public class Demo15Employees
    {
        public static void Data(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = new Guid("3B7E6156-27AA-4FBD-B222-FC090B18A78A"),
                TCKN = "11111111110",
                FirstName = "Super",
                LastName = "Admin",
                Position = "admin",
                MobilePhone = "901111111111",
                StartDate = DateTime.Now,
                EndDate = null,
                SalaryType = "Saatlik",
                Image = "/assets/img/employee/1dccb014-06b9-42f2-935a-8f447e8997b8.jpg",
                Salary = 100,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 1",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("ED9BB364-C933-4349-BA2F-D75D31E6F203"),
                TCKN = "11111111110",
                FirstName = "Çiftlik Sürü",
                LastName = "Takip",
                Position = "admin",
                MobilePhone = "901111111112",
                StartDate = DateTime.Now,
                EndDate = null,
                SalaryType = "Gündelik",
                Image = "/assets/img/employee/6ef70c9c-6eca-416e-b3fd-109036b91529.jpg",
                Salary = 500,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 2",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("36F708B9-B2F6-4E6A-AD25-0884E97BC520"),
                TCKN = "11111111110",
                FirstName = "Donald",
                LastName = "DuBuque",
                Position = "Bakıcı",
                MobilePhone = "901111111113",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = null,
                SalaryType = "Haftalık",
                Image = "/assets/img/employee/c64be4e6-0eee-4c35-ae29-66c20f4d2b92.jpg",
                Salary = 3500,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 3",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("4F28A5A1-BB96-4145-AEE9-527640A18234"),
                TCKN = "11111111110",
                FirstName = "Dean",
                LastName = "Hammes",
                Position = "Bakıcı",
                MobilePhone = "901111111114",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = null,
                SalaryType = "Aylık",
                Salary = 1500,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 4",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("4A70F61F-7B88-47B9-9540-27E15601D219"),
                TCKN = "11111111110",
                FirstName = "Terrence",
                LastName = "Heathcote",
                Position = "Bakıcı",
                MobilePhone = "901111111115",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = null,
                SalaryType = "Saatlik",
                Salary = 100,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 5",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("BC217B02-185E-4365-AAFF-FB6D95E8FFCA"),
                TCKN = "11111111110",
                FirstName = "Marvin",
                LastName = "Stehr",
                Position = "Bakıcı",
                MobilePhone = "901111111116",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = DateTime.Parse("2023-01-21"),
                SalaryType = "Gündelik",
                Salary = 500,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 6",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("A702E166-4537-4C1B-8B51-7AE84E6975FB"),
                TCKN = "11111111110",
                FirstName = "Emanuel",
                LastName = "Quigley",
                Position = "Bakıcı",
                MobilePhone = "901111111117",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = null,
                SalaryType = "Haftalık",
                Salary = 3500,
                PaymentStatus = "Ödenmedi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 7",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("0926AA29-B156-4A02-8317-9E07522B2CA8"),
                TCKN = "11111111110",
                FirstName = "Travis",
                LastName = "Cronin",
                Position = "Bakıcı",
                MobilePhone = "901111111118",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = null,
                SalaryType = "Aylık",
                Salary = 1500,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 8",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("EE471A67-398B-4753-A532-DC0EB70695B1"),
                TCKN = "11111111110",
                FirstName = "Byron",
                LastName = "Purdy",
                Position = "Bakıcı",
                MobilePhone = "901111111119",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = DateTime.Parse("2023-06-04"),
                SalaryType = "Saatlik",
                Salary = 100,
                PaymentStatus = "Ödenmedi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 9",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = false
            }, new Employee
            {
                Id = new Guid("A30AEE76-ED4D-4575-9CC3-FE3D12900FF3"),
                TCKN = "11111111110",
                FirstName = "Marco",
                LastName = "Nienow",
                Position = "Bakıcı",
                MobilePhone = "901111111120",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = null,
                SalaryType = "Gündelik",
                Salary = 500,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 10",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("1171E854-DF6A-4C70-A6C1-7459C6724BD4"),
                TCKN = "11111111110",
                FirstName = "Gilberto",
                LastName = "Champlin",
                Position = "Bakıcı",
                MobilePhone = "901111111121",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = null,
                SalaryType = "Haftalık",
                Salary = 3500,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 11",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("F3E1BC7F-04D2-45E5-B6E9-71DD22300D77"),
                TCKN = "11111111110",
                FirstName = "Jermaine",
                LastName = "Purdy",
                Position = "Bakıcı",
                MobilePhone = "901111111122",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = null,
                SalaryType = "Aylık",
                Salary = 1500,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 12",
                CreatedBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                CreationDate = DateTime.Now,
                UpdateBy = new Guid("17F0DB84-DA65-4EE1-B23C-A590DDE9903C"),
                UpdateDate = DateTime.Now,
                IsActive = true,
                Version = BitConverter.GetBytes(DateTime.Now.Ticks)
            }, new Employee
            {
                Id = new Guid("F7BB5AD5-C467-4969-A672-A9BA7D32D860"),
                TCKN = "11111111110",
                FirstName = "Dwayne",
                LastName = "Lubowitz",
                Position = "Bakıcı",
                MobilePhone = "901111111123",
                StartDate = DateTime.Parse("2023-01-21"),
                EndDate = null,
                SalaryType = "Saatlik",
                Salary = 100,
                PaymentStatus = "Ödendi",
                DistrictId = new Guid("24F2D704-0B4D-4971-80AD-1EB570ACE97A"),
                Description = "Des 13",
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
