using AutoMapper;
using Pustok.Business.DTOs;
using Pustok.Core.Entities;

namespace Pustok.Business.Profiles;

public class EmployeeDepartmentProfile : Profile
{
    public EmployeeDepartmentProfile()
    {

        CreateMap<Employee, EmployeeGetDTO>()
            .ForMember(dest => dest.DepartmentName,
                opt => opt.MapFrom(src => src.Department.Name));

        CreateMap<EmployeePostDTO, Employee>()
            .ForMember(dest => dest.IsActive,
                opt => opt.MapFrom(_ => true));

        CreateMap<EmployeePutDTO, Employee>();
    }
}
