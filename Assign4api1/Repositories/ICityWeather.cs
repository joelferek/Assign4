using Assign4api1.Entities;

namespace Assign4api1.Repositories
{
    public interface ICityWeather
    {

        public Task<List<City>> GetWeather(string CityID);
    }
}
