using Assign4api1.Entities;
using Assign4api1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assign4api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularCitycontroller : ControllerBase
    {
        private readonly CityEventsI _cityEvents;
        public PopularCitycontroller(CityEventsI cityEvents) { _cityEvents = cityEvents; }
        [HttpGet("highest event count")]
        public async Task<ActionResult<City>> GetCityWithHighestEventCount()
        { var cityWithHighestEventCount= await _cityEvents.GetCityWithHighestEventCount();
        if (cityWithHighestEventCount == null)
            {
                return NotFound();
            }
            return Ok(cityWithHighestEventCount);
        }
    }
}
