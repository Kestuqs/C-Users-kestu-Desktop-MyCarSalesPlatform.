using Microsoft.EntityFrameworkCore;
using MyCarSalesPlatform.Core.Models;

namespace MyCarSalesPlatform.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Listing> Listings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Listing>()
                .Property(l => l.Kaina)
                .HasPrecision(18, 2);
        }
    }
}
