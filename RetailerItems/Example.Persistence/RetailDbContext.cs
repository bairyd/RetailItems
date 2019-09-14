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
            
            builder.Entity<RetailerItem>()
                .HasKey(pt => new { pt.ItemId, pt.RetailerId });

            builder.Entity<RetailerItem>()
                .HasOne(pt => pt.Item)
                .WithMany(p => p.RetailerItems)
                .HasForeignKey(pt => pt.ItemId);

            builder.Entity<RetailerItem>()
                .HasOne(pt => pt.Retailer)
                .WithMany(t => t.RetailerItems)
                .HasForeignKey(pt => pt.RetailerId);
        }
        
    }
}