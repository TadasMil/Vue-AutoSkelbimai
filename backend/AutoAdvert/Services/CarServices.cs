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

        public async Task<IEnumerable<Car>> GetCars(CarDto car)
        {
            //var cars = _context.Cars.Where(x => (x.Name != null && x.Name == car.Name) || (x.Model != null && x.Model == car.Model) || (x.Gear != null && x.Gear == car.Gear));

            var cars = _context.Cars.Where(x => string.IsNullOrEmpty(car.Name) || (!string.IsNullOrEmpty(car.Name) && x.Name == car.Name))
            .Where(x => string.IsNullOrEmpty(car.Model) || (!string.IsNullOrEmpty(car.Model) && x.Model == car.Model))
            .Where(x => string.IsNullOrEmpty(car.FuelType) || (!string.IsNullOrEmpty(car.FuelType) && x.FuelType == car.FuelType))
            .Where(x => string.IsNullOrEmpty(car.WheelPosition) || (!string.IsNullOrEmpty(car.WheelPosition) && x.WheelPosition == car.WheelPosition))
            .Where(x => string.IsNullOrEmpty(car.City) || (!string.IsNullOrEmpty(car.City) && x.City == car.City))
            .Where(x => string.IsNullOrEmpty(car.Wheels) || (!string.IsNullOrEmpty(car.Wheels) && x.Wheels == car.Wheels))
            .Where(x => string.IsNullOrEmpty(car.BodyType) || (!string.IsNullOrEmpty(car.BodyType) && x.BodyType == car.BodyType))
            .Where(x => string.IsNullOrEmpty(car.Color) || (!string.IsNullOrEmpty(car.Color) && x.Color == car.Color))
            .Where(x => string.IsNullOrEmpty(car.FirstRegistration) || (!string.IsNullOrEmpty(car.FirstRegistration) && x.FirstRegistration == car.FirstRegistration))
            .Where(x => string.IsNullOrEmpty(car.Gear) || (!string.IsNullOrEmpty(car.Gear) && x.Gear == car.Gear));

            if (car.Price != null || car.PriceTo != null)
            {
                if (car.Price != null && car.PriceTo != null)
                {
                    cars = cars.Where(x => x.Price >= car.Price && x.Price <= car.PriceTo);
                }
                else
                {
                    cars = cars.Where(x => (x.Price >= car.Price) || (x.Price <= car.PriceTo));
                };
            };

            if (car.Power != null || car.PowerTo != null)
            {
                if (car.Power != null && car.PowerTo != null)
                {
                    cars = cars.Where(x => x.Power >= car.Power && x.Power <= car.PowerTo);
                }
                else
                {
                    cars = cars.Where(x => (x.Power >= car.Power) || (x.Power <= car.PowerTo));
                };
            };

            if (car.Miles != null || car.MilesTo != null)
            {
                if (car.Miles != null && car.MilesTo != null)
                {
                    cars = cars.Where(x => x.Miles >= car.Miles && x.Miles <= car.MilesTo);
                }
                else
                {
                    cars = cars.Where(x => (x.Miles >= car.Miles) || (x.Miles <= car.MilesTo));
                };
            };

            if (car.Seats != null || car.Seats != null)
            {
                if (car.Seats != null && car.SeatsTo != null)
                {
                    cars = cars.Where(x => x.Seats >= car.Seats && x.Seats <= car.SeatsTo);
                }
                else
                {
                    cars = cars.Where(x => (x.Seats >= car.Seats) || (x.Seats <= car.SeatsTo));
                };
            };

            if (car.Volume != null || car.Volume != null)
            {
                if (car.Volume != null && car.VolumeTo != null)
                {
                    cars = cars.Where(x => x.Volume >= car.Volume && x.Volume <= car.VolumeTo);
                }
                else
                {
                    cars = cars.Where(x => (x.Volume >= car.Volume) || (x.Volume <= car.VolumeTo));
                };
            };

            if (car.Year != null || car.Year != null)
            {
                if (car.Year != null && car.YearTo != null)
                {
                    cars = cars.Where(x => x.Year >= car.Year && x.Year <= car.YearTo);
                }
                else
                {
                    cars = cars.Where(x => (x.Year >= car.Year) || (x.Year <= car.YearTo));
                };
            };

            return cars.Include(x => x.Images).ToList();
        }

        public async Task<ActionResult<IEnumerable<Advert>>> GetCarsAdverts(IEnumerable<Car> cars)
        {
            List<Advert> adverts = new List<Advert>();

            foreach(Car car in cars)
            {
                var advert = _context.Adverts.Where(x => x.Car == car).Include(x => x.Car).FirstOrDefault();
                if (advert != null)
                {
                    adverts.Add(advert);
                }
            }

            return adverts.ToList();
        }
    }
}