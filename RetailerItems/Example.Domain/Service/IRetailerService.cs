using Example.Domain.Model.Request;
using Example.Domain.Model.Response;

namespace Example.Domain.Service
{
    public interface IRetailerService
    {
        ServiceResponse GetAllRetailers();
        ServiceResponse GetRetailer(int cityId);
        ServiceResponse AddRetailer(ServiceRequest request);
    }
}