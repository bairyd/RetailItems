using Microsoft.AspNetCore.Mvc;

namespace Example.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetailersController: ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<string> GetCity(int id)
        {
            return "Hello";
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