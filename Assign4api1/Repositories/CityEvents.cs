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
        //Joel Ferek first API
        public async Task<List<Event>> GetEvents(string CityID)
        {
            var param = new SqlParameter("@CityID", CityID);
            var cityevents = await Task.Run(() => _dbcontextClass.Event.FromSqlRaw("exec GetEventsByCityID @CityID", param).ToListAsync());
            return cityevents;

        }
       
    }
}
