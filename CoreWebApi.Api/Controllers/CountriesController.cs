using CoreWebApi.Business.Abstract;
using CoreWebApi.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _countryService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("{detailId}")]
        public IActionResult Detail(int? id)
        {
            var result = _countryService.GetById(id);
            if (result != null)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Create(Country model)
        {
            if (ModelState.IsValid)
            {
                _countryService.Create(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult Edit(int? id)
        {
            var updateCountry = _countryService.GetById(id);
            if (updateCountry != null)
            {
                return Ok(updateCountry);
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult Edit(Country model)
        {
            if (ModelState.IsValid)
            {
                _countryService.Update(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int? id)
        {
            var deleteCountry = _countryService.GetById(id);
            if (deleteCountry != null)
            {
                _countryService.Delete(deleteCountry);
                return Ok();
            }
            return BadRequest();
        }
    }
}
