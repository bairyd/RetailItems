using Example.Domain.Model.Response;
using Example.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace Example.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailersController: ControllerBase
    {
        private readonly IRetailerService _retailerService;

        public RetailersController(IRetailerService retailerService)
        {
            _retailerService = retailerService;
        }
        [HttpGet("{id}")]
        public ActionResult<ServiceResponse> GetRetailer(int id)
        {
            return _retailerService.GetRetailer(id);
        }

        [HttpPost]
        public void SaveCity([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void UpdateCity(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void DeleteCity(int id)
        {
        }
    }
}