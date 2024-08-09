using UniSpaceMapNAU.Application.DTOs.Department;
using UniSpaceMapNAU.Domain.Entities;

namespace UniSpaceMapNAU.Application.DTOs.Faculty;

public class FacultyWithDepartmentDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<DepartmentDTO> Departments { get; set; } 
}