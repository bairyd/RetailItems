using System;
using System.Collections.Generic;
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
                    }
                );
                Item item1 = new Item
                {
                    Id = 1L,
                    Name = "T-Shirt",
                    Colour = "White",
                    Cost = 200.00M,
                    Size = "S",
                    InStock = true
                };
                
                Item item2 = new Item
                {
                    Id = 2L,
                    Name = "Pants",
                    Colour = "Black",
                    Cost = 400.00M,
                    Size = "M",
                    InStock = true
                };
                
                Item item3 = new Item
                {
                    Id = 3L,
                    Name = "Shoes",
                    Colour = "Yellow",
                    Cost = 350.00M,
                    Size = "S",
                    InStock = false
                };
                
                context.Retailers.AddRange(
                    new Retailer()
                    {
                        Id = 1L,
                        Name = "Woolworths",
                        Address = "Some Place in the Western Cape",
                        ContactNumber = "021 123 2138",
                        TradingHours = "08:00 - 19:00",
                        WebsiteUrl = "https://www.woolworths.com",
                        RetailerItems = new List<RetailerItem>{item1, item2, item3}
                    },
                    new Retailer()
                    {
                        Id = 2L,
                        Name = "Zara",
                        Address = "Some Place in the JHB",
                        ContactNumber = "011 959 2345",
                        TradingHours = "08:00 - 19:00",
                        WebsiteUrl = "https://www.zara.com",
                        Items = new List<Item>{item1, item2}
                    },
                    new Retailer()
                    {
                        Id = 3L,
                        Name = "CottonOn",
                        Address = "Some Place in the PTA",
                        ContactNumber = "011 959 2345",
                        TradingHours = "08:00 - 19:00",
                        WebsiteUrl = "https://www.cottonon.com",
                        Items = new List<Item>{item1, item3}
                    }
                );
                context.SaveChanges();
            }
        }
        
        
        
    }
}