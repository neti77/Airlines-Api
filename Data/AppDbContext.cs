using Microsoft.EntityFrameworkCore;

namespace Airline.API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Airline.API.Models.Airline> Airlines { get; set; }
    }
}
