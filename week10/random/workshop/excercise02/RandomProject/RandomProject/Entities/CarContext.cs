using Microsoft.EntityFrameworkCore;
using RandomProject.Models;

namespace RandomProject.Entities
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}
