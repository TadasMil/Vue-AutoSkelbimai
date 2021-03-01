using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoAdvert.Models;
using AutoAdvert.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoAdvert.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributesController : ControllerBase
    {
        private readonly AttributeService _attrService;

        public AttributesController(AttributeService attrService)
        {
            _attrService = attrService;
        }

        [HttpGet]
        public async Task<ActionResult<Attributes>> GetAttributes()
        {
            try
            {
                return await _attrService.GetAllAtrributes();
            } catch
            {
                throw;
            }
        }
    }
}
