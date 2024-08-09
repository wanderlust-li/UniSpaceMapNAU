using System.ComponentModel.DataAnnotations;

namespace UniSpaceMapNAU.Domain.Entities;

public class Department
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int SpecialtyNumber { get; set; }
    public int FacultyId { get; set; }
    public virtual Faculty Faculty { get; set; }
    
    public virtual ICollection<StudentGroup> StudentGroups { get; set; } = new HashSet<StudentGroup>(); 
}