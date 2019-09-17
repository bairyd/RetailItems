using Example.Domain.Model.Request;
using Example.Domain.Model.Response;

namespace Example.Domain.Service
{
    public interface IItemService
    {
        ServiceResponse GetAllItems();
        ServiceResponse GetAllItemsByLocation(long locationId);
        ServiceResponse GetItem(long itemId);
        ServiceResponse AddItem(ServiceRequest request);
    }
}