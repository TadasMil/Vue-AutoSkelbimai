using AutoAdvert.Data;
using AutoAdvert.Models;
using AutoAdvert.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoAdvert.Services
{
    public class AdvertService : IGenericService<Advert>
    {
        public ApplicationDbContext _context;
        public AdvertService (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Delete(int id)
        {
            var advert = await _context.Adverts.Include(x => x.Car).FirstOrDefaultAsync(x => x.Id == id);
            var getAdvertsCar = await _context.Cars.FirstOrDefaultAsync(x => x.Id == advert.Car.Id);

            if (advert != null)
            {
                _context.Adverts.Remove(advert);
                _context.Cars.Remove(getAdvertsCar);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<Advert>> GetAll() => await _context.Adverts.Include(x => x.Car).ToListAsync();
        public async Task<Advert> GetById(int id)
        {
            var advertById = await _context.Adverts.Include(x => x.Car).ThenInclude(y => y.Images).FirstOrDefaultAsync(x => x.Id == id);

            if(advertById == null)
            {
                return null;
            }

            return advertById;
        }
        public void Insert(Advert obj)
        {
            _context.Adverts.Add(obj);
            _context.SaveChanges();
        }
        public void Update(Advert obj)
        {
            var findAdvert = _context.Adverts.Find(obj.Id);

            _context.Entry(findAdvert).CurrentValues.SetValues(obj);
            _context.SaveChanges();
            
        }
    }
}
