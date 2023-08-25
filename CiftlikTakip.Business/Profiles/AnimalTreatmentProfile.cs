using AutoMapper;
using CiftlikTakip.Model.Dtos.AnimalTreatment;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class AnimalTreatmentProfile : Profile
    {
        public AnimalTreatmentProfile()
        {
            CreateMap<AnimalTreatment, AnimalTreatmentGetDto>()
                .ForMember(dest => dest.AnimalId,
                        opt => opt.MapFrom(src => src.BreedingRecord != null ? src.BreedingRecord.AnimalCode : null));

            CreateMap<AnimalTreatmentPutDto, AnimalTreatment>();

            CreateMap<AnimalTreatmentPostDto, AnimalTreatment>();
        }
    }
}
