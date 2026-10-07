using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebAutoApp2.Data.Domain;

namespace WebAutoApp2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           this.Database.EnsureCreated();
        }
        public DbSet<Car> Cars { get; set; } = null!;

        public DbSet<Client> Clients { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;
        public object DataBase { get; }
    }
}
