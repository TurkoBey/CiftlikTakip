using CiftlikTakip.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Contexts
{
    public class FarmHerdEntities : DbContext
    {
        public DbSet<AnimalBreed>? AnimalBreed { get; set; }
        public DbSet<AnimalStall>? AnimalStalls { get; set; }
        public DbSet<AnimalTreatment>? AnimalTreatments { get; set; }
        public DbSet<BreedingRecord>? BreedingRecords { get; set; }
        public DbSet<Company>? Companies { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<UserAccessPermission>? UserAccessPermissions { get; set; }
        public DbSet<WebsiteInfo>? WebsiteInfos { get; set; }
        public DbSet<FContact>? FContacts { get; set; }
        public DbSet<FFaq>? FFaqs { get; set; }
        public DbSet<FPricing>? FPricings { get; set; }
        public DbSet<FService>? FServices { get; set; }
        public DbSet<FTeam>? FTeams { get; set; }
    }
}
