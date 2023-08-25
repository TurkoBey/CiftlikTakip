using CiftlikTakip.DataAccess.EF.Configurations;
using CiftlikTakip.DataAccess.EF.Configurations.DEMO;
using Microsoft.EntityFrameworkCore;

namespace CiftlikTakip.DataAccess.EF.Contexts
{
    public class FarmHerdContext : DbContext
    {
        public FarmHerdEntities? FarmHerdEntities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalBreedConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalStallConfiguration());
            modelBuilder.ApplyConfiguration(new AnimalTreatmentConfiguration());
            modelBuilder.ApplyConfiguration(new BreedingRecordConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new UserAccessPermissionConfiguration());
            modelBuilder.ApplyConfiguration(new WebsiteInfoConfiguration());
            modelBuilder.ApplyConfiguration(new FContactConfiguration());
            modelBuilder.ApplyConfiguration(new FFaqConfiguration());
            modelBuilder.ApplyConfiguration(new FPricingConfiguration());
            modelBuilder.ApplyConfiguration(new FServiceConfiguration());
            modelBuilder.ApplyConfiguration(new FTeamConfiguration());


            #region Migration İçin Hazır Data
            Demo10WebsiteInfo.Data(modelBuilder);
            Demo15Employees.Data(modelBuilder);
            Demo18UserAccessPermissions.Data(modelBuilder);
            Demo19Companies.Data(modelBuilder);
            Demo21AnimalStalls.Data(modelBuilder);
            Demo22BreedingRecords.Data(modelBuilder);
            Demo23AnimalBreeds.Data(modelBuilder);
            Demo25BreedingRecords.Data(modelBuilder);
            Demo27AnimalTreatments.Data(modelBuilder);
            Demo29FFaqs.Data(modelBuilder);
            Demo30FSevrices.Data(modelBuilder);
            Demo31FTeams.Data(modelBuilder);
            Demo32FPricings.Data(modelBuilder);
            #endregion
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Windows ( SQL Server Management )
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=FarmHerdDB2;Encrypt=False;Trusted_Connection=True;");

            // Windows ( SQL Server Object Explorer )
            //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FarmHerdDB;Trusted_Connection=True;");

            // macOS ( PostgreSQL ) 
            //optionsBuilder.UseSqlServer("server=localhost;database=FarmHerdDB;UserId=SA;Password=reallyStrongPwd123;MultipleActiveResultSets=true;");
        }
    }
}
