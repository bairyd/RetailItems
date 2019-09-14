using Microsoft.AspNetCore.Mvc;

namespace Example.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController: ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<string> GetItem(int id)
        {
            return "Hello";
        }

        [HttpPost]
        public void SaveItem([FromBody] string value)
        {
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