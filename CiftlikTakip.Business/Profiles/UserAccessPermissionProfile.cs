using AutoMapper;
using CiftlikTakip.Model.Dtos.UserAccessPermission;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class UserAccessPermissionProfile : Profile
    {
        public UserAccessPermissionProfile()
        {
            CreateMap<UserAccessPermission, UserAccessPermissionGetDto>()
                .ForMember(dest => dest.EmployeeName,
                        opt => opt.MapFrom(src => src.Employee != null ? src.Employee.FullName : null));
            
            CreateMap<UserAccessPermissionPutDto, UserAccessPermission>();

            CreateMap<UserAccessPermissionPostDto, UserAccessPermission>();
        }
    }
}
