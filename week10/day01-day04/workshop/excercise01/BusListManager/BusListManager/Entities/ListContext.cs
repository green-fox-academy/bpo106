using BusListManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BusListManager.Entities
{
    public class ListContext : DbContext
    {
        public ListContext(DbContextOptions<ListContext> options) : base(options)
        {
        }

        public DbSet<Bus> List { get; set; }
    }
}