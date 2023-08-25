using AutoMapper;
using CiftlikTakip.Model.Dtos.FPricing;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class FPricingProfile : Profile
    {
        public FPricingProfile()
        {
            CreateMap<FPricing, FPricingGetDto>();

            CreateMap<FPricingPutDto, FPricing>();

            CreateMap<FPricingPostDto, FPricing>();
        }
    }
}
