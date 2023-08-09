using AlphaHotel_API.Service.DTOs.Partner;
using AlphaHotel_API.Service.Services.Interfaces.Partner;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AlphaHotel_API.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        private readonly IPartnerReadService _readService;
        private readonly IPartnerWriteService _writeService;

        public PartnerController(IPartnerWriteService writeService, IPartnerReadService readService)
        {
            _writeService = writeService;
            _readService = readService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]PartnerCreateDto partner)
        {
            await _writeService.CreateAsync(partner);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_readService.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute]string id) 
        { 
            return Ok(await _readService.GetByIdAsync(id));
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromQuery][Required] string id, PartnerUpdateDto partner)
        {
            try
            {
                await _writeService.UpdateAsync(id, partner);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
        [HttpGet]
        public IActionResult Search([FromQuery] string? search)
        {
            return Ok(_readService.Search(search is not null ? search.ToLower() : search));
        }
    }
}
