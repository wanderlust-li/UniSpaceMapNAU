using System.ComponentModel.DataAnnotations;

namespace UniSpaceMapNAU.Domain.Entities;

public class Faculty
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>(); 
}