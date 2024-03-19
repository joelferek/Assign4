using Assign4api1.Entities;
using Assign4api1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assign4api1.Controllers
{
    [Route("appi/[controller]")]
    [ApiController]
    public class Citycontroller : Controller
    {
        private readonly ICityEvents cityEvents;
        public Citycontroller(ICityEvents cityEvents)
        {
            this.cityEvents = cityEvents;
        }
        [HttpGet("{CityID}")]
        public async Task<List<Event>> GetEvents(string CityID)
        {
            var citydetails = await cityEvents.GetEvents(CityID);
            if (citydetails == null)
            {
                //return NotFound();
            }
            return citydetails;



        }
    }
}

