using Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.Persistence
{
    public class RetailDbContext : DbContext
    {
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Location> Locations { get; set; }
        
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
            
            builder.Entity<RetailerLocation>()
                .HasKey(pt => new { pt.LocationId, pt.RetailerId });

            builder.Entity<RetailerLocation>()
                .HasOne(pt => pt.Location)
                .WithMany(p => p.RetailerLocations)
                .HasForeignKey(pt => pt.LocationId);

            builder.Entity<RetailerLocation>()
                .HasOne(pt => pt.Retailer)
                .WithMany(t => t.RetailerLocations)
                .HasForeignKey(pt => pt.RetailerId);
        }
        
    }
}