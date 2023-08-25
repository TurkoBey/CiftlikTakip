using AutoMapper;
using CiftlikTakip.Model.Dtos.FService;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class FServiceProfile : Profile
    {
        public FServiceProfile()
        {
            CreateMap<FService, FServiceGetDto>();

            CreateMap<FServicePutDto, FService>();

            CreateMap<FServicePostDto, FService>();
        }
    }
}
