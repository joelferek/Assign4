using Assign4api1.Data;
using Assign4api1.Entities;
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
//Samantha Olivios API #1
public async Task<City> GetCityWithHighestEventCount()
{
    var cityWithHighestEventCount = await Task.Run(() => _dbcontextClass.Event.FromSqlRaw("exec GetCityWithHighestEventCount")

    return cityWithHighestEventCount;
}
