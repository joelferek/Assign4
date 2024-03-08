using Assign4api1.Entities;

namespace Assign4api1.Repositories
{
    public interface ICityEvents
    {

        public Task<List<Event>> GetEvents(string CityName);
    }
}
