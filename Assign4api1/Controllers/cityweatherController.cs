using Assign4api1.Entities;
using Assign4api1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assign4api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cityweatherController : Controller
    {
        private readonly ICityWeather CityWeather;
        public cityweatherController(ICityWeather CityWeather)
        {
            this.CityWeather = CityWeather;
        }
        [HttpGet("{CityID}")]
        public async Task<List<City>> GetWeather(string CityID)
        {
            var citydetails = await CityWeather.GetWeather(CityID);
            if (citydetails == null)
            {
                //return NotFound();
            }
            return citydetails;
        }

    }
}



