using Microsoft.AspNetCore.Mvc;
using UniSpaceMapNAU.Application.Interfaces.IServices;

namespace UniSpaceMapNAU.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomTypeController : ControllerBase
{
   private readonly IRoomTypeService _roomTypeService;

   public RoomTypeController(IRoomTypeService roomTypeService)
   {
      _roomTypeService = roomTypeService;
   }

   [HttpGet("get-all-room-type")]
   public async Task<IActionResult> GetAllRoomTypes() =>
      Ok(await _roomTypeService.GetAllRoomType());

   [HttpGet("get-room-type-by-id")]
   public async Task<IActionResult> GetRoomTypeById(int id) =>
      Ok(await _roomTypeService.GetRoomTypeById(id));
}