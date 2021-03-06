using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoAdvert.Data;
using AutoAdvert.Models;

namespace AutoAdvert.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Models
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Model>>> GetModels([FromQuery]string brand)
        {
            var findBrand = await _context.Brands.FirstAsync(x => x.Name == brand);

            var findModels = await _context.Models.Where(x => x.Brand.Id == findBrand.Id).ToListAsync();
            return findModels;
        }
    }
}
