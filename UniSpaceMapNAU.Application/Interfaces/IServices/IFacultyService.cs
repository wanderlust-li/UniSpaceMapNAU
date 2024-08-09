using UniSpaceMapNAU.Application.DTOs.Faculty;

namespace UniSpaceMapNAU.Application.Interfaces.IServices;

public interface IFacultyService
{
    Task<IEnumerable<FacultyDTO>> GetAllFaculty();
}