using AutoMapper;
using UniSpaceMapNAU.Application.DTOs.Faculty;

namespace UniSpaceMapNAU.Application.MappingProfiles.Faculty;

public class FacultyProfile : Profile
{
    public FacultyProfile()
    {
        CreateMap<Domain.Entities.Faculty, FacultyDTO>().ReverseMap();
        CreateMap<Domain.Entities.Faculty, FacultyWithDepartmentDTO>().ReverseMap();
    }
}