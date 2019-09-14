﻿using Example.Domain.Model.Response;
using Example.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace Example.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("{id}")]
        public ActionResult<ServiceResponse> GetCity(int id)
        {
            return _cityService.GetCity(id);
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