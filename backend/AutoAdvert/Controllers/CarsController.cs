using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoAdvert.Data;
using AutoAdvert.Models;
using AutoAdvert.Services;

namespace AutoAdvert.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarServices _service;

        public CarsController(CarServices service)
        {
            _service = service;
        }

        // GET: api/Cars
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Car>>> GetCars([FromBody] Car car)
        {
            var cars = await _service.GetCars(car);

            return cars;
        }
    }
}
