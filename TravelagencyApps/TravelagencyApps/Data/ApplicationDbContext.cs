using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using TravelagencyApps.Data.Domain;

namespace TravelagencyApps.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Bookings> Bookings { get; set; } = null!;
        public DbSet<Customer> Customer { get; set; } = null!;

        public DbSet<Guide> Guide { get; set; } = null!;

        public DbSet<TourPackages> TourPackages { get; set; } = null!;

        public DbSet<TourPackagesGuides> TourPackagesGuides { get; set; } = null!;
    }
}
