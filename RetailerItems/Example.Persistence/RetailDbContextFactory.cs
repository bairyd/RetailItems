using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Example.Persistence
{
    public class RetailDBContextFactory : IDesignTimeDbContextFactory<RetailDbContext>
    {
        public RetailDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RetailDbContext>();
            optionsBuilder.UseSqlite("Data Source=retail.db");

            return new RetailDbContext(optionsBuilder.Options);
        }
    }
}