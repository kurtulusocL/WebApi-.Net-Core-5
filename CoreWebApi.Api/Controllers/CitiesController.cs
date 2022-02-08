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
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;
        private readonly ICountryService _countryService;
        public CitiesController(ICityService cityService, ICountryService countryService)
        {
            _cityService = cityService;
            _countryService = countryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _cityService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("{countryId}")]
        public IActionResult GetCityByCountry(int? id)
        {
            var result = _cityService.GetCityByCountryId(id);
            if (result != null)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{detailId}")]
        public IActionResult Detail(int? id)
        {
            var result = _cityService.GetById(id);
            if (result != null)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{countryID}")]
        public IActionResult Create(int? id)
        {
            var getCountry = _countryService.GetById(id);
            if (getCountry != null)
            {
                return Ok(getCountry);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Create(City model)
        {
            if (ModelState.IsValid)
            {
                _cityService.Create(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult Edit(int? id)
        {
            var getCountry = _countryService.GetById(id);
            var updateCity = _cityService.GetById(id);

            if (updateCity != null && getCountry != null)
            {
                return Ok(updateCity);
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult Edit(City model)
        {
            if (ModelState.IsValid)
            {
                _cityService.Update(model);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{cityId}")]
        public ActionResult Delete(int? id)
        {
            var deleteCity = _cityService.GetById(id);
            if (deleteCity != null)
            {
                _cityService.Delete(deleteCity);
                return Ok();
            }
            return BadRequest();
        }
    }
}
