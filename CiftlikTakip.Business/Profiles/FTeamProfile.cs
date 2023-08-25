using AutoMapper;
using CiftlikTakip.Model.Dtos.FTeam;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class FTeamProfile : Profile
    {
        public FTeamProfile()
        {
            CreateMap<FTeam, FTeamGetDto>();

            CreateMap<FTeamPutDto, FTeam>();

            CreateMap<FTeamPostDto, FTeam>();
        }
    }
}
