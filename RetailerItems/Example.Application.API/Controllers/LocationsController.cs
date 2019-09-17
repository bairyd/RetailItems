using Example.Domain.Entities;
using Example.Domain.Model.Response;
using Example.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace Example.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        
        [HttpGet]
        public ActionResult<ServiceResponse> GetAllLocations()
        {
            return _locationService.GetAllLocations();
        }

        [HttpGet("{id}")]
        public ActionResult<ServiceResponse> GetLocation(long id)
        {
            return _locationService.GetLocation(id);
        }

        [HttpPost]
        public ActionResult SaveLocation([FromBody] Location request)
        {
            var result = _locationService.AddLocation(null);
            return new JsonResult(result);
        }

        [HttpPut("{id}")]
        public void UpdateLocation(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void DeleteLocation(int id)
        {
        }
    }
}