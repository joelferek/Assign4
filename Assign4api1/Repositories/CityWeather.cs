using Assign4api1.Data;
using Assign4api1.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Assign4api1.Repositories
{
    public class CityWeather : ICityWeather
    {
        private readonly DbcontextClass _dbcontextClass;
        public CityWeather(DbcontextClass dbcontextClass)
        {
            _dbcontextClass = dbcontextClass;
        }
        public async Task<List<City>> GetWeather(string CityID)
        {
            var param = new SqlParameter("@CityID", CityID);
            var cityweather = await Task.Run(() => _dbcontextClass.City.FromSqlRaw("exec GetCityAndEventDetails @CityID", param).ToListAsync());
            return cityweather;

        }

    }
}
