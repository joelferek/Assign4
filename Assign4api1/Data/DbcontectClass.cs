using Assign4api1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assign4api1.Data
{
    public class DbcontextClass : DbContext
    {
        public DbcontextClass(DbContextOptions<DbcontextClass> options) : base(options)
        { }
        public DbSet<City> City { get; set; }
        public DbSet<Event> Event { get; set; }
    }
}
