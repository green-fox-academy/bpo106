using Microsoft.EntityFrameworkCore;
using Reddit.Models;

namespace Reddit.Entities
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
    }
}
