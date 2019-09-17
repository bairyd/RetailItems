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
                if (context.Locations.Any())
                {
                    return;   
                }

                var items = new[]
                {
                    new Item
                    {
                        Id = 1,
                        Name = "T-Shirt",
                        Colour = "White",
                        Cost = 200.00M,
                        Size = "S",
                        InStock = true
                    },
                    new Item
                    {
                        Id = 2,
                        Name = "Pants",
                        Colour = "Black",
                        Cost = 400.00M,
                        Size = "M",
                        InStock = true
                    },
                    new Item
                    {
                        Id = 3,
                        Name = "Shoes",
                        Colour = "Yellow",
                        Cost = 350.00M,
                        Size = "S",
                        InStock = false
                    },
                    new Item
                    {
                        Id = 4,
                        Name = "Tie",
                        Colour = "Purple",
                        Cost = 250.00M,
                        Size = "M",
                        InStock = true
                    }
                };

                var retailers = new[]
                {
                    new Retailer
                    {
                        Id = 1,
                        Name = "Woolworths",
                        Address = "Some Place in the Western Cape",
                        ContactNumber = "021 123 2138",
                        TradingHours = "08:00 - 19:00",
                        WebsiteUrl = "https://www.woolworths.com"
                    },
                    new Retailer
                    {
                        Id = 2,
                        Name = "Zara",
                        Address = "Some Place in the JHB",
                        ContactNumber = "011 959 2345",
                        TradingHours = "08:00 - 19:00",
                        WebsiteUrl = "https://www.zara.com"
                    },
                    new Retailer
                    {
                        Id = 3,
                        Name = "CottonOn",
                        Address = "Some Place in the PTA",
                        ContactNumber = "011 959 2345",
                        TradingHours = "08:00 - 19:00",
                        WebsiteUrl = "https://www.cottonon.com"
                    }
                };


                var locations = new[]
                {
                    new Location
                    {
                        Id = 1,
                        Name = "CPT"
                    },
                    new Location
                    {
                        Id = 2,
                        Name = "JHB"
                    },
                    new Location
                    {
                        Id = 3,
                        Name = "PTA"
                    },
                    new Location
                    {
                        Id = 4,
                        Name = "MZB"
                    }
                };
                context.AddRange(
                       new RetailerItem {Retailer = retailers[0], Item = items[0]},
                       new RetailerItem {Retailer = retailers[0], Item = items[1]},
                       new RetailerItem {Retailer = retailers[0], Item = items[2]},
                       new RetailerItem {Retailer = retailers[1], Item = items[1]},
                       new RetailerItem {Retailer = retailers[1], Item = items[2]},
                       new RetailerItem {Retailer = retailers[2], Item = items[0]},
                       new RetailerItem {Retailer = retailers[2], Item = items[2]},
                       new RetailerItem {Retailer = retailers[2], Item = items[3]}
                );
                context.AddRange(
                    new RetailerLocation{Retailer = retailers[0], Location = locations[0]},
                    new RetailerLocation{Retailer = retailers[0], Location = locations[1]},
                    new RetailerLocation{Retailer = retailers[0], Location = locations[2]},
                    new RetailerLocation{Retailer = retailers[0], Location = locations[3]},
                    new RetailerLocation{Retailer = retailers[1], Location = locations[2]},
                    new RetailerLocation{Retailer = retailers[1], Location = locations[3]},
                    new RetailerLocation{Retailer = retailers[2], Location = locations[0]},
                    new RetailerLocation{Retailer = retailers[2], Location = locations[1]},
                    new RetailerLocation{Retailer = retailers[2], Location = locations[3]}
                );
                context.SaveChanges();
            }
        }
        
        
        
    }
}