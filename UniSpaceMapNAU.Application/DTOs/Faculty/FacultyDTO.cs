using UniSpaceMapNAU.Domain.Entities;

namespace UniSpaceMapNAU.Application.DTOs.Faculty;

public class FacultyDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Department> Departments { get; set; } 

}