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
        private readonly AdvertService _advertService;


        public CarsController(CarServices service, AdvertService advertService)
        {
            _service = service;
            _advertService = advertService;
        }

        // GET: api/Cars
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Advert>>> GetCars([FromBody] CarDto car)
        {
            var cars = await _service.GetCars(car);

            var adverts = await _advertService.GetAdvertToSpecificCar(cars);

            return adverts;
        }
    }
}
