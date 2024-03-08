using Assign4api1.Data;
using Assign4api1.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Assign4api1.Repositories
{
    public class CityEvents : ICityEvents
    {
        private readonly DbcontextClass _dbcontextClass;
        public CityEvents(DbcontextClass dbcontextClass)
        {
            _dbcontextClass = dbcontextClass;
        }
        public async Task<List<Event>> GetEvents(string CityName)
        {
            var param = new SqlParameter("@CityName", CityName);
            var cityevents = await Task.Run(() => _dbcontextClass.Event.FromSqlRaw("exec GetEventsByCityName @CityName", param).ToListAsync());
            return cityevents;

        }
    }
}
