using AutoMapper;
using UniSpaceMapNAU.Application.DTOs.Department;

namespace UniSpaceMapNAU.Application.MappingProfiles.Department;

public class DepartmentProfile : Profile
{
    public DepartmentProfile()
    {
        CreateMap<Domain.Entities.Department, DepartmentDTO>().ReverseMap();
    }
}