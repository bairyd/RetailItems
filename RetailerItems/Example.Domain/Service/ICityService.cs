using Example.Domain.Model.Request;
using Example.Domain.Model.Response;

namespace Example.Domain.Service
{
    public interface ICityService
    {
        ServiceResponse GetAllCities();
        ServiceResponse GetCity(int cityId);
        ServiceResponse AddCity(ServiceRequest request);
    }
}