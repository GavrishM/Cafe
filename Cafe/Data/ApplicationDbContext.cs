using Cafe.Model;
using Microsoft.EntityFrameworkCore;

namespace Cafe.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
            //Database.Migrate();
        }
        public DbSet<Client> Client { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Worker> Worker { get; set; }
    }
}