using AutoAdvert.Data;
using AutoAdvert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoAdvert.Services
{
    public class AttributeService
    {
        public ApplicationDbContext _context;
        public AttributeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Attributes> GetAllAtrributes()
        {
            var brands = await _context.Brands.ToListAsync();
            var colors = await _context.Colors.ToListAsync();
            var firstRegistrations = await _context.FirstRegistration.ToListAsync();
            var bodyTypes = await _context.BodyTypes.ToListAsync();
            var cities = await _context.Cities.ToListAsync();

            var attributes = new Attributes
            {
                brands = brands,
                colors = colors,
                firstRegistrations = firstRegistrations,
                bodyTypes = bodyTypes,
                cities = cities,
            };

            return attributes;
        }
        public async Task InsertBrand(Car car)
        {
            var findBrand = await _context.Brands.FirstOrDefaultAsync(x => x.Name == car.Name);
          
            if(findBrand == null)
            {
                var newBrand = new Brand()
                {
                    Name = car.Name,
                    Amount = 1,
                };

                await _context.Brands.AddAsync(newBrand);
                await _context.SaveChangesAsync();

                await InsertModel(newBrand, car);
            }

            if(findBrand != null)
            {
                var newBrand = findBrand;
                newBrand.Amount += 1;
                _context.Brands.Attach(newBrand).Property(x => x.Amount).IsModified = true;
                await _context.SaveChangesAsync();

                await InsertModel(newBrand, car);
            }
        }
        public async Task InsertModel(Brand brand, Car car)
        {
            var model = await _context.Models.FirstOrDefaultAsync(x => x.Name == car.Model);
           

            if (model == null)
            {
                var newModel = new Model()
                {
                    Brand = brand,
                    Name = car.Model,
                    Amount = 1,
                };

                await _context.Models.AddAsync(newModel);
                await _context.SaveChangesAsync();
            }

            if(model != null)
            {
                var newModel = model;
                newModel.Amount += 1;
                _context.Models.Attach(newModel).Property(x => x.Amount).IsModified = true;
                await _context.SaveChangesAsync();
            }
        }
        public async Task InsertColor(Car car)
        {
            var findColor = await _context.Colors.FirstOrDefaultAsync(x => x.Name.ToLower() == car.Color.ToLower());

            if(findColor == null)
            {
                var newColor = new Color()
                {
                    Name = car.Color,
                };

                await _context.Colors.AddAsync(newColor);
                await _context.SaveChangesAsync();
            }
        }
        public async Task InsertCity(Car car)
        {
            var findCity = await _context.Cities.FirstOrDefaultAsync(x => x.Name.ToLower() == car.City.ToLower());

            if (findCity == null)
            {
                var newCity = new City()
                {
                    Name = car.City,
                };

                await _context.Cities.AddAsync(newCity);
                await _context.SaveChangesAsync();
            }

        }
        public async Task InsertBodyType (Car car)
        {
            var findBodyType = await _context.BodyTypes.FirstOrDefaultAsync(x => x.Name.ToLower() == car.BodyType.ToLower());

            if (findBodyType == null)
            {
                var newBodyType = new BodyType()
                {
                    Name = car.BodyType,
                };

                await _context.BodyTypes.AddAsync(newBodyType);
                await _context.SaveChangesAsync();
            }
        }
        public async Task InsertFirstRegistration(Car car)
        {
            var findRegistrationDate = await _context.FirstRegistration.FirstOrDefaultAsync(x => x.Name.ToLower() == car.FirstRegistration.ToLower());

            if (findRegistrationDate == null)
            {
                var newRegistration = new FirstRegistration()
                {
                    Name = car.FirstRegistration,
                };

                await _context.FirstRegistration.AddAsync(newRegistration);
                await _context.SaveChangesAsync();
            }
        }
    }
}
