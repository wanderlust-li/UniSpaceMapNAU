using System.ComponentModel.DataAnnotations;

namespace UniSpaceMapNAU.Domain.Entities;

public class Room
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int RoomNumber { get; set; }
    public string? Description { get; set; }
    [Required]
    public int FloorNumber { get; set; }
    public int RoomTypeId { get; set; }
    public RoomType RoomType { get; set; }
    public int FacultyId { get; set; }
    public Faculty Faculty { get; set; }
}