using System.ComponentModel.DataAnnotations;

namespace UniSpaceMapNAU.Domain.Entities;

public class BuildingDetail
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
}