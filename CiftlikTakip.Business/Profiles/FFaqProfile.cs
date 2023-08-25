using AutoMapper;
using CiftlikTakip.Model.Dtos.FFaq;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class FFaqProfile : Profile
    {
        public FFaqProfile()
        {
            CreateMap<FFaq, FFaqGetDto>();

            CreateMap<FFaqPutDto, FFaq>();

            CreateMap<FFaqPostDto, FFaq>();
        }
    }
}
