﻿using Example.Domain.Entities;
using Example.Domain.Model.Request;
using Example.Domain.Model.Response;
using Example.Domain.Persistence;
using Example.Domain.Service;

namespace Example.Application.ComparisonApp.Service
{
    public class CityService : ICityService
    {
        private readonly IRepository<City> _repository;
        
        public CityService(IRepository<City> repository)
        {
            _repository = repository;
        }

        public ServiceResponse GetAllCities()
        {
            var result = _repository.Get(null);
            return new ServiceResponse(result, true);
        }

        public ServiceResponse GetCity(int cityId)
        {
            var result = _repository.Get(cityId);
            return new ServiceResponse(result, true);
        }

        public ServiceResponse AddCity(ServiceRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}