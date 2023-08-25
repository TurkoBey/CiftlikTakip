using AutoMapper;
using CiftlikTakip.Model.Dtos.AnimalBreed;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.EnumExtensions;

namespace CiftlikTakip.Business.Profiles
{
    public class AnimalBreedProfile : Profile
    {
        public AnimalBreedProfile()
        {
            CreateMap<AnimalBreed, AnimalBreedGetDto>()
                .ForMember(dest => dest.GroupName,
                       opt => opt.MapFrom(src => BreedTypeExtensions.ConvertToEnum(src.GroupId)));

            CreateMap<AnimalBreedPutDto, AnimalBreed>()
                .ForMember(dest => dest.GroupId,
                       opt => opt.MapFrom(src => BreedTypeExtensions.ConvertToString(src.GroupName)));

            CreateMap<AnimalBreedPostDto, AnimalBreed>()
                .ForMember(dest => dest.GroupId,
                       opt => opt.MapFrom(src => BreedTypeExtensions.ConvertToString(src.GroupName)));
        }
    }
}
