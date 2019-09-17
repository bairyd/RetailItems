using Example.Domain.Model.Request;
using Example.Domain.Model.Response;

namespace Example.Domain.Service
{
    public interface ILocationService
    {
        ServiceResponse GetAllLocations();
        ServiceResponse GetLocation(long locationId);
        ServiceResponse AddLocation(ServiceRequest request);
    }
}