using AutoMapper;
using CiftlikTakip.Model.Dtos.BreedingRecord;
using CiftlikTakip.Model.Entities;
using Infrastructure.Utilities.EnumExtensions;
using Infrastructure.Utilities.EnumUtilities;

namespace CiftlikTakip.Business.Profiles
{
    public class BreedingRecordProfile : Profile
    {
        public BreedingRecordProfile()
        {
            CreateMap<BreedingRecord, BreedingRecordGetDto>()
                .ForMember(dest => dest.BreedingName,
                       opt => opt.MapFrom(src => LocationTypeExtensions.ConvertToEnum(src.BreedingType)))
                .ForMember(dest => dest.AnimalTypeName,
                       opt => opt.MapFrom(src => BreedTypeExtensions.ConvertToEnum(src.AnimalType)));

            CreateMap<BreedingRecordPutDto, BreedingRecord>();
            CreateMap<BreedingRecordPostDto, BreedingRecord>();
        }
    }
}
