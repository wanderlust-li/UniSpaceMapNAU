using UniSpaceMapNAU.Application.DTOs.Faculty;
using UniSpaceMapNAU.Domain.Entities;

namespace UniSpaceMapNAU.Application.Interfaces.IServices;

public interface IFacultyService
{
    Task<IEnumerable<FacultyDTO>> GetAllFaculty();
    Task<IEnumerable<FacultyWithDepartmentDTO>> GetAllFacultiesWithDepartments();
    Task<FacultyDTO> GetFacultyById(int id);
}