using AutoMapper;
using CiftlikTakip.Model.Dtos.Employee;
using CiftlikTakip.Model.Entities;

namespace CiftlikTakip.Business.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeGetDto>();

            CreateMap<EmployeePutDto, Employee>();

            CreateMap<EmployeePostDto, Employee>();
        }
    }
}
