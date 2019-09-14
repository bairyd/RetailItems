using Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.Persistence
{
    public class RetailDbContext : DbContext
    {
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<City> Cities { get; set; }
        
        public RetailDbContext(DbContextOptions options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        
    }
}