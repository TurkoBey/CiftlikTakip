using AutoMapper;
using CiftlikTakip.Model.Dtos.Company;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyGetDto>();

            CreateMap<CompanyPostDto, Company>();

            CreateMap<CompanyPutDto, Company>();
        }
    }
}
