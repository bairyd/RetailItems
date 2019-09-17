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
    public class LocationService : ILocationService
    {
        private readonly RetailDbContext _dbContext;
        public LocationService(RetailDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ServiceResponse GetAllLocations()
        {
            var result = _dbContext.Locations;
            return new ServiceResponse(result, true);
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
    }
}