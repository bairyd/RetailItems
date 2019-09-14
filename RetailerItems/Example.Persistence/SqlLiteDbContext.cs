using Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.Persistence
{
    public class SqlLiteDbContext : DbContext
    {
        public SqlLiteDbContext(DbContextOptions<SqlLiteDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}