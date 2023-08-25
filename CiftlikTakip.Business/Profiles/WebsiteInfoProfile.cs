using AutoMapper;
using CiftlikTakip.Business.Utilities;
using CiftlikTakip.Model.Dtos.WebsiteInfo;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class WebsiteInfoProfile : Profile
    {
        public WebsiteInfoProfile()
        {
            CreateMap<WebsiteInfo, WebsiteInfoGetDto>()
                .ForMember(dest => dest.Version,
                       opt => opt.MapFrom(src => ConvertorHelper.ByteArrayToString(src.Version)));

            CreateMap<WebsiteInfoPutDto, WebsiteInfo>();
        }
    }
}
