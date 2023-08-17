using AlphaHotel_API.Service.DTOs.Product;
using AlphaHotel_API.Service.DTOs.Room;
using AlphaHotel_API.Service.Services.Interfaces.Room;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

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
        [Authorize(Roles = "SuperAdmin")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]RoomCreateDto room)
        {
            await _writeService.CreateAsync(room);
            return Ok();
        }
        [Authorize(Roles ="SuperAdmin, Member")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_readService.GetAll());
        }
        [HttpGet]
        public async Task<IActionResult> GetByIdAsync([FromQuery]string id)
        {
            return Ok(_readService.GetByIdAsync(id));
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromQuery][Required] string id, RoomUpdateDto room)
        {
            try
            {
                await _writeService.UpdateAsync(id, room);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
        [HttpGet]
        public IActionResult Search([FromQuery]string? search)
        {
            return Ok(_readService.Search(search is not null ? search.ToLower() : search));
        }
    }
}
