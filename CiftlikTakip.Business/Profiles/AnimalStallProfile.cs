using AutoMapper;
using CiftlikTakip.Model.Dtos.AnimalStall;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class AnimalStallProfile : Profile
    {
        public AnimalStallProfile()
        {
            CreateMap<AnimalStall, AnimalStallGetDto>();

            CreateMap<AnimalStallPutDto, AnimalStall>();

            CreateMap<AnimalStallPostDto, AnimalStall>();
        }
    }
}
