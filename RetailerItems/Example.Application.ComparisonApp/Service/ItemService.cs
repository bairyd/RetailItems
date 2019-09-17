using System.Collections.Generic;
using System.Linq;
using Example.Domain.Entities;
using Example.Domain.Model.Request;
using Example.Domain.Model.Response;
using Example.Domain.Persistence;
using Example.Domain.Service;
using Example.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Example.Application.ComparisonApp.Service
{
    public class ItemService : IItemService
    {
        private readonly RetailDbContext _dbContext;
        public ItemService(RetailDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ServiceResponse GetLocation(long locationId)
        {
            var result = _dbContext.Locations.Find(locationId);
            return new ServiceResponse(result, true);
        }

        public ServiceResponse AddLocation(ServiceRequest request)
        {
            var result = _dbContext.Locations.Add(new Location {Id = 123, Name = "Cape Town"});
            return new ServiceResponse(result, true);
        }

        public ServiceResponse GetAllItems()
        {
            var result = _dbContext.Items;
            return new ServiceResponse(result, true);
        }

        public ServiceResponse GetAllItemsByLocation(long locationId)
        {
            var result = _dbContext.Locations
                .Include(location => location.RetailerLocations)
                .ThenInclude(retailerLocations => retailerLocations.Retailer)
                .FirstOrDefault(p => p.Id == locationId);

            var locations = result.RetailerLocations.ToArray();
            var items = new List<Item>();
            foreach (var location in locations)
            {
                var resultingItems = _dbContext.Retailers
                    .Include(retailer => retailer.RetailerItems)
                    .ThenInclude(retailerItems => retailerItems.Item)
                    .FirstOrDefault(p => p.Id == location.RetailerId);
                items.AddRange(resultingItems.RetailerItems.Select(p => new Item
                    {
                        Colour = p.Item.Colour,
                        Cost = p.Item.Cost,
                        Id = p.Item.Id,
                        Name = p.Item.Name,
                        Size = p.Item.Size,
                        InStock = p.Item.InStock
                    })
                );
            }
            
            return new ServiceResponse(items, true);
        }

        public ServiceResponse GetItem(long itemId)
        {
            var result = _dbContext.Items.Find(itemId);
            return new ServiceResponse(result, true);
        }

        public ServiceResponse AddItem(ServiceRequest request)
        {
            var result = _dbContext.Items.Add(new Item {Id = 5, Name = "Tie", Colour = "Green", Cost = 150, Size = "Skinny", InStock = true});;
            _dbContext.SaveChanges();
            return new ServiceResponse(result, true);
        }
    }
}