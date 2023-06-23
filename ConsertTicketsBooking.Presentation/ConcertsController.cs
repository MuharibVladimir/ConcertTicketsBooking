using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using Shared;
using System.Runtime.CompilerServices;

namespace ConsertTicketsBooking.Presentation
{
    [Route("api/concerts")]
    [ApiController]
    public class ConcertsController: ControllerBase
    {
        private readonly IServiceManager _service;
        public ConcertsController(IServiceManager service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetConcerts()
        {
            var concerts = await _service.ConcertService.GetAllConcertsAsync(trackChanges: false);
            return Ok(concerts);
        }

        [HttpGet("party-concerts")]
        public async Task<IActionResult> GetPartyConcerts()
        {
            var partyConcerts = await _service.ConcertService.GetPartyConcertsAsync(trackChanges: false);
            return Ok(partyConcerts);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePartyConcert(PartyConcertForCreationDto partyConcert)
        {
            var concert = await _service.ConcertService.CreatePartyConcertAsync(partyConcert);
            return Ok(concert);
        }



    }
}