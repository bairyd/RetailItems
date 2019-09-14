using System;
using Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Example.Persistence
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RetailDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<RetailDbContext>>()))
            {
                // Look for any board games.
                if (context.Cities.Any())
                {
                    return;   // Data was already seeded
                }

                context.Cities.AddRange(
                    new City
                    {
                        Id = 123L,
                        Name = "CPT"
                    },
                    new City
                    {
                        Id = 567L,
                        Name = "JHB"
                    },
                    new City
                    {
                        Id = 435L,
                        Name = "PTA"
                    });

                context.SaveChanges();
            }
        }
    }
}