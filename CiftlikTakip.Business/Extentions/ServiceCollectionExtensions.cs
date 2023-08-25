using CiftlikTakip.Business.Implementations;
using CiftlikTakip.Business.Interfaces;
using CiftlikTakip.Business.Profiles;
using CiftlikTakip.DataAccess.EF.Repositories;
using CiftlikTakip.DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CiftlikTakip.Business.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BreedingRecordProfile));

            services.AddScoped<IAnimalBreedBs, AnimalBreedBs>();
            services.AddScoped<IAnimalBreedRepository, AnimalBreedRepository>();

            services.AddScoped<IAnimalStallBs, AnimalStallBs>();
            services.AddScoped<IAnimalStallRepository, AnimalStallRepository>();

            services.AddScoped<IAnimalTreatmentBs, AnimalTreatmentBs>();
            services.AddScoped<IAnimalTreatmentRepository, AnimalTreatmentRepository>();

            services.AddScoped<IBreedingRecordBs, BreedingRecordBs>();
            services.AddScoped<IBreedingRecordRepository, BreedingRecordRepository>();

            services.AddScoped<ICompanyBs, CompanyBs>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();

            services.AddScoped<IEmployeeBs, EmployeeBs>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            services.AddScoped<IUserAccessPermissionBs, UserAccessPermissionBs>();
            services.AddScoped<IUserAccessPermissionRepository, UserAccessPermissionRepository>();

            services.AddScoped<IWebsiteInfoBs, WebsiteInfoBs>();
            services.AddScoped<IWebsiteInfoRepository, WebsiteInfoRepository>();

            services.AddScoped<IFContactBs, FContactBs>();
            services.AddScoped<IFContactRepository, FContactRepository>();

            services.AddScoped<IFFaqBs, FFaqBs>();
            services.AddScoped<IFFaqRepository, FFaqRepository>();

            services.AddScoped<IFPricingBs, FPricingBs>();
            services.AddScoped<IFPricingRepository, FPricingRepository>();

            services.AddScoped<IFServiceBs, FServiceBs>();
            services.AddScoped<IFServiceRepository, FServiceRepository>();

            services.AddScoped<IFTeamBs, FTeamBs>();
            services.AddScoped<IFTeamRepository, FTeamRepository>();
        }
    }
}
