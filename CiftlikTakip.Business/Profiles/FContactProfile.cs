using AutoMapper;
using CiftlikTakip.Model.Dtos.FContact;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class FContactProfile : Profile
    {
        public FContactProfile()
        {
            CreateMap<FContact, FContactGetDto>();

            CreateMap<FContactPutDto, FContact>();

            CreateMap<FContactPostDto, FContact>();
        }
    }
}
