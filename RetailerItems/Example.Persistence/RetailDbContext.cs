using Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.Persistence
{
    public class RetailDbContext : DbContext
    {
        public RetailDbContext(DbContextOptions options)
            : base(options)
        {
        }
        
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}