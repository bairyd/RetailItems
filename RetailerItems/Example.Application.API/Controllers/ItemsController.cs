using Example.Domain.Model.Request;
using Example.Domain.Model.Response;
using Example.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace Example.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController: ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }
        
        [HttpGet("{id}")]
        public ActionResult<ServiceResponse> GetItem(int id)
        {
            return _itemService.GetItem(id);
        }
        
        
        [HttpGet("Location/{id}")]
        public ActionResult<ServiceResponse> GetItemsByLocation(int id)
        {
            return _itemService.GetAllItemsByLocation(id);
        }

        [HttpPost]
        public void SaveItem([FromBody] dynamic item)
        {
            var request = new ServiceRequest
            {
                Request = item
            };
            _itemService.AddItem(request);
        }

        [HttpPut("{id}")]
        public void UpdateItem(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
        }
    }
}