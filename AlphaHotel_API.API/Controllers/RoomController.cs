using AlphaHotel_API.Service.DTOs.Product;
using AlphaHotel_API.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AlphaHotel_API.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomReadService _readService;
        private readonly IRoomWriteService _writeService;

        public RoomController(IRoomReadService readService, IRoomWriteService writeService)
        {
            _readService = readService;
            _writeService = writeService;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]RoomCreateDto room)
        {
            await _writeService.CreateAsync(room);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _readService.GetAllAsync());
        }
    }
}
