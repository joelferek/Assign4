using Assign4api1.Entities;
using Assign4api1.Repositories;
using Microsoft.AspNetCore.Mvc;



namespace Assign4api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase

    {
        private readonly EventsinCity _cityEvents;
        public EventsController(EventsinCity cityEvents) 
            { _cityEvents = cityEvents; }
        [HttpGet("cheapest events")]

        public async Task<ActionResult<List<Event>>> GetCheapestEvents()
        {
            var cheapestEvents = await _cityEvents.FindCheapestEvents();
            if (cheapestEvents == null)
                return NotFound();
        }
    }
}
