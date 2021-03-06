using AutoAdvert.Data;
using AutoAdvert.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Services
{
    public class CarServices
    {
        public ApplicationDbContext _context;
        public CarServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<Car>>> GetCars(Car car)
        {
            var cars = _context.Cars.Where(x => x.Name == car.Name).Where(y => y.Model == car.Model);

            return cars.ToList();
        }
    }
}
