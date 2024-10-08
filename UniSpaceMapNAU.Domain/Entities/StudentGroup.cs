using System.ComponentModel.DataAnnotations;

namespace UniSpaceMapNAU.Domain.Entities;

public class StudentGroup
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int DepartmentId { get; set; }
    public virtual Department Department { get; set; }
    // public virtual ICollection<Faculty> Faculties { get; set; } = new HashSet<Faculty>(); 
}