using AutoMapper;
using Pustok.Business.DTOs;
using Pustok.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pustok.Business.Profiles;

public class DepartmentProfile : Profile
{
    public DepartmentProfile()
    {
        CreateMap<Department, DepartmentGetDTO>()
                .ForMember(dest => dest.EmployeeCount,
                   opt => opt.MapFrom(src => src.Employees.Count));

        CreateMap<DepartmentPostDTO, Department>()
            .ForMember(dest => dest.CreatedAt,
                opt => opt.MapFrom(_ => DateTime.UtcNow))
            .ForMember(dest => dest.IsActive,
                opt => opt.MapFrom(_ => true));

        CreateMap<DepartmentPutDTO, Department>();
    }
}
