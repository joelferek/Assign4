using Assign4api1.Data;
using Assign4api1.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace Assign4api1.Repositories
{
    public class CityEventsI :ICityEvents
    {
        private readonly DbcontextClass _dbcontextClass;

        public EventsinCity(DbcontextClass dbcontextClass);
    }
     {   _dbcontextClass = dbcontextClass; }
//Samantha Olivios API #2
public async Task<list<Event>> FindCheapestEvents()
{
    var cheapestEvents = await Task.Run(() => _dbcontextClass.Event.FromSqlRaw("exec FindCheapestEvents")
    .ToListAsync();

    return cheapestEvents;
}

}
