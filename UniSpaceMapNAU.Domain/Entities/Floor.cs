using System.ComponentModel.DataAnnotations;

namespace UniSpaceMapNAU.Domain.Entities;

public class Floor
{
    [Key]
    public int Id { get; set; }
    public int BuildingId { get; set; }
    public virtual Building Building { get; set; }
    public int FloorNumber { get; set; }
}