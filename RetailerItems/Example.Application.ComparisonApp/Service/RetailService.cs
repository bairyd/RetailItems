using System.Linq;
using Example.Domain.Entities;
using Example.Domain.Model.Request;
using Example.Domain.Model.Response;
using Example.Domain.Persistence;
using Example.Domain.Service;

namespace Example.Application.ComparisonApp.Service
{
    public class RetailService : IRetailerService
    {
        private readonly IRepository<Retailer> _repository;
        
        public RetailService(IRepository<Retailer> repository)
        {
            _repository = repository;
        }

        public ServiceResponse GetAllRetailers()
        {
            var result = _repository.GetAll();
            return new ServiceResponse(result, true);
        }

        public ServiceResponse GetRetailer(int cityId)
        {
            var result = _repository.GetById(cityId);
            return new ServiceResponse(result, true);
        }

        public ServiceResponse AddRetailer(ServiceRequest request)
        {
            var result = _repository.Create(new Retailer() {Id = 123L, Name = "Cape Town"});
            return new ServiceResponse(result, true);
        }
    }
}