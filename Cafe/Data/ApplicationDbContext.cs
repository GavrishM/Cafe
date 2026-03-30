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
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Meal> Meals { get; set; }
    }
}
/*
 * Консоль диспетчера пакетов=>
* Add-Migration
* Update-Database
*/