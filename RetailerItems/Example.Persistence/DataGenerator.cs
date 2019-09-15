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
                if (context.Cities.Any())
                {
                    return;   
                }

                context.Cities.AddRange(
                    new City
                    {
                        Id = 1,
                        Name = "CPT"
                    },
                    new City
                    {
                        Id = 2,
                        Name = "JHB"
                    },
                    new City
                    {
                        Id = 3,
                        Name = "PTA"
                    }
                );

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
                
                context.AddRange(
                       new RetailerItem {Retailer = retailers[0], Item = items[0]},
                       new RetailerItem {Retailer = retailers[0], Item = items[1]},
                       new RetailerItem {Retailer = retailers[0], Item = items[2]},
                       new RetailerItem {Retailer = retailers[1], Item = items[1]},
                       new RetailerItem {Retailer = retailers[1], Item = items[2]},
                       new RetailerItem {Retailer = retailers[2], Item = items[0]},
                       new RetailerItem {Retailer = retailers[2], Item = items[2]}
                );
                context.SaveChanges();
            }
        }
        
        
        
    }
}