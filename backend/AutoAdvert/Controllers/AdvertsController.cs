using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoAdvert.Data;
using AutoAdvert.Models;
using AutoAdvert.Services;
using AutoAdvert.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoAdvert.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertsController : ControllerBase
    {
        private readonly IGenericService<Advert> _service;
        private readonly AttributeService _attrService;

        public AdvertsController(IGenericService<Advert> service, AttributeService attrService)
        {
            _service = service;
            _attrService = attrService;
        }
        // GET: api/Adverts
        [HttpGet]
        public async Task<ActionResult<List<Advert>>> GetAdverts()
        {
            return await _service.GetAll();
        }
        // GET: api/Adverts/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Advert>> GetAdvert(int id)
        {
            var advert = await _service.GetById(id);

            if (advert == null)
            {
                return NotFound(Content("Not Found"));
            }

            return Ok(advert);
        }
        // PUT: api/Adverts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> PutAdvert(int id, Advert advert)
        {
            if (id != advert.Id)
            {
                return BadRequest();
            }

            Advert advertId = await _service.GetById(advert.Id);

            if(advertId == null)
            {
                return NotFound(Content("Specific id is invalid"));
            }

            _service.Update(advert);

            return Ok(Content("Successfully created"));
        }
        // POST: api/Adverts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Advert>> PostAdvert(Advert advert)
        {
            try
            {
                _service.Insert(advert);

                await _attrService.InsertBrand(advert.Car);
                await _attrService.InsertColor(advert.Car);
                await _attrService.InsertCity(advert.Car);
                await _attrService.InsertBodyType(advert.Car);
                await _attrService.InsertFirstRegistration(advert.Car);

                return Ok(advert);
            } catch {
                throw;
            }
        }
        // DELETE: api/Adverts/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Advert>> DeleteAdvert(int id)
        {
            Advert advertId = await _service.GetById(id);

            if (advertId == null)
            {
                return NotFound(Content("Not found"));
            }

            await _service.Delete(id);

            return Ok(id);
        }

    }
}
