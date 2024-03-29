using Assign4api1.Data;
using Assign4api1.Entities;
using Assign4api1.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;




namespace Assign4api1.Repositories
{
    public class EventsinCity : ICityEvents
    {
        private readonly DbcontextClass _dbcontextClass;

        public EventsinCity(DbcontextClass dbcontextClass);
    }
    {   _dbcontextClass = dbcontextClass; }

// Brian Cox API #1:

public async Task<Event> GetEventsByName()
{
    var eventNamed = await Task.Run(() => _dbcontextClass.Event.FromSqlRaw("exec GetEventsByName")

    return eventNamed;
}

// Brian Cox API #2:

public async Task<City> GetEventsListByTemp()
{
    var tempCity = await Task.Run(() => _dbcontextClass.Event.FromSqlRaw("exec GetEventsListByTemp")

    return tempCity;
}
